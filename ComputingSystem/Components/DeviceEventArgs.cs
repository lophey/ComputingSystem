using System;
using System.Collections.Generic;
using System.Text;

namespace ComputingSystem.Components
{
    internal class DeviceEventArgs : EventArgs
    {
        public int Device
        {
            get;
            set;
        }
    }
}
