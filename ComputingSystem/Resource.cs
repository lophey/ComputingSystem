using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComputingSystem
{
    public class Resource : INotifyPropertyChanged
    {
        public void WorkingCycle()
        {
            if (!IsFree())
            {
                activeProcess.IncreaseWorkTime();
            }
        }

        public bool IsFree()
        {
            return activeProcess == null;
        }

        public void Clear()
        {
            activeProcess = null;
        }

        public Process ActiveProcess
        {
            get
            {
                return activeProcess;
            }
            set
            {
                activeProcess = value;
                OnPropertyChanged();
            }
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
        private Process activeProcess;
    }
}
