using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pump_on_a_Chip.Forms
{
    public partial class AdminModeForm : Form
    {
        public static MainForm mainForm;

        public AdminModeForm()
        {
            InitializeComponent();
        }

        private void userModeButton_Click(object sender, EventArgs e)
        {
            mainForm.changeToUser();
            serialWrite("T"+ Global.resP_target.ToString());
        }

        private void serialWrite(string args)
        {
            mainForm.serial.Write(args);
            Console.WriteLine("Send: " + args);
        }

        private void pPressureSlider_onValueChanged(object sender, int newValue)
        {
            // Slider value's range: 2000 ~ 4000 mbar
            Global.resP_target = 2000 + 20 * resPTargetSlider.Value;
            resPTargetLabel.Text = Global.resP_target.ToString() + " mbar";
        }
    }
}
