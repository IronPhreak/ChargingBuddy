using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChargingBuddy
{
    public partial class Form1 : Form
    {
        static bool isArmmed;
        static NotifyIcon notify = new NotifyIcon();


        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            var scale = sender as TrackBar;
            lbl_Perc.Text = scale.Value.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Perc.Text = trackBar1.Value.ToString() + "%";
        }

        private static void Armmed(int shutdown)
        {
            isArmmed = true;
            PowerStatus ps = SystemInformation.PowerStatus;
            while (isArmmed == true)
            {
                notify.BalloonTipText = "Charging Buddy Armmed: " + shutdown.ToString() + "%";
                if((ps.BatteryLifePercent * 100) == shutdown)
                {
                    isArmmed = false;
                    Process.Start("shutdown", "/f /t 60");
                    DialogResult result = MessageBox.Show("Device fully charged and will shutdown within 1 minute\nDo you want to abort?", "Charge complete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        Process.Start("shutdown", "/a");
                        MessageBox.Show("Shutdown aborted", "Aborted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btn_Arm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to set this device to shutdown\nat " + lbl_Perc.Text + "?","Ready to arm",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                Armmed(Convert.ToInt32(lbl_Perc.Text.Replace("%", "")));
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notify.Text = "ChargingBuddy";
                notify.Visible = true;
            }
        }
    }
}