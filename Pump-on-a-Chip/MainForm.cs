using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Pump_on_a_Chip
{
    public partial class MainForm : Form
    {
        private DateTime operation_start;

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.LightBlue100, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalTimer.Start();
            statusLabel.Text = "INITIALIZING";
            operatingTimeLabel.Text = "--:--:--";
            pCellLabel.Text = "-";
            flowrateLabel.Text = "-";
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(213, 213, 213);
            startButton.ForeColor = Color.FromArgb(166, 166, 166);
            pCellTargetTextLabel.ForeColor = Color.FromArgb(166, 166, 166);
            pCellTargetLabel.Text = (200 + 2 * pCellSlider.Value).ToString() + " mbar";
            pCellTargetLabel.ForeColor = Color.FromArgb(166, 166, 166);
            pCellSlider.Enabled = false;
            adminModeButton.Enabled = false;
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void pCellSlider_onValueChanged(object sender, int newValue)
        {
            // Slider value's range: 200 ~ 400 mbar
            pCellTargetLabel.Text = (200 + 2 * pCellSlider.Value).ToString() + " mbar";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            operation_start = DateTime.Now;
            operatingTimer.Start();

            // Disable input when it starts
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(213,213,213);
            startButton.ForeColor = Color.FromArgb(166,166,166);
            pCellTargetTextLabel.ForeColor = Color.FromArgb(0, 48, 73);
            pCellTargetLabel.ForeColor = Color.FromArgb(0, 48, 73);
            pCellSlider.Enabled = false;
            adminModeButton.Enabled = false;
        }

        private void operatingTimer_Tick_1(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - operation_start;
            operatingTimeLabel.Text = string.Format("{0:hh\\:mm\\:ss}", duration);
        }
    }
}
