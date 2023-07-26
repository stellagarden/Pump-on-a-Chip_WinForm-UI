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
using System.IO.Ports;

namespace Pump_on_a_Chip
{
    public partial class MainForm : Form
    {
        private DateTime operation_start;
        public delegate void serialDelegate(string data);

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.LightBlue100, TextShade.WHITE);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalTimer.Start();
            // State - Initializing
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
            // Arduino
            try
            {
                serialPort1.PortName = "COM3";
                serialPort1.BaudRate = 9600;
                serialPort1.DtrEnable = true;
                serialPort1.Open();
                serialPort1.ReadExisting();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
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
            serialPort1.Write("S");

            // Disable input when it starts
            startButton.Enabled = false;
            startButton.BackColor = Color.FromArgb(213, 213, 213);
            startButton.ForeColor = Color.FromArgb(166, 166, 166);
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

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();
            this.Invoke(new serialDelegate(dataProcess), data);
        }

        private void dataProcess(string data)
        {
            pCellLabel.Text = data;
        }
    }
}
