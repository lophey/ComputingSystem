using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using ComputingSystem.MVC;
using Timer = System.Windows.Forms.Timer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ComputingSystem
{

    public partial class FrmDetailed : Form
    {
        private readonly ViewDetailed viewDetailed;
       // private bool AutoWork;
        public FrmDetailed()
        {
            InitializeComponent();
            var model = new Model();
            //AutoWork = false;
            viewDetailed = new ViewDetailed(model, new Controller(), this);
            viewDetailed.DataBind();
        }
        private void workingCycle_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }
        public Label LblTime => lblTime;

        private void end_Click(object sender, EventArgs e)
        {
            if (autoMode.Checked)
            {
                timer.Enabled = false;
            }
            viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            endOfSession();
            UpdateSettings();

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged()
        {
            if (PropertyChanged != null)
                PropertyChanged(this, null);
        }

        private void save_Click(object sender, EventArgs e)
        {
            SessionPreparation();
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
            if (autoMode.Checked)
            {
                timer = new Timer
                {
                    Enabled = true,
                    Interval = 700
                };
                timer.Tick += workingCycle_Click;
            }
        }

        private void SessionPreparation()
        {
            save.Enabled = false;
            end.Enabled = true;
            workingCycle.Enabled = manualMode.Checked;
            pnlSettings.Enabled = false;
            //AutoWork = true;
        }
        private void endOfSession()
        {
            end.Enabled = false;
            save.Enabled = true;
            workingCycle.Enabled = false;
            pnlSettings.Enabled = true;
            //AutoWork = false;
        }
        private void UpdateSettings()
        {
            intensity.Value = 0.5m;
            minCPU.Value = minCPU.Minimum;
            maxCPU.Value = maxCPU.Minimum;
            minSize.Value = minSize.Minimum;
            maxSize.Value = maxSize.Minimum;
            RAM.SelectedItem = RAM.Items[0];
        }

        /*private void timer_Tick(object sender, EventArgs e)
        {
            if (autoMode.Checked && AutoWork)
                viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }*/

    }
}
