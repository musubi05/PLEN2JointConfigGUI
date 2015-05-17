using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;
using System.Threading;
using Bluegiga;

namespace PLEN2JointConfigGUI
{
    public partial class Form1 : Form
    {
        Settings[] settings = new Settings[]
	    {
		    new Settings( 250, 1550, 900,  900  ),
		    new Settings( 250, 1550, 1150, 1150 ),
		    new Settings( 250, 1550, 1200, 1200 ),
		    new Settings( 250, 1550, 800,  800  ),
		    new Settings( 250, 1550, 800,  800  ),
		    new Settings( 250, 1550, 850,  850  ),
		    new Settings( 250, 1550, 1400, 1400 ),
		    new Settings( 250, 1550, 1200, 1200 ),
		    new Settings( 250, 1550, 850,  850  ),
		    new Settings( 250, 1550, 900,  900  ),
		    new Settings( 250, 1550, 950,  950  ),
		    new Settings( 250, 1550, 600,  600  ),
		    new Settings( 250, 1550, 1100, 1100 ),
		    new Settings( 250, 1550, 1000, 1000 ),
		    new Settings( 250, 1550, 1100, 1100 ),
		    new Settings( 250, 1550, 400,  400  ),
		    new Settings( 250, 1550, 580,  580  ),
		    new Settings( 250, 1550, 1000, 1000 )
	    };


        private Dictionary<string, string> portDict = new Dictionary<string, string>();
        private SerialPort serialPort = new SerialPort();
        BGLib bgLib = new BGLib();
        Thread bleCommandWriteThread;
        List<string> sendCommandList = new List<string>();

