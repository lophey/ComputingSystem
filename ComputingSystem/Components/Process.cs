using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace ComputingSystem.Components
{
    public enum ProcessStatus
    {
        ready,
        running,
        waiting,
        terminated
    }
    public class Process : IComparable<Process>
    {

        public int CompareTo(Process otherProc)
        {
            if (otherProc == null)
            {
                return 1;
            }
            return otherProc.BurstTime.CompareTo(BurstTime);
        }

        public Process(long pId, long addrSpace) //конструктор
        {
            id = pId;
            AddrSpace = addrSpace;
            name = "p" + id;
            Status = ProcessStatus.ready;
            resourceRand = new Random();
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
            }
            else
            {
                if (Status == ProcessStatus.running)
                {
                    Status = ProcessStatus.waiting;
                    if(Status == ProcessStatus.waiting)
                    {
                        device.Device = (int)resourceRand.Next(1, 4);
                        OnFreeingAResource(device);
                        return;
                    }
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnFreeingAResource(device);
            }
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }

        public override string ToString()
        {
            return "ID: " + id +
                   "; Name: " + name +
                   "; Status: " + Status +
                   "; Address Space: " + AddrSpace +
                   "; Burst Time: " + BurstTime + ";";
        }

        public event EventHandler FreeingAResource;
        private void OnFreeingAResource(EventArgs e = null)
        {
            if (FreeingAResource != null)
            {
                FreeingAResource(this, e);
            }
        }


        public long BurstTime { get; set; }

        public ProcessStatus Status { get; set; }

        public long AddrSpace { get; private set; }

        private long id;
        private string name;
        private long workTime;
        private Random resourceRand = new Random();
        DeviceEventArgs device = new DeviceEventArgs();
    }
}
