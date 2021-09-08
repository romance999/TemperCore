using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperCore.App;

namespace TemperCore.GUI
{
    public partial class FirstTime : Form
    {
        public FirstTime()
        {
            InitializeComponent();
        }

        private void FirstTime_Load(object sender, EventArgs e)
        {
            siticoneLabel1.Text = "Welcome";
            HidePnls();
            CheckFirstTime();
        }

        private void CheckFirstTime()
        {
            if (ProgramSettings.Default.firstLoad == false)
            {
                //this should not happen but incase my shit fucking breaks, send them to the program
                Hide();
                var form = new Core();
                form.Closed += (s, args) => this.Close();
                form.Show();
            }
            else if (ProgramSettings.Default.firstLoad)
            {
                ShowFirstPnl();
            }
        }

        private void HidePnls()
        {
            resizePnl.Dispose();
            pinPnl.Dispose();
        }

        public void ShowFirstPnl()
        {
            resizePnl.InitializeLifetimeService();
        }

        private void resizeOkBtn_Click(object sender, EventArgs e)
        {
            HidePnls();

        }

        private void pinOkBtn_Click(object sender, EventArgs e)
        {
            HidePnls();
            pinPnl.CreateControl();
        }

        private void pinMaybeLaterBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