        private bool isConnected;
        private bool isAttributeWrited;
        private int selectedRadioBtnId;
        private int[] map = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        private readonly byte[] PLEN2_TX_CHARACTERISTIC_UUID =
	        {
		        0xF9, 0x0E, 0x9C, 0xFE, 0x7E, 0x05, 0x44, 0xA5, 0x9D, 0x75, 0xF1, 0x36, 0x44, 0xD6, 0xF6, 0x45
	        };



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // PCに接続されているCOMポートの一覧を取得．portDictに格納

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SerialPort");
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    string key = String.Format("{0} - {1}", queryObj["DeviceID"], queryObj["Caption"]);
                    portDict.Add(key, String.Format("{0}", queryObj["DeviceID"]));
                    comboBox1.Items.Add(key);
                    // BlueGigaのドングルに関してはあらかじめlistBoxを選択状態にしておく
                    if (key.Contains("Bluegiga Bluetooth Low Energy"))
                    {
                        comboBox1.SelectedIndex = comboBox1.Items.Count - 1;
                    }
                }
            }
            catch (ManagementException ex)
            {
                portDict.Add("0", "Error " + ex.Message);
            }
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            bgLib.BLEEventGAPScanResponse += new Bluegiga.BLE.Events.GAP.ScanResponseEventHandler(bgLib_BLEEventGAPScanResponse);
            bgLib.BLEEventConnectionStatus += new Bluegiga.BLE.Events.Connection.StatusEventHandler(bgLib_BLEEventConnectionStatus);
            bgLib.BLEEventATTClientProcedureCompleted += new Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventHandler(bgLib_BLEEventATTClientProcedureCompleted);
            radioButton1.Focus();
        }

        /***** メソッドデリゲート呼び出しメソッド *****/
        // ※ListBoxやTextboxなど，Formに関するオブジェクトはメインスレッド以外からの操作ができない．
        // 　本メソッドはメインスレッド上で動かす必要があるメソッドをメインスレッドに委託する操作を行う．
        public void ThreadSafeDelegate(MethodInvoker method)
        {
            if (InvokeRequired)
                BeginInvoke(method);
            else
                method.Invoke();
        }



        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] receiveRawData = new byte[serialPort.BytesToRead];
            serialPort.Read(receiveRawData, 0, serialPort.BytesToRead);

            // 受信データをメインスレッドにメッセージ送信（デバッグ用）
            //for (int i = 0; i < receiveRawData.Length; i++)
            //    rcvDataStr += receiveRawData[i].ToString() + " ";
            //serialCommProcessMessage(" << [RX] [" + serialPort.PortName + "] " + rcvDataStr);

            //bgLibに処理を委譲（受信データに応じたイベントが発生）
            for (int i = 0; i < receiveRawData.Length; i++)
                bgLib.Parse(receiveRawData[i]);
        }

        /// <summary>
        /// AtrributeWrite-データ送信完了メソッド（イベント呼び出し）
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">Args</param>
        void bgLib_BLEEventATTClientProcedureCompleted(object sender, Bluegiga.BLE.Events.ATTClient.ProcedureCompletedEventArgs e)
        {
            //serialCommProcessMessage(this, "ProcedureCompleted Result : " + e.result);

            // e.result == 0 ⇒データ送信正常完了
            if (e.result == 0)
                isAttributeWrited = true;
        }

        /***** GAPScanResponse検知メソッド（bgLibイベント呼び出し) *****/
        private void bgLib_BLEEventGAPScanResponse(object sender, Bluegiga.BLE.Events.GAP.ScanResponseEventArgs e)
        {
            // データパケットの長さが25以上であれば、UUIDが乗っていないかチェックする
            if (e.data.Length > 25)
            {
                byte[] data_buf = new byte[16];

                for (int i = 0; i < data_buf.Length; i++)
                    data_buf[i] = e.data[i + 9];

                // データパケットにUUIDが乗っていた場合
                if (Object.ReferenceEquals(data_buf, PLEN2_TX_CHARACTERISTIC_UUID))
                {
                    // PLEN2からのアドバタイズなので、接続を試みる
                    bgLib.SendCommand(serialPort, bgLib.BLECommandGAPConnectDirect(e.sender, 0, 60, 76, 100, 0));
                }
            }
            else
            {
                // 本来の接続手順を実装する。(具体的には以下の通りです。)
                // 1. ble_cmd_gap_connect_direct()
                // 2. ble_cmd_attclient_find_information()
                // 3. ble_evt_attclient_find_information_found()を処理し、UUIDを比較
                //     a. UUIDが一致する場合は、そのキャラクタリスティックハンドルを取得 → 接続完了
                //     b. 全てのキャラクタリスティックについてUUIDが一致しない場合は、4.以降の処理へ
                // 4. MACアドレスを除外リストに追加した後、ble_cmd_connection_disconnect()
                // 5. 再度ble_cmd_gap_discove()
                // 6. 1.へ戻る。ただし、除外リストとMACアドレスを比較し、該当するものには接続をしない。

                // CAUTION!: 以下は横着した実装。本来は上記の手順を踏むべき。
                // PLEN2からのアドバタイズなので、接続を試みる

                bgLib.SendCommand(serialPort, bgLib.BLECommandGAPConnectDirect(e.sender, 0, 60, 76, 100, 0));
            }
        }
        /// <summary>
        /// BLEクライアント接続完了メソッド（イベント呼び出し）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgLib_BLEEventConnectionStatus(object sender, Bluegiga.BLE.Events.Connection.StatusEventArgs e)
        {
            // PLENと接続完了
            if ((e.flags & 0x01) != 0)
            {
                isConnected = true;

                ThreadSafeDelegate(delegate
                {
                    // アドレス作成
                    for (int index = 0; index < 6; index++)
                        textBoxMac.Text += e.address[index].ToString("X2") + " ";
                });
            }
        }



        private void buttonConnectCOM_Click(object sender, EventArgs e)
        {
            isConnected = false;
            buttonConnectCOM.Enabled = false;
            buttonDisconnectCOM.Enabled = true;
            buttonScanPLEN2.Enabled = false;
            buttonDisconnectPLEN2.Enabled = false;

            // シリアルポート初期化
            serialPort.PortName = portDict[comboBox1.SelectedItem.ToString()];
            serialPort.Handshake = System.IO.Ports.Handshake.RequestToSend;
            serialPort.BaudRate = 115200;
            serialPort.DataBits = 8;
            serialPort.StopBits = System.IO.Ports.StopBits.One;
            serialPort.Parity = System.IO.Ports.Parity.None;
            try
            {
                serialPort.Open();
                buttonScanPLEN2.Enabled = true;
                MessageBox.Show(serialPort.PortName + "を開きました．");
                buttonScanPLEN2.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(serialPort.PortName + "を開けませんでした．" + System.Environment.NewLine + ex.Message);
            }
        }

        private void buttonDisconnectCOM_Click(object sender, EventArgs e)
        {
            try
            {
                if (isConnected == true)
                    buttonDisconnectPLEN2_Click(sender, e);

                serialPort.Close();
                buttonConnectCOM.Enabled = true;
                buttonDisconnectCOM.Enabled = false;
                buttonScanPLEN2.Enabled = false;
                buttonDisconnectPLEN2.Enabled = false;
                MessageBox.Show(serialPort.PortName + "を閉じました．");
            }
            catch (Exception ex)
            {
                MessageBox.Show(serialPort.PortName + "を閉じれませんでした．" + System.Environment.NewLine + ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            settings[selectedRadioBtnId].Now = trackBar1.Value;

            if (isConnected == true)
            {
                if (sendCommandList.Count == 0 || sendCommandList[sendCommandList.Count - 1] != ("#SA" + createCmd(selectedRadioBtnId, trackBar1.Value)))
                sendCommandList.Add("#SA" + createCmd(selectedRadioBtnId, trackBar1.Value));
            }
        }

        int valueOld = 0;
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if(timer1.Enabled == false || Math.Abs(valueOld - trackBar1.Value) > 100)
                trackBar1_Scroll(sender, e);

            valueOld = trackBar1.Value;
            labelBarValue.Text = trackBar1.Value.ToString();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < trackBar1.Maximum)
                trackBar1.Value++;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value > trackBar1.Minimum)
                trackBar1.Value--;
        }

        private void bleCommandWrite()
        {
            while (true)
            {
                if (sendCommandList.Count > 0)
                {
                    byte[] cmd = System.Text.Encoding.ASCII.GetBytes(sendCommandList[0]);

                    isAttributeWrited = false;
                    bgLib.SendCommand(serialPort, bgLib.BLECommandATTClientAttributeWrite(0, 31, cmd));
                    while (isAttributeWrited == false)
                        Thread.Sleep(1);

                    sendCommandList.RemoveAt(0);
                }
                else
                    Thread.Sleep(1);
            }

        }

        private void buttonScanPLEN2_Click(object sender, EventArgs e)
        {
            /*----- 半二重通信ここから -----*/
            bgLib.SendCommand(serialPort, bgLib.BLECommandGAPEndProcedure());
            while (bgLib.IsBusy() == true)
                Thread.Sleep(1);

            Thread.Sleep(10);
            bgLib.SendCommand(serialPort, bgLib.BLECommandConnectionDisconnect(0));
            while (bgLib.IsBusy() == true)
                Thread.Sleep(1);

            // PLEN2との接続を試みる
            isConnected = false;
            Thread.Sleep(10);
            bgLib.SendCommand(serialPort, bgLib.BLECommandGAPDiscover(1));
            while (isConnected == false)
                Thread.Sleep(1);

            /*-- ここからPLEN2と接続中 --*/
            MessageBox.Show("PLEN2と接続が完了しました．");
            buttonScanPLEN2.Enabled = false;
            buttonDisconnectPLEN2.Enabled = true;

            bleCommandWriteThread = new Thread(bleCommandWrite);
            bleCommandWriteThread.Start();
        }

        private void buttonDisconnectPLEN2_Click(object sender, EventArgs e)
        {
            if (isConnected == true)
            {
                bgLib.SendCommand(serialPort, bgLib.BLECommandConnectionDisconnect(0));
                while (bgLib.IsBusy())
                    Thread.Sleep(1);

                isConnected = false;
                buttonScanPLEN2.Enabled = true;
                buttonDisconnectPLEN2.Enabled = false;
                textBoxMac.Text = "";

                bleCommandWriteThread.Abort();

                MessageBox.Show("PLEN2との接続を解除しました．");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected == true)
            {
                bleCommandWriteThread.Abort();

                bgLib.SendCommand(serialPort, bgLib.BLECommandConnectionDisconnect(0));
                while (bgLib.IsBusy())
                    Thread.Sleep(1);

                isConnected = false;
            }         
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            changeMaxValue(trackBar1.Value);

            if (isConnected == true)
            {
                sendCommandList.Add("#MA" + createCmd(selectedRadioBtnId, trackBar1.Value));
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            changeHomeValue(trackBar1.Value);

            if (isConnected == true)
            {

                sendCommandList.Add("#HO" + createCmd(selectedRadioBtnId, trackBar1.Value));
            }

        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            changeMinValue(trackBar1.Value);

            if (isConnected == true)
            {
                sendCommandList.Add("#MI" + createCmd(selectedRadioBtnId, trackBar1.Value));
            }
        }

        private void loadJointSetting(object sender, EventArgs e)
        {
            // ※RadioButtonのtagに各Joint番号を記載している
            RadioButton selectedRadioBtn = (RadioButton)sender;

            if (selectedRadioBtn.Checked == true)
            {
                // 選択中のラジオボックス番号更新
                selectedRadioBtnId = int.Parse(selectedRadioBtn.Tag.ToString()) - 1;

                changeMaxValue(settings[selectedRadioBtnId].Max);
                changeHomeValue(settings[selectedRadioBtnId].Home);
                changeMinValue(settings[selectedRadioBtnId].Min);
                changeNowValue(settings[selectedRadioBtnId].Now);
            }
        }

        private string createCmd(int id, int angle)
        {
            return map[id].ToString("x2") + angle.ToString("x3");
        }

        private void changeMaxValue(int value)
        {
            buttonMax.Text = "Max (" + value + ")";
            settings[selectedRadioBtnId].Max = value;

        }
        private void changeHomeValue(int value)
        {
            buttonHome.Text = "Home (" + value + ")";
            settings[selectedRadioBtnId].Home = value;
        }
        private void changeMinValue(int value)
        {
            buttonMin.Text = "Min (" + value + ")";
            settings[selectedRadioBtnId].Min = value;
        }
        private void changeNowValue(int value)
        {
            trackBar1.Value = value;
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Start();
        }
        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1_Scroll(sender, e);
        }

    }
}
