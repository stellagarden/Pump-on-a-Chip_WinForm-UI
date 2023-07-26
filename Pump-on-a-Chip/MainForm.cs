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
        private DateTime operation_start;
        public delegate void serialDelegate(string data);
        private Form activeForm;
        private UserModeForm userModeForm = new UserModeForm();
        private AdminModeForm adminModeForm = new AdminModeForm();
        public SerialPort serial = new SerialPort();

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Yellow800, Primary.Yellow900, Primary.Yellow500, Accent.LightBlue100, TextShade.WHITE);
            UserModeForm.mainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            globalTimer.Start();
            OpenChildForm(userModeForm);
            // Arduino
            try
            {
                serial.PortName = "COM6";
                serial.BaudRate = 9600;
                serial.DtrEnable = true;
                serial.Open();
                serial.ReadExisting();
                serial.DataReceived += serial_DataReceived;
                serial.Write("I");
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

        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serial.ReadLine();
            this.Invoke(new serialDelegate(dataProcess), data);
        }

        private void dataProcess(string data)
        {
            Console.Write("Received: "+data);
            switch (data[0])
            {
                case 'R':
                    userModeForm.Ready();
                    Global.Pat = data.Substring(1,data.Length-1);
                    //userModeForm.pCellLabel.Text = Global.Pat;
                    break;
                case 'S':
                    switch (data[1])
                    {
                        case '2':
                            userModeForm.statusLabel.Text = "PRESSURIZING";
                            break;
                        case '3':
                            userModeForm.statusLabel.Text = "RUNNING";
                            break;
                        case '4':
                            userModeForm.statusLabel.Text = "FINISH";
                            break;
                        case '0':
                            userModeForm.statusLabel.Text = "READY";
                            userModeForm.Ready();
                            break;
                    }
                    break;

            }
        }

        public void changeToAdmin()
        {
            OpenChildForm(adminModeForm);
        }
    }
}
