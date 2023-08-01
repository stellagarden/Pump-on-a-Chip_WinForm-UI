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
        bool flag_pump2 = false;
        bool flag_pinch1 = false;
        bool flag_pinch2 = false;
        bool flag_sol4 = false;

        public AdminModeForm()
        {
            InitializeComponent();
        }

        private void AdminModeForm_Load(object sender, EventArgs e)
        {
            propTargetLabel.Text = Global.prop_valve_target.ToString();
            resPTargetLabel.Text = Global.resP_target.ToString() + " mbar";
            flowrateLabel.Text = "-";
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
            sampSerialWrite("U");
            flag_sol4 = false;
            sol4Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            flag_pump2 = false;
            pump2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            flag_pinch1 = false;
            pinch1Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            flag_pinch2 = false;
            pinch2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            cellWasteRadio.Checked = true;
            mainForm.changeToUser();
        }

        private void resPTargetTrackBar_Scroll(object sender, EventArgs e)
        {
            Global.resP_target = resPTargetTrackBar.Value;
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

        private void sol4Tog_Click(object sender, EventArgs e)
        {
            if (flag_sol4)
            {
                flag_sol4 = false;
                mainSerialWrite("OX");
                sol4Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            }
            else
            {
                flag_sol4 = true;
                mainSerialWrite("OO");
                sol4Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_on;
            }
        }

        private void pump2Tog_Click(object sender, EventArgs e)
        {
            if (flag_pump2)
            {
                flag_pump2 = false;
                sampSerialWrite("PX");
                pump2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            }
            else
            {
                flag_pump2 = true;
                sampSerialWrite("PO");
                pump2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_on;
            }
        }

        private void pinch1Tog_Click(object sender, EventArgs e)
        {
            if (flag_pinch1)
            {
                flag_pinch1 = false;
                sampSerialWrite("1X");
                pinch1Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            }
            else
            {
                flag_pinch1 = true;
                sampSerialWrite("1O");
                pinch1Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_on;
            }
        }

        private void pinch2Tog_Click(object sender, EventArgs e)
        {
            if (flag_pinch2)
            {
                flag_pinch2 = false;
                sampSerialWrite("2X");
                pinch2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_off;
            }
            else
            {
                flag_pinch2 = true;
                sampSerialWrite("2O");
                pinch2Tog.Image = Pump_on_a_Chip.Properties.Resources.tog_on;
            }
        }

        private void cellWasteRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (cellWasteRadio.Checked)
            {
                sampSerialWrite("3X");
            }
            else
            {
                sampSerialWrite("3O");
            }
        }
    }
}
