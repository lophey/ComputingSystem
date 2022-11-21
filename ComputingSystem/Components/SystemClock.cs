using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem.Components
{
    public class SystemClock : INotifyPropertyChanged
    {
        public void WorkingCycle()
        {
            clock++;
        }

        public void Clear()
        {
            clock = 0;
        }

        public long Clock
        {
            get
            {
                return clock;
            }
            private set
            {
                clock = value;
                OnPropertyChanged();
            }
        }
        private long clock;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }

}
