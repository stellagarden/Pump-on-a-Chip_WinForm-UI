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
using Pump_on_a_Chip.Forms;
using System.Xml.Linq;

namespace Pump_on_a_Chip
{
    public partial class MainForm : Form
    {
        public delegate void serialDelegate(string data);
        private UserModeForm userModeForm = new UserModeForm();
        private AdminModeForm adminModeForm = new AdminModeForm();
        public SerialPort main_serial = new SerialPort();
        public SerialPort samp_serial = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.Yellow700, TextShade.WHITE);
            UserModeForm.mainForm = this;
            AdminModeForm.mainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalTimer.Start();
            userModeForm.TopLevel = false;
            userModeForm.FormBorderStyle = FormBorderStyle.None;
            this.desktopPanel.Controls.Add(userModeForm);
            this.desktopPanel.Tag = userModeForm;
            userModeForm.BringToFront();
            userModeForm.Show();
            // Arduino
            try
            {
                main_serial.PortName = "COM6";
                main_serial.BaudRate = 9600;
                main_serial.DtrEnable = true;
                main_serial.Open();
                main_serial.ReadExisting();
                main_serial.DataReceived += main_serial_DataReceived;
                main_serial.Write("I");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
            try
            {
                samp_serial.PortName = "COM3";
                samp_serial.BaudRate = 9600;
                samp_serial.DtrEnable = true;
                samp_serial.Open();
                samp_serial.ReadExisting();
                samp_serial.DataReceived += samp_serial_DataReceived;
                samp_serial.Write("I");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void globalTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToShortDateString();
            timeLabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void main_serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = main_serial.ReadLine();
            this.Invoke(new serialDelegate(mainDataProcess), data);
        }

        private void mainSerialWrite(string args)
        {
            main_serial.Write(args);
            Console.WriteLine("Send (main): " + args);
        }
        private void mainDataProcess(string data)
        {
            switch (data[0])
            {
                case 'R':
                    userModeForm.Ready();
                    Console.Write("Received (main): " + data);
                    Global.atP = Convert.ToDouble(data.Substring(1, data.Length - 1));
                    adminModeForm.atPLabel.Text = Global.atP.ToString();
                    break;
                case 'P':
                    Global.resP = Convert.ToDouble(data.Substring(1, data.Length - 1));
                    adminModeForm.resPLabel.Text = Global.resP.ToString();
                    break;
                case 'C':
                    Global.cellP = Convert.ToDouble(data.Substring(1, data.Length - 1));
                    adminModeForm.cellPLabel.Text = Global.cellP.ToString();
                    userModeForm.pCellLabel.Text = Global.cellP.ToString();
                    break;
                //case 'F':
                //    Global.flowrate = Convert.ToDouble(data.Substring(1, data.Length - 1));
                //    adminModeForm.flowrateLabel.Text = Global.flowrate.ToString();
                //    userModeForm.flowrateLabel.Text = Global.flowrate.ToString();
                //    break;
                case 'V':
                    Console.Write("Received (main): " + data);
                    Global.prop_valve = Convert.ToInt32(data.Substring(1, data.Length - 1));
                    adminModeForm.propCurrentLabel.Text = Global.prop_valve.ToString();
                    break;
                case 'S':
                    Console.Write("Received (main): " + data);
                    switch (data[1])
                    {
                        case '3':
                            userModeForm.statusLabel.Text = "RUNNING";
                            break;
                        case '4':
                            userModeForm.statusLabel.Text = "FINISH";
                            userModeForm.operatingTimer.Stop();
                            break;
                        case '0':
                            userModeForm.statusLabel.Text = "READY";
                            userModeForm.Ready();
                            break;
                    }
                    break;

            }
        }

        private void samp_serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = samp_serial.ReadLine();
            this.Invoke(new serialDelegate(sampDataProcess), data);
        }

        private void sampDataProcess(string data)
        {
            switch (data[0])
            {
                case 'D':
                    Console.Write("Received (samp): " + data);
                    userModeForm.statusLabel.Text = "PRESSURIZING";
                    mainSerialWrite("S" + Global.cellP_target.ToString());
                    break;
            }
        }
        public void changeToAdmin()
        {
            adminModeForm.TopLevel = false;
            adminModeForm.FormBorderStyle = FormBorderStyle.None;
            this.desktopPanel.Controls.Add(adminModeForm);
            this.desktopPanel.Tag = adminModeForm;
            adminModeForm.BringToFront();
            adminModeForm.Show();
            topPanel.BackColor = Color.FromArgb(45, 57, 71);
            dateLabel.BackColor = Color.FromArgb(45, 57, 71);
            timeLabel.BackColor = Color.FromArgb(45, 57, 71);
            dateLabel.ForeColor = Color.FromArgb(217, 217, 217);
            timeLabel.ForeColor = Color.FromArgb(217, 217, 217);
        }

        public void changeToUser()
        {
            userModeForm.TopLevel = false;
            userModeForm.FormBorderStyle = FormBorderStyle.None;
            this.desktopPanel.Controls.Add(userModeForm);
            this.desktopPanel.Tag = userModeForm;
            userModeForm.BringToFront();
            userModeForm.Show();
            topPanel.BackColor = Color.FromArgb(30, 0, 0, 0);
            dateLabel.BackColor = Color.FromArgb(30, 0, 0, 0);
            timeLabel.BackColor = Color.FromArgb(30, 0, 0, 0);
            dateLabel.ForeColor = Color.Black;
            timeLabel.ForeColor = Color.Black;
        }
    }
}
