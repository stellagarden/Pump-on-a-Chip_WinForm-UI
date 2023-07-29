using MaterialSkin;
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
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void AdminModeForm_Load(object sender, EventArgs e)
        {
            propTargetLabel.Text = Global.prop_valve_target.ToString();
            resPTargetLabel.Text = Global.resP_target.ToString() + " mbar";
        }

        private void mainSerialWrite(string args)
        {
            mainForm.main_serial.Write(args);
            Console.WriteLine("Send (main): " + args);
        }
        private void sampSerialWrite(string args)
        {
            mainForm.samp_serial.Write(args);
            Console.WriteLine("Send (samp): " + args);
        }
        private void userModeButton_Click(object sender, EventArgs e)
        {
            mainSerialWrite("T"+ Global.resP_target.ToString());
            mainForm.changeToUser();
        }

        private void pPressureSlider_onValueChanged(object sender, int newValue)
        {
            // Slider value's range: 1000 ~ 3000 mbar
            Global.resP_target = 1000 + 20 * resPTargetSlider.Value;
            resPTargetLabel.Text = Global.resP_target.ToString() + " mbar";
        }
        private void runPumpLabel_Click(object sender, EventArgs e)
        {
            mainSerialWrite("P"+ Global.resP_target.ToString());
        }

        private void ventPressureReservoirLabel_Click(object sender, EventArgs e)
        {
            mainSerialWrite("A");
        }

        private void ventCellReservoirLabel_Click(object sender, EventArgs e)
        {
            mainSerialWrite("B");
        }

        private void remeasureAtmosphericPressureLabel_Click(object sender, EventArgs e)
        {
            mainSerialWrite("I");
        }

        private void propIncLabel_Click(object sender, EventArgs e)
        {
            Global.prop_valve_target = Global.prop_valve_target + 1;
            propTargetLabel.Text = Global.prop_valve_target.ToString();
        }

        private void propDecLabel_Click(object sender, EventArgs e)
        {
            Global.prop_valve_target = Global.prop_valve_target - 1;
            propTargetLabel.Text = Global.prop_valve_target.ToString();
        }

        private void propValveSetLabel_Click(object sender, EventArgs e)
        {
            mainSerialWrite("V" + Global.prop_valve_target.ToString());
        }

        private void pinch1Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (pinch1Switch.Checked)
            {
                sampSerialWrite("1O");
            }
            else
            {
                sampSerialWrite("1X");
            }
        }

        private void pinch2Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (pinch2Switch.Checked)
            {
                sampSerialWrite("2O");
            }
            else
            {
                sampSerialWrite("2X");
            }
        }
        private void pinch3CellRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (pinch3CellRadio.Checked)
            {
                sampSerialWrite("3O");
            }
            else
            {
                sampSerialWrite("3X");
            }
        }

        private void pump2Switch_CheckedChanged(object sender, EventArgs e)
        {
            if (pump2Switch.Checked)
            {
                sampSerialWrite("PO");
            }
            else
            {
                sampSerialWrite("PX");
            }
        }


    }
}
