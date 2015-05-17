namespace PLEN2JointConfigGUI
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelBarValue = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonMin = new System.Windows.Forms.Button();
            this.textBoxMac = new System.Windows.Forms.TextBox();
            this.buttonScanPLEN2 = new System.Windows.Forms.Button();
            this.buttonDisconnectPLEN2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDisconnectCOM = new System.Windows.Forms.Button();
            this.buttonConnectCOM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBar1.Location = new System.Drawing.Point(225, 51);
            this.trackBar1.Maximum = 1800;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 228);
            this.trackBar1.SmallChange = 5;
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Value = 900;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(276, 114);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(28, 23);
            this.buttonUp.TabIndex = 19;
            this.buttonUp.Text = "↑";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelBarValue
            // 
            this.labelBarValue.AutoSize = true;
            this.labelBarValue.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelBarValue.Location = new System.Drawing.Point(276, 155);
            this.labelBarValue.Name = "labelBarValue";
            this.labelBarValue.Size = new System.Drawing.Size(32, 16);
            this.labelBarValue.TabIndex = 20;
            this.labelBarValue.Text = "900";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(276, 193);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(28, 23);
            this.buttonDown.TabIndex = 21;
            this.buttonDown.Text = "↓";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(127, 114);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(82, 23);
            this.buttonMax.TabIndex = 22;
            this.buttonMax.Text = "Max (1550)";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(127, 154);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(82, 23);
            this.buttonHome.TabIndex = 23;
            this.buttonHome.Text = "Home (900)";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(127, 193);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(82, 23);
            this.buttonMin.TabIndex = 24;
            this.buttonMin.Text = "Min (250)";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // textBoxMac
            // 
            this.textBoxMac.Enabled = false;
            this.textBoxMac.Location = new System.Drawing.Point(204, 38);
            this.textBoxMac.Name = "textBoxMac";
            this.textBoxMac.Size = new System.Drawing.Size(274, 19);
            this.textBoxMac.TabIndex = 25;
            // 
            // buttonScanPLEN2
            // 
            this.buttonScanPLEN2.Enabled = false;
            this.buttonScanPLEN2.Location = new System.Drawing.Point(10, 36);
            this.buttonScanPLEN2.Name = "buttonScanPLEN2";
            this.buttonScanPLEN2.Size = new System.Drawing.Size(89, 23);
            this.buttonScanPLEN2.TabIndex = 26;
            this.buttonScanPLEN2.Text = "Scan PLEN2.";
            this.buttonScanPLEN2.UseVisualStyleBackColor = true;
            this.buttonScanPLEN2.Click += new System.EventHandler(this.buttonScanPLEN2_Click);
            // 
            // buttonDisconnectPLEN2
            // 
            this.buttonDisconnectPLEN2.Enabled = false;
            this.buttonDisconnectPLEN2.Location = new System.Drawing.Point(111, 36);
            this.buttonDisconnectPLEN2.Name = "buttonDisconnectPLEN2";
            this.buttonDisconnectPLEN2.Size = new System.Drawing.Size(79, 23);
            this.buttonDisconnectPLEN2.TabIndex = 27;
            this.buttonDisconnectPLEN2.Text = "Disconnect";
            this.buttonDisconnectPLEN2.UseVisualStyleBackColor = true;
            this.buttonDisconnectPLEN2.Click += new System.EventHandler(this.buttonDisconnectPLEN2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 20);
            this.comboBox1.TabIndex = 28;
            // 
            // buttonDisconnectCOM
            // 
            this.buttonDisconnectCOM.Enabled = false;
            this.buttonDisconnectCOM.Location = new System.Drawing.Point(111, 10);
            this.buttonDisconnectCOM.Name = "buttonDisconnectCOM";
            this.buttonDisconnectCOM.Size = new System.Drawing.Size(79, 23);
            this.buttonDisconnectCOM.TabIndex = 30;
            this.buttonDisconnectCOM.Text = "Disconnect";
            this.buttonDisconnectCOM.UseVisualStyleBackColor = true;
            this.buttonDisconnectCOM.Click += new System.EventHandler(this.buttonDisconnectCOM_Click);
            // 
            // buttonConnectCOM
            // 
            this.buttonConnectCOM.Location = new System.Drawing.Point(10, 10);
            this.buttonConnectCOM.Name = "buttonConnectCOM";
            this.buttonConnectCOM.Size = new System.Drawing.Size(89, 23);
            this.buttonConnectCOM.TabIndex = 29;
            this.buttonConnectCOM.Text = "Connect COM.";
            this.buttonConnectCOM.UseVisualStyleBackColor = true;
            this.buttonConnectCOM.Click += new System.EventHandler(this.buttonConnectCOM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.radioButton10);
            this.groupBox1.Controls.Add(this.radioButton11);
            this.groupBox1.Controls.Add(this.radioButton12);
            this.groupBox1.Controls.Add(this.radioButton13);
            this.groupBox1.Controls.Add(this.radioButton14);
            this.groupBox1.Controls.Add(this.radioButton15);
            this.groupBox1.Controls.Add(this.buttonMin);
            this.groupBox1.Controls.Add(this.radioButton16);
            this.groupBox1.Controls.Add(this.buttonHome);
            this.groupBox1.Controls.Add(this.radioButton17);
            this.groupBox1.Controls.Add(this.buttonMax);
            this.groupBox1.Controls.Add(this.radioButton18);
            this.groupBox1.Controls.Add(this.buttonDown);
            this.groupBox1.Controls.Add(this.radioButton9);
            this.groupBox1.Controls.Add(this.labelBarValue);
            this.groupBox1.Controls.Add(this.radioButton8);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(10, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 334);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton10.Location = new System.Drawing.Point(373, 259);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(89, 20);
            this.radioButton10.TabIndex = 26;
            this.radioButton10.Tag = "18";
            this.radioButton10.Text = "Joint : 18";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton11.Location = new System.Drawing.Point(373, 233);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(89, 20);
            this.radioButton11.TabIndex = 25;
            this.radioButton11.Tag = "17";
            this.radioButton11.Text = "Joint : 17";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton12.Location = new System.Drawing.Point(373, 207);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(89, 20);
            this.radioButton12.TabIndex = 24;
            this.radioButton12.Tag = "16";
            this.radioButton12.Text = "Joint : 16";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton13.Location = new System.Drawing.Point(373, 181);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(89, 20);
            this.radioButton13.TabIndex = 23;
            this.radioButton13.Tag = "15";
            this.radioButton13.Text = "Joint : 15";
            this.radioButton13.UseVisualStyleBackColor = true;
            this.radioButton13.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton14.Location = new System.Drawing.Point(373, 155);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(89, 20);
            this.radioButton14.TabIndex = 22;
            this.radioButton14.Tag = "14";
            this.radioButton14.Text = "Joint : 14";
            this.radioButton14.UseVisualStyleBackColor = true;
            this.radioButton14.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton15.Location = new System.Drawing.Point(373, 129);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(89, 20);
            this.radioButton15.TabIndex = 21;
            this.radioButton15.Tag = "13";
            this.radioButton15.Text = "Joint : 13";
            this.radioButton15.UseVisualStyleBackColor = true;
            this.radioButton15.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton16.Location = new System.Drawing.Point(373, 103);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(89, 20);
            this.radioButton16.TabIndex = 20;
            this.radioButton16.Tag = "12";
            this.radioButton16.Text = "Joint : 12";
            this.radioButton16.UseVisualStyleBackColor = true;
            this.radioButton16.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton17.Location = new System.Drawing.Point(373, 77);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(89, 20);
            this.radioButton17.TabIndex = 19;
            this.radioButton17.Tag = "11";
            this.radioButton17.Text = "Joint : 11";
            this.radioButton17.UseVisualStyleBackColor = true;
            this.radioButton17.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton18.Location = new System.Drawing.Point(373, 51);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(89, 20);
            this.radioButton18.TabIndex = 18;
            this.radioButton18.Tag = "10";
            this.radioButton18.Text = "Joint : 10";
            this.radioButton18.UseVisualStyleBackColor = true;
            this.radioButton18.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton9.Location = new System.Drawing.Point(6, 259);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(89, 20);
            this.radioButton9.TabIndex = 16;
            this.radioButton9.Tag = "9";
            this.radioButton9.Text = "Joint : 09";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton8.Location = new System.Drawing.Point(6, 233);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 20);
            this.radioButton8.TabIndex = 15;
            this.radioButton8.Tag = "8";
            this.radioButton8.Text = "Joint : 08";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton7.Location = new System.Drawing.Point(6, 207);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 20);
            this.radioButton7.TabIndex = 14;
            this.radioButton7.Tag = "7";
            this.radioButton7.Text = "Joint : 07";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton6.Location = new System.Drawing.Point(6, 181);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(89, 20);
            this.radioButton6.TabIndex = 13;
            this.radioButton6.Tag = "6";
            this.radioButton6.Text = "Joint : 06";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton5.Location = new System.Drawing.Point(6, 155);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 20);
            this.radioButton5.TabIndex = 12;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "Joint : 05";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton4.Location = new System.Drawing.Point(6, 129);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "Joint : 04";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton3.Location = new System.Drawing.Point(6, 103);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Joint : 03";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton2.Location = new System.Drawing.Point(6, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Joint : 02";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButton1.Location = new System.Drawing.Point(6, 51);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Joint : 01";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.loadJointSetting);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 429);
            this.Controls.Add(this.buttonDisconnectCOM);
            this.Controls.Add(this.buttonConnectCOM);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDisconnectPLEN2);
            this.Controls.Add(this.buttonScanPLEN2);
            this.Controls.Add(this.textBoxMac);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Joint : 01";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelBarValue;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.TextBox textBoxMac;
        private System.Windows.Forms.Button buttonScanPLEN2;
        private System.Windows.Forms.Button buttonDisconnectPLEN2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDisconnectCOM;
        private System.Windows.Forms.Button buttonConnectCOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Timer timer1;
    }
}

