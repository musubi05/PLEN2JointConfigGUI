using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PLEN2JointConfigGUI
{
    public class Settings
    {
        public int Max;
        public int Min;
        public int Home;
        public int Now;
        public Settings(int min, int max, int home, int now)
        {
            Max = max;
            Min = min;
            Home = home;
            Now = now;
        }
    }
}
