using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ComputingSystem.Components
{
    public class Memory : INotifyPropertyChanged
    {
        public void Save(long size)
        {
            Size = size;
            occupiedSize = 0;
            FreeSize = size;
        }
        public void Clear()
        {
            occupiedSize = 0;
            FreeSize = Size;
        }
        public long Size
        {
            get;
            private set;
        }
        public long OccupiedSize
        {
            get { return occupiedSize; }
            set { occupiedSize = value; OnPropertyChanged(); }
        }
        public long FreeSize
        {
            get { return Size - OccupiedSize; }
            private set { freeSize = value; OnPropertyChanged(); }
        }

        private long occupiedSize;
        private long freeSize;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
