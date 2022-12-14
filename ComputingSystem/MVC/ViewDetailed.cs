using ComputingSystem.Components;
using Queues;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ComputingSystem.MVC
{
    internal class ViewDetailed : View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) : base(model, controller) { this.frm = frm; }

        public override void DataBind()
        {
            frm.CPUText.DataBindings.Add(new Binding("Text", model.cpu, "ActiveProcess"));
            frm.DeviceText.DataBindings.Add(new Binding("Text", model.device1, "ActiveProcess"));
            frm.DeviceText2.DataBindings.Add(new Binding("Text", model.device2, "ActiveProcess"));
            frm.DeviceText3.DataBindings.Add(new Binding("Text", model.device3, "ActiveProcess"));

            frm.occupiedSize.DataBindings.Add(new Binding("Text", model.ram, "OccupiedSize"));
            frm.freeSize.DataBindings.Add(new Binding("Text", model.ram, "FreeSize"));
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

            Binding intensityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.intensity.DataBindings.Add(intensityBinding);

            Binding minCPU = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime");
            minCPU.ControlUpdateMode = ControlUpdateMode.Never;
            frm.minCPU.DataBindings.Add(minCPU);

            Binding maxCPU = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime");
            maxCPU.ControlUpdateMode = ControlUpdateMode.Never;
            frm.maxCPU.DataBindings.Add(maxCPU);

            Binding minSize = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace");
            minSize.ControlUpdateMode = ControlUpdateMode.Never;
            frm.minSize.DataBindings.Add(minSize);

            Binding maxSize = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace");
            maxSize.ControlUpdateMode = ControlUpdateMode.Never;
            frm.maxSize.DataBindings.Add(maxSize);

            Binding RAM = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize", true);
            RAM.ControlUpdateMode = ControlUpdateMode.Never;
            frm.RAM.DataBindings.Add(RAM);

            frm.CPUUtilization.DataBindings.Add(new Binding("Text", model.statistics, "CpuUtilization", true, DataSourceUpdateMode.Never, null, "#0.##%"));

            frm.lblThroughput.DataBindings.Add(new Binding("Text", model.statistics, "Throughput", true, DataSourceUpdateMode.Never, null, "#0.##%"));

            Subscribe();
        }
        public override void DataUnbind()
        {
            frm.CPUText.DataBindings.RemoveAt(0);
            frm.DeviceText.DataBindings.RemoveAt(0);
            frm.DeviceText2.DataBindings.RemoveAt(0);
            frm.DeviceText3.DataBindings.RemoveAt(0);
            frm.occupiedSize.DataBindings.RemoveAt(0);
            frm.freeSize.DataBindings.RemoveAt(0);
            frm.LblTime.DataBindings.RemoveAt(0);
            frm.CPUUtilization.DataBindings.RemoveAt(0);
            frm.lblThroughput.DataBindings.RemoveAt(0);
            frm.intensity.DataBindings.RemoveAt(0);
            frm.minCPU.DataBindings.RemoveAt(0);
            frm.maxCPU.DataBindings.RemoveAt(0);
            frm.minSize.DataBindings.RemoveAt(0);
            frm.maxSize.DataBindings.RemoveAt(0);
            frm.queueToCPU.DataBindings.RemoveAt(0);
            frm.queueToDevice.DataBindings.RemoveAt(0);
            frm.queueToDevice2.DataBindings.RemoveAt(0);
            frm.queueToDevice3.DataBindings.RemoveAt(0);
            frm.RAM.DataBindings.Clear();

            Unsubscribe();
        }

        private FrmDetailed frm;

        // подписчик
        private void Subscribe()
        {
            model.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
            frm.PropertyChanged += new PropertyChangedEventHandler(PropertyChangedHandler);
        }
        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
            frm.PropertyChanged -= PropertyChangedHandler;
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                updateListBox(model.ReadyQueue, frm.queueToCPU);
            }
            else if (e.PropertyName == "DeviceQueue")
            {
                updateListBox(model.DeviceQueue1, frm.queueToDevice);
                updateListBox(model.DeviceQueue2, frm.queueToDevice2);
                updateListBox(model.DeviceQueue3, frm.queueToDevice3);
            }
        }

        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }

    }
}
