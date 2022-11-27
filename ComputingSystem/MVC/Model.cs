using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using ComputingSystem.Components;
using ComputingSystem.Properties;
using Queues;
using Structures;

namespace ComputingSystem.MVC
{
    public class Model : INotifyPropertyChanged
    {
        public Model()
        {
            Clock = new SystemClock();
            deviceQueue1 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue3 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            readyQueue = new PriorityQueue<Process, SortedArray<Process>>(new SortedArray<Process>());
            ModelSettings = new Settings();
            idGen = new IdGenerator();
            processRand = new Random();
            cpu = new Resource();
            device1 = new Resource();
            device2 = new Resource();
            device3 = new Resource();
            cpuScheduler = new CPUScheduler(cpu, readyQueue);
            deviceScheduler1 = new DeviceScheduler(device1, deviceQueue1);
            deviceScheduler2 = new DeviceScheduler(device2, deviceQueue2);
            deviceScheduler3 = new DeviceScheduler(device3, deviceQueue3);
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
                statistics.IncArrivalProcCount();
                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    subscribe(proc);
                    readyQueue = readyQueue.Put(proc);
                    if (cpu.IsFree())
                    {
                        readyQueue = cpuScheduler.Session();
                        statistics.IncCPUFreeTime();
                    }
                }
            }
            cpu.WorkingCycle();
            device1.WorkingCycle();
            device2.WorkingCycle();
            device3.WorkingCycle();
        }

        public void Clear()
        {
            idGen.Clear();
            Clock.Clear();
            cpu.Clear();
            device1.Clear();
            device2.Clear();
            device3.Clear();
            ram.Clear();
            readyQueue.Clear();
            DeviceQueue1 = deviceQueue1.Clear();
            DeviceQueue2 = deviceQueue2.Clear();
            DeviceQueue3 = deviceQueue3.Clear();
            statistics.Clear();
        }

        private void FreeingResourceEventHandler(object sender, EventArgs e)
        {
            Process proc = sender as Process;
            DeviceEventArgs device = e as DeviceEventArgs;
            switch (proc.Status)
            {
                case ProcessStatus.ready:
                    device1.Clear();
                    device2.Clear();
                    device3.Clear();
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    ReadyQueue = ReadyQueue.Put(proc);
                    switch (device.Device)
                    {
                        case 1:
                            device1.Clear();
                            if (deviceQueue1.Count != 0)
                                DeviceQueue1 = deviceScheduler1.Session();
                            break;
                        case 2:
                            device2.Clear();
                            if (deviceQueue2.Count != 0)
                                DeviceQueue2 = deviceScheduler2.Session();
                            break;
                        case 3:
                            device3.Clear();
                            if (deviceQueue3.Count != 0)
                                DeviceQueue3 = deviceScheduler3.Session();
                            break;
                        default:
                            break;
                    }
                    if (cpu.IsFree())
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                    break;

                case ProcessStatus.terminated:
                    unsubscribe(proc);
                    cpu.Clear();
                    memoryManager.Free(proc);
                    if (ReadyQueue.Count != 0)
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                    
                    break;

                case ProcessStatus.waiting:
                    cpu.Clear();
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime,
                        ModelSettings.MaxValueOfBurstTime + 1);
                    proc.ResetWorkTime();
                    if (ReadyQueue.Count != 0)
                    {
                        ReadyQueue = cpuScheduler.Session();
                    }
                    statistics.IncTerminatedProcCount();
                    switch (device.Device)
                    {
                        case 1:
                            DeviceQueue1 = DeviceQueue1.Put(proc);
                            if (device1.IsFree())
                            {
                                DeviceQueue1 = deviceScheduler1.Session();
                            }
                            break;
                        case 2:
                            DeviceQueue2 = DeviceQueue2.Put(proc);
                            if (device2.IsFree())
                            {
                                DeviceQueue2 = deviceScheduler2.Session();
                            }
                            break;
                        case 3:
                            DeviceQueue3 = DeviceQueue3.Put(proc);
                            if (device3.IsFree())
                            {
                                DeviceQueue3 = deviceScheduler3.Session();
                            }
                            break;
                        default:
                            break;
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
        public readonly Resource cpu;
        public readonly Resource device1;
        public readonly Resource device2;
        public readonly Resource device3;
        private readonly IdGenerator idGen;
        private IQueueable<Process> deviceQueue1;
        private IQueueable<Process> deviceQueue2;
        private IQueueable<Process> deviceQueue3;
        private IQueueable<Process> readyQueue;
        private readonly CPUScheduler cpuScheduler;
        private readonly DeviceScheduler deviceScheduler1;
        private readonly DeviceScheduler deviceScheduler2;
        private readonly DeviceScheduler deviceScheduler3;
        private readonly MemoryManager memoryManager;
        public Settings ModelSettings { get; set; }
        private readonly Random processRand;
        public Memory ram { get; private set; }
        public IQueueable<Process> ReadyQueue
        {
            get { return readyQueue; }
            set { readyQueue = value; OnPropertyChanged(); }
        }

        public IQueueable<Process> DeviceQueue1
        {
            get { return deviceQueue1; }
            set { deviceQueue1 = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> DeviceQueue2
        {
            get { return deviceQueue2; }
            set { deviceQueue2 = value; OnPropertyChanged(); }
        }
        public IQueueable<Process> DeviceQueue3
        {
            get { return deviceQueue3; }
            set { deviceQueue3 = value; OnPropertyChanged(); }
        }
    }
}
