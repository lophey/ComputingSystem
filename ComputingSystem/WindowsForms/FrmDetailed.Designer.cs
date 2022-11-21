
namespace ComputingSystem
{
    partial class FrmDetailed
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CPUText = new System.Windows.Forms.TextBox();
            this.DeviceText = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.workingCycle = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.statistics = new System.Windows.Forms.Button();
            this.manualMode = new System.Windows.Forms.RadioButton();
            this.autoMode = new System.Windows.Forms.RadioButton();
            this.freeSize = new System.Windows.Forms.TextBox();
            this.occupiedSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intensity = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minCPU = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maxCPU = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.RAM = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.minSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.maxSize = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.queueToCPU = new System.Windows.Forms.ListBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.queueToDevice = new System.Windows.Forms.ListBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minCPU)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCPU)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxSize)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.pnlSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // CPUText
            // 
            this.CPUText.Location = new System.Drawing.Point(4, 22);
            this.CPUText.Name = "CPUText";
            this.CPUText.ReadOnly = true;
            this.CPUText.Size = new System.Drawing.Size(378, 23);
            this.CPUText.TabIndex = 2;
            // 
            // DeviceText
            // 
            this.DeviceText.Location = new System.Drawing.Point(4, 22);
            this.DeviceText.Name = "DeviceText";
            this.DeviceText.ReadOnly = true;
            this.DeviceText.Size = new System.Drawing.Size(378, 23);
            this.DeviceText.TabIndex = 3;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(333, 13);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(109, 43);
            this.save.TabIndex = 11;
            this.save.Text = "Сохранение настроек";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // workingCycle
            // 
            this.workingCycle.Location = new System.Drawing.Point(444, 13);
            this.workingCycle.Name = "workingCycle";
            this.workingCycle.Size = new System.Drawing.Size(109, 43);
            this.workingCycle.TabIndex = 12;
            this.workingCycle.Text = "Рабочий такт";
            this.workingCycle.UseVisualStyleBackColor = true;
            this.workingCycle.Click += new System.EventHandler(this.workingCycle_Click);
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(555, 13);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(109, 43);
            this.end.TabIndex = 13;
            this.end.Text = "Завершение сеанса";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // statistics
            // 
            this.statistics.Location = new System.Drawing.Point(666, 13);
            this.statistics.Name = "statistics";
            this.statistics.Size = new System.Drawing.Size(109, 43);
            this.statistics.TabIndex = 14;
            this.statistics.Text = "Статистика";
            this.statistics.UseVisualStyleBackColor = true;
            // 
            // manualMode
            // 
            this.manualMode.AutoSize = true;
            this.manualMode.Checked = true;
            this.manualMode.Location = new System.Drawing.Point(668, 106);
            this.manualMode.Name = "manualMode";
            this.manualMode.Size = new System.Drawing.Size(66, 19);
            this.manualMode.TabIndex = 15;
            this.manualMode.TabStop = true;
            this.manualMode.Text = "Ручной";
            this.manualMode.UseVisualStyleBackColor = true;
            // 
            // autoMode
            // 
            this.autoMode.AutoSize = true;
            this.autoMode.Location = new System.Drawing.Point(668, 126);
            this.autoMode.Name = "autoMode";
            this.autoMode.Size = new System.Drawing.Size(117, 19);
            this.autoMode.TabIndex = 16;
            this.autoMode.Text = "Автоматический";
            this.autoMode.UseVisualStyleBackColor = true;
            // 
            // freeSize
            // 
            this.freeSize.Location = new System.Drawing.Point(178, 17);
            this.freeSize.Name = "freeSize";
            this.freeSize.ReadOnly = true;
            this.freeSize.Size = new System.Drawing.Size(206, 23);
            this.freeSize.TabIndex = 18;
            // 
            // occupiedSize
            // 
            this.occupiedSize.Location = new System.Drawing.Point(618, 17);
            this.occupiedSize.Name = "occupiedSize";
            this.occupiedSize.ReadOnly = true;
            this.occupiedSize.Size = new System.Drawing.Size(153, 23);
            this.occupiedSize.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 59);
            this.label1.TabIndex = 20;
            this.label1.Text = "Интенсивность поступления процессов";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 62);
            this.label2.TabIndex = 21;
            this.label2.Text = "Минимальное значение промежутка работы на ЦП";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 63);
            this.label3.TabIndex = 22;
            this.label3.Text = "Максимальное значение промежутка работы на ЦП";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 46);
            this.label4.TabIndex = 23;
            this.label4.Text = "Размер оперативной памяти";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 55);
            this.label5.TabIndex = 24;
            this.label5.Text = "Минимальный размер адресного пространства процесса ";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 62);
            this.label6.TabIndex = 25;
            this.label6.Text = "Максимальный размер адресного пространства процесса ";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Центральный процессор";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Внешнее устройство";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Очередь к центральному процессору";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(259, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Очередь к внешнему устройству";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "Оперативная память";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(7, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Размер свободной памяти:";
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(394, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Размер памяти, занятой процессами:";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(572, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Режим работы:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.intensity);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 102);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // intensity
            // 
            this.intensity.DecimalPlaces = 1;
            this.intensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.intensity.Location = new System.Drawing.Point(4, 74);
            this.intensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.intensity.Name = "intensity";
            this.intensity.Size = new System.Drawing.Size(120, 23);
            this.intensity.TabIndex = 21;
            this.intensity.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.minCPU);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(133, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 102);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // minCPU
            // 
            this.minCPU.Location = new System.Drawing.Point(4, 74);
            this.minCPU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minCPU.Name = "minCPU";
            this.minCPU.Size = new System.Drawing.Size(120, 23);
            this.minCPU.TabIndex = 22;
            this.minCPU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.maxCPU);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(263, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(128, 102);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // maxCPU
            // 
            this.maxCPU.Location = new System.Drawing.Point(4, 74);
            this.maxCPU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxCPU.Name = "maxCPU";
            this.maxCPU.Size = new System.Drawing.Size(120, 23);
            this.maxCPU.TabIndex = 23;
            this.maxCPU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.RAM);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(393, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(128, 102);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            // 
            // RAM
            // 
            this.RAM.FormattingEnabled = true;
            this.RAM.Items.AddRange(new object[] {
            "1000",
            "2000",
            "4000",
            "8000",
            "16000",
            "32000"});
            this.RAM.Location = new System.Drawing.Point(4, 74);
            this.RAM.Name = "RAM";
            this.RAM.Size = new System.Drawing.Size(121, 23);
            this.RAM.TabIndex = 24;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.minSize);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Location = new System.Drawing.Point(523, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(128, 102);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            // 
            // minSize
            // 
            this.minSize.Location = new System.Drawing.Point(4, 74);
            this.minSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.minSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minSize.Name = "minSize";
            this.minSize.Size = new System.Drawing.Size(120, 23);
            this.minSize.TabIndex = 25;
            this.minSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.maxSize);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(653, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(128, 102);
            this.groupBox6.TabIndex = 39;
            this.groupBox6.TabStop = false;
            // 
            // maxSize
            // 
            this.maxSize.Location = new System.Drawing.Point(4, 74);
            this.maxSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxSize.Name = "maxSize";
            this.maxSize.Size = new System.Drawing.Size(120, 23);
            this.maxSize.TabIndex = 26;
            this.maxSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.occupiedSize);
            this.groupBox7.Controls.Add(this.freeSize);
            this.groupBox7.Location = new System.Drawing.Point(10, 395);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(779, 49);
            this.groupBox7.TabIndex = 40;
            this.groupBox7.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblTime);
            this.groupBox8.Controls.Add(this.statistics);
            this.groupBox8.Controls.Add(this.end);
            this.groupBox8.Controls.Add(this.workingCycle);
            this.groupBox8.Controls.Add(this.save);
            this.groupBox8.Location = new System.Drawing.Point(10, 444);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(779, 65);
            this.groupBox8.TabIndex = 41;
            this.groupBox8.TabStop = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(25, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "0";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Controls.Add(this.DeviceText);
            this.groupBox9.Location = new System.Drawing.Point(404, 145);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(385, 50);
            this.groupBox9.TabIndex = 42;
            this.groupBox9.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.groupBox13);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.CPUText);
            this.groupBox10.Location = new System.Drawing.Point(11, 145);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(385, 50);
            this.groupBox10.TabIndex = 43;
            this.groupBox10.TabStop = false;
            // 
            // groupBox13
            // 
            this.groupBox13.Location = new System.Drawing.Point(384, 45);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(400, 210);
            this.groupBox13.TabIndex = 28;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "groupBox13";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.queueToCPU);
            this.groupBox11.Controls.Add(this.label9);
            this.groupBox11.Location = new System.Drawing.Point(11, 199);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(385, 193);
            this.groupBox11.TabIndex = 44;
            this.groupBox11.TabStop = false;
            // 
            // queueToCPU
            // 
            this.queueToCPU.FormattingEnabled = true;
            this.queueToCPU.ItemHeight = 15;
            this.queueToCPU.Location = new System.Drawing.Point(8, 25);
            this.queueToCPU.Name = "queueToCPU";
            this.queueToCPU.Size = new System.Drawing.Size(372, 154);
            this.queueToCPU.TabIndex = 29;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.queueToDevice);
            this.groupBox12.Controls.Add(this.label10);
            this.groupBox12.Location = new System.Drawing.Point(404, 199);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(385, 193);
            this.groupBox12.TabIndex = 45;
            this.groupBox12.TabStop = false;
            // 
            // queueToDevice
            // 
            this.queueToDevice.FormattingEnabled = true;
            this.queueToDevice.ItemHeight = 15;
            this.queueToDevice.Location = new System.Drawing.Point(8, 25);
            this.queueToDevice.Name = "queueToDevice";
            this.queueToDevice.Size = new System.Drawing.Size(370, 154);
            this.queueToDevice.TabIndex = 30;
            // 
            // pnlSettings
            // 
            this.pnlSettings.Controls.Add(this.groupBox6);
            this.pnlSettings.Controls.Add(this.autoMode);
            this.pnlSettings.Controls.Add(this.label14);
            this.pnlSettings.Controls.Add(this.manualMode);
            this.pnlSettings.Controls.Add(this.groupBox1);
            this.pnlSettings.Controls.Add(this.groupBox5);
            this.pnlSettings.Controls.Add(this.groupBox4);
            this.pnlSettings.Controls.Add(this.groupBox2);
            this.pnlSettings.Controls.Add(this.groupBox3);
            this.pnlSettings.Location = new System.Drawing.Point(8, 2);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(785, 145);
            this.pnlSettings.TabIndex = 25;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 700;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 518);
            this.Controls.Add(this.pnlSettings);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Name = "FrmDetailed";
            this.Text = "Системное программное обеспечение: курсовая работа";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intensity)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minCPU)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxCPU)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minSize)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxSize)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox CPUText;
        public System.Windows.Forms.TextBox DeviceText;
        public System.Windows.Forms.Button save;
        public System.Windows.Forms.Button workingCycle;
        public System.Windows.Forms.Button end;
        public System.Windows.Forms.Button statistics;
        public System.Windows.Forms.RadioButton autoMode;
        public System.Windows.Forms.TextBox freeSize;
        public System.Windows.Forms.TextBox occupiedSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        public System.Windows.Forms.ListBox queueToDevice;
        public System.Windows.Forms.ListBox queueToCPU;
        public System.Windows.Forms.ComboBox RAM;
        public System.Windows.Forms.NumericUpDown intensity;
        public System.Windows.Forms.NumericUpDown minCPU;
        public System.Windows.Forms.NumericUpDown maxCPU;
        public System.Windows.Forms.NumericUpDown minSize;
        public System.Windows.Forms.NumericUpDown maxSize;
        public System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.RadioButton manualMode;
        private System.Windows.Forms.Timer timer;
    }
}

