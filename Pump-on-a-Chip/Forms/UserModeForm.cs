using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Pump_on_a_Chip.Forms
{
    public partial class UserModeForm : Form
    {
        private DateTime operation_start;
        public static MainForm mainForm;

        public UserModeForm()
        {
            InitializeComponent();
        }

        private void UserModeForm_Load(object sender, EventArgs e)
        {
            // State - Initializing
            statusLabel.Text = "INITIALIZING";
            statusLabel.BackColor = Color.FromArgb(0, 48, 73);
            roundControl1.BackgroundColor = Color.FromArgb(0, 48, 73);
            operatingTimeTextLabel.ForeColor = Color.FromArgb(0, 48, 73);
            operatingTimeLabel.ForeColor = Color.FromArgb(0, 48, 73);
            operatingTimeLabel.Text = "--:--:--";
            pCellLabel.Text = "-";
            flowrateLabel.Text = "-";
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(213, 213, 213);
            startButton.ForeColor = Color.FromArgb(166, 166, 166);
            pCellTargetTextLabel.ForeColor = Color.FromArgb(166, 166, 166);
            Global.cellP_target = pCellTrackBar.Value;
            pCellTargetLabel.Text = Global.cellP_target.ToString() + " mbar";
            pCellTargetLabel.ForeColor = Color.FromArgb(166, 166, 166);
            pCellTrackBar.Enabled = false;
            adminModeButton.Enabled = false;
        }

        public void Ready()
        {
            statusLabel.Text = "READY";
            statusLabel.BackColor = Color.FromArgb(0, 48, 73);
            roundControl1.BackgroundColor = Color.FromArgb(0, 48, 73);
            operatingTimeTextLabel.ForeColor = Color.FromArgb(0, 48, 73);
            operatingTimeLabel.ForeColor = Color.FromArgb(0, 48, 73);
            startButton.Enabled = true;
            startButton.BackColor = Color.FromArgb(252, 191, 73);
            startButton.ForeColor = Color.FromArgb(126, 85, 2);
            pCellTargetTextLabel.ForeColor = Color.FromArgb(126, 85, 2);
            pCellTargetLabel.ForeColor = Color.FromArgb(126, 85, 2);
            pCellTrackBar.Enabled = true;
            adminModeButton.Enabled = true;
        }

        private void pCellTrackBar_Scroll(object sender, EventArgs e)
        {
            Global.cellP_target = pCellTrackBar.Value;
            pCellTargetLabel.Text = Global.cellP_target.ToString() + " mbar";
        }
        private void sampSerialWrite(string args)
        {
            mainForm.samp_serial.Write(args);
            Console.WriteLine("Send (samp): " + args);
        }

        private void mainSerialWrite(string args)
        {
            mainForm.main_serial.Write(args);
            Console.WriteLine("Send (main): " + args);
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            operation_start = DateTime.Now;
            operatingTimer.Start();
            statusLabel.Text = "CELL LOADING";
            mainSerialWrite("T" + Global.resP_target.ToString());
            sampSerialWrite("S");

            // Disable input and change colors when it starts
            statusLabel.BackColor = Color.FromArgb(214, 40, 40);
            roundControl1.BackgroundColor = Color.FromArgb(214, 40, 40);
            operatingTimeTextLabel.ForeColor = Color.FromArgb(214, 40, 40);
            operatingTimeLabel.ForeColor = Color.FromArgb(214, 40, 40);
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(213, 213, 213);
            startButton.ForeColor = Color.FromArgb(166, 166, 166);
            pCellTargetTextLabel.ForeColor = Color.FromArgb(0, 48, 73);
            pCellTargetLabel.ForeColor = Color.FromArgb(0, 48, 73);
            pCellTrackBar.Enabled = false;
            adminModeButton.Enabled = false;
        }

        private void operatingTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - operation_start;
            operatingTimeLabel.Text = string.Format("{0:hh\\:mm\\:ss}", duration);
        }

        private void adminModeButton_Click(object sender, EventArgs e)
        {
            mainForm.changeToAdmin();
        }

    }
}
