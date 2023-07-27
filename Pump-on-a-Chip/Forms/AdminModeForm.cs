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

        private void AdminModeForm_Load(object sender, EventArgs e)
        {
            resPLabel.Text = Global.resP.ToString();
            cellPLabel.Text = Global.cellP.ToString();
            atPLabel.Text = Global.atP.ToString();
            flowrateLabel.Text = Global.flowrate.ToString();
            propCurrentLabel.Text = Global.prop_valve.ToString();
            propTargetLabel.Text = Global.prop_valve_target.ToString();
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
        private void loadCellLabel_Click(object sender, EventArgs e)
        {
            serialWrite("C");
        }

        private void runPumpLabel_Click(object sender, EventArgs e)
        {
            serialWrite("P"+ Global.resP_target.ToString());
        }

        private void ventPressureReservoirLabel_Click(object sender, EventArgs e)
        {
            serialWrite("A");
        }

        private void ventCellReservoirLabel_Click(object sender, EventArgs e)
        {
            serialWrite("B");
        }

        private void remeasureAtmosphericPressureLabel_Click(object sender, EventArgs e)
        {
            serialWrite("I");
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
            serialWrite("V" + Global.prop_valve_target.ToString());
        }

    }
}
