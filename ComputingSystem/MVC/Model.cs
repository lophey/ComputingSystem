using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ComputingSystem.Components;
using Queues;
using Structures;

namespace ComputingSystem.MVC
{
    public class Model : INotifyPropertyChanged
    {
        public Model()
        {
            Clock = new SystemClock();
            deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new PriorityQueue<Process, BinaryHeap<Process>>(new BinaryHeap<Process>());
            ModelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler = new DeviceScheduler(device, deviceQueue);
            memoryManager = new MemoryManager();
            ram = new Memory();
            statistics = new Statistics(Clock);
        }

        public void SaveSettings()
        {
            ram.Save(ModelSettings.ValueOfRAMSize);
            memoryManager.Save(ram);
        }
        public void WorkingCycle()
        {
            Clock.WorkingCycle();
            if (processRand.NextDouble() < ModelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1));
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    subscribe(proc);
                    readyQueue = readyQueue.Put(proc);
                    statistics.IncArrivalProcCount();
                    if (cpu.IsFree())
                    {
                        readyQueue = cpuScheduler.Session();
                        statistics.IncCPUFreeTime();
                    }
                }
            }
            cpu.WorkingCycle();
            device.WorkingCycle();
        }

        public void Clear()
        {
            idGen.Clear();
            Clock.Clear();
            cpu.Clear();
            device.Clear();
            ram.Clear();
            readyQueue.Clear();
            deviceQueue.Clear();
            statistics.Clear();
        }

        private void FreeingResourceEventHandler(object sender, EventArgs e)
        {
            Process proc = sender as Process;
            switch (proc.Status)
            {
                case ProcessStatus.ready:
                    device.Clear();
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    ReadyQueue = ReadyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        //_cpuScheduler.Session();
                        ReadyQueue = cpuScheduler.Session();
                    }
                    if (DeviceQueue.Count != 0)
                    {
                        DeviceQueue = deviceScheduler.Session();
                    }
                    break;

                case ProcessStatus.terminated:
                    cpu.Clear();
                    ReadyQueue = cpuScheduler.Session();
                    if (DeviceQueue.Count != 0)
                    {
                        DeviceQueue = deviceScheduler.Session();
                    }
                    memoryManager.Free(proc);
                    unsubscribe(proc);
                    break;

                case ProcessStatus.waiting:
                    cpu.Clear();
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    statistics.IncTerminatedProcCount(); //прикол
                    DeviceQueue = DeviceQueue.Put(proc);
                    if (device.IsFree())
                    {
                        DeviceQueue = deviceScheduler.Session();
                    }
                    if (ReadyQueue.Count != 0)
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                    break;
                default:
                    break;
            }
        }
        private void subscribe(Process proc)
        {
            if (proc != null)
            {
                proc.FreeingAResource += FreeingResourceEventHandler;
            }
        }

        private void unsubscribe(Process proc)
        {
            if (proc != null)
            {
                proc.FreeingAResource -= FreeingResourceEventHandler;
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        public readonly Statistics statistics;
        public readonly SystemClock Clock;
        public readonly Resource cpu;//
        public readonly Resource device;//
        private readonly IdGenerator idGen;
        private IQueueable<Process> deviceQueue;//
        private IQueueable<Process> readyQueue;//
        private readonly CPUScheduler cpuScheduler;
        private readonly DeviceScheduler deviceScheduler;
        private readonly MemoryManager memoryManager;
        public Settings ModelSettings { get; set; }//
        private readonly Random processRand;
        public Memory ram { get; private set; }

        public IQueueable<Process> ReadyQueue
        {
            get { return readyQueue; }
            set { readyQueue = value; OnPropertyChanged(); }
        }

        public IQueueable<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set { deviceQueue = value; OnPropertyChanged(); }
        }
    }
}
