namespace Pump_on_a_Chip.Forms
{
    partial class AdminModeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.resPTextLabel = new System.Windows.Forms.Label();
            this.cellPTextLabel = new System.Windows.Forms.Label();
            this.atPTextLabel = new System.Windows.Forms.Label();
            this.flowrateTextLabel = new System.Windows.Forms.Label();
            this.resPLabel = new System.Windows.Forms.Label();
            this.cellPLabel = new System.Windows.Forms.Label();
            this.atPLabel = new System.Windows.Forms.Label();
            this.flowrateLabel = new System.Windows.Forms.Label();
            this.userModeButton = new System.Windows.Forms.Button();
            this.resPTargetSlider = new MaterialSkin.Controls.MaterialSlider();
            this.resPTargetLabel = new System.Windows.Forms.Label();
            this.resPTargetTextLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.propValveTextLabel = new System.Windows.Forms.Label();
            this.ventPressureReservoirLabel = new System.Windows.Forms.Label();
            this.ventCellReservoirLabel = new System.Windows.Forms.Label();
            this.runPumpLabel = new System.Windows.Forms.Label();
            this.remeasureAtmosphericPressureLabel = new System.Windows.Forms.Label();
            this.propCurrentTextLabel = new System.Windows.Forms.Label();
            this.propTargetTextLabel = new System.Windows.Forms.Label();
            this.propCurrentLabel = new System.Windows.Forms.Label();
            this.propTargetLabel = new System.Windows.Forms.Label();
            this.propValveSetLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.propDecLabel = new System.Windows.Forms.Label();
            this.propIncLabel = new System.Windows.Forms.Label();
            this.pinch1Switch = new MaterialSkin.Controls.MaterialSwitch();
            this.pinch2Switch = new MaterialSkin.Controls.MaterialSwitch();
            this.pump2Switch = new MaterialSkin.Controls.MaterialSwitch();
            this.roundControl8 = new Pump_on_a_Chip.RoundControl();
            this.propValveSetButton = new Pump_on_a_Chip.RoundControl();
            this.runPumpButton = new Pump_on_a_Chip.RoundControl();
            this.remeasureAtmosphericPressureButton = new Pump_on_a_Chip.RoundControl();
            this.ventCellReservoirButton = new Pump_on_a_Chip.RoundControl();
            this.ventPressureReservoirButton = new Pump_on_a_Chip.RoundControl();
            this.roundControl6 = new Pump_on_a_Chip.RoundControl();
            this.roundControl5 = new Pump_on_a_Chip.RoundControl();
            this.roundControl2 = new Pump_on_a_Chip.RoundControl();
            this.roundControl4 = new Pump_on_a_Chip.RoundControl();
            this.roundControl3 = new Pump_on_a_Chip.RoundControl();
            this.roundControl1 = new Pump_on_a_Chip.RoundControl();
            this.pinch3CellWasteRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.pinch3CellRadio = new MaterialSkin.Controls.MaterialRadioButton();
            this.pinch3TextLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resPTextLabel
            // 
            this.resPTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.resPTextLabel.Font = new System.Drawing.Font("Bahnschrift", 12.7F);
            this.resPTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.resPTextLabel.Location = new System.Drawing.Point(62, 27);
            this.resPTextLabel.Name = "resPTextLabel";
            this.resPTextLabel.Size = new System.Drawing.Size(181, 47);
            this.resPTextLabel.TabIndex = 2;
            this.resPTextLabel.Text = "Pressure Reservoir (mbar)";
            this.resPTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellPTextLabel
            // 
            this.cellPTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.cellPTextLabel.Font = new System.Drawing.Font("Bahnschrift", 12.7F);
            this.cellPTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.cellPTextLabel.Location = new System.Drawing.Point(349, 27);
            this.cellPTextLabel.Name = "cellPTextLabel";
            this.cellPTextLabel.Size = new System.Drawing.Size(169, 47);
            this.cellPTextLabel.TabIndex = 2;
            this.cellPTextLabel.Text = "Cell Reservoir (mbar)";
            this.cellPTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atPTextLabel
            // 
            this.atPTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.atPTextLabel.Font = new System.Drawing.Font("Bahnschrift", 12.7F);
            this.atPTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.atPTextLabel.Location = new System.Drawing.Point(48, 166);
            this.atPTextLabel.Name = "atPTextLabel";
            this.atPTextLabel.Size = new System.Drawing.Size(209, 47);
            this.atPTextLabel.TabIndex = 2;
            this.atPTextLabel.Text = "Atmospheric Pressure (mbar)";
            this.atPTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowrateTextLabel
            // 
            this.flowrateTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.flowrateTextLabel.Font = new System.Drawing.Font("Bahnschrift", 12.7F);
            this.flowrateTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.flowrateTextLabel.Location = new System.Drawing.Point(372, 166);
            this.flowrateTextLabel.Name = "flowrateTextLabel";
            this.flowrateTextLabel.Size = new System.Drawing.Size(125, 47);
            this.flowrateTextLabel.TabIndex = 2;
            this.flowrateTextLabel.Text = "Flow rate (ml/min)";
            this.flowrateTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resPLabel
            // 
            this.resPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.resPLabel.Font = new System.Drawing.Font("Bahnschrift", 28F);
            this.resPLabel.ForeColor = System.Drawing.Color.White;
            this.resPLabel.Location = new System.Drawing.Point(57, 81);
            this.resPLabel.Name = "resPLabel";
            this.resPLabel.Size = new System.Drawing.Size(190, 45);
            this.resPLabel.TabIndex = 3;
            this.resPLabel.Text = "0000.00";
            this.resPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellPLabel
            // 
            this.cellPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.cellPLabel.Font = new System.Drawing.Font("Bahnschrift", 28F);
            this.cellPLabel.ForeColor = System.Drawing.Color.White;
            this.cellPLabel.Location = new System.Drawing.Point(338, 81);
            this.cellPLabel.Name = "cellPLabel";
            this.cellPLabel.Size = new System.Drawing.Size(190, 45);
            this.cellPLabel.TabIndex = 3;
            this.cellPLabel.Text = "0000.00";
            this.cellPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // atPLabel
            // 
            this.atPLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.atPLabel.Font = new System.Drawing.Font("Bahnschrift", 28F);
            this.atPLabel.ForeColor = System.Drawing.Color.White;
            this.atPLabel.Location = new System.Drawing.Point(57, 218);
            this.atPLabel.Name = "atPLabel";
            this.atPLabel.Size = new System.Drawing.Size(190, 45);
            this.atPLabel.TabIndex = 3;
            this.atPLabel.Text = "0000.00";
            this.atPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowrateLabel
            // 
            this.flowrateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.flowrateLabel.Font = new System.Drawing.Font("Bahnschrift", 28F);
            this.flowrateLabel.ForeColor = System.Drawing.Color.White;
            this.flowrateLabel.Location = new System.Drawing.Point(339, 218);
            this.flowrateLabel.Name = "flowrateLabel";
            this.flowrateLabel.Size = new System.Drawing.Size(190, 45);
            this.flowrateLabel.TabIndex = 3;
            this.flowrateLabel.Text = "00.00";
            this.flowrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userModeButton
            // 
            this.userModeButton.ForeColor = System.Drawing.Color.Black;
            this.userModeButton.Location = new System.Drawing.Point(19, 871);
            this.userModeButton.Name = "userModeButton";
            this.userModeButton.Size = new System.Drawing.Size(545, 51);
            this.userModeButton.TabIndex = 40;
            this.userModeButton.Text = "User Mode";
            this.userModeButton.UseVisualStyleBackColor = true;
            this.userModeButton.Click += new System.EventHandler(this.userModeButton_Click);
            // 
            // resPTargetSlider
            // 
            this.resPTargetSlider.Depth = 0;
            this.resPTargetSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resPTargetSlider.Location = new System.Drawing.Point(5, 381);
            this.resPTargetSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.resPTargetSlider.Name = "resPTargetSlider";
            this.resPTargetSlider.ShowText = false;
            this.resPTargetSlider.ShowValue = false;
            this.resPTargetSlider.Size = new System.Drawing.Size(570, 40);
            this.resPTargetSlider.TabIndex = 41;
            this.resPTargetSlider.Text = "";
            this.resPTargetSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.pPressureSlider_onValueChanged);
            // 
            // resPTargetLabel
            // 
            this.resPTargetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.resPTargetLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.resPTargetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.resPTargetLabel.Location = new System.Drawing.Point(369, 343);
            this.resPTargetLabel.Name = "resPTargetLabel";
            this.resPTargetLabel.Size = new System.Drawing.Size(200, 50);
            this.resPTargetLabel.TabIndex = 43;
            this.resPTargetLabel.Text = "2000 mbar";
            this.resPTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resPTargetTextLabel
            // 
            this.resPTargetTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.resPTargetTextLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.resPTargetTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.resPTargetTextLabel.Location = new System.Drawing.Point(17, 343);
            this.resPTargetTextLabel.Name = "resPTargetTextLabel";
            this.resPTargetTextLabel.Size = new System.Drawing.Size(320, 50);
            this.resPTargetTextLabel.TabIndex = 42;
            this.resPTargetTextLabel.Text = "Target of Pressure Peservoir";
            this.resPTargetTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.panel1.Location = new System.Drawing.Point(22, 484);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 37);
            this.panel1.TabIndex = 46;
            // 
            // propValveTextLabel
            // 
            this.propValveTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.propValveTextLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propValveTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.propValveTextLabel.Location = new System.Drawing.Point(44, 437);
            this.propValveTextLabel.Name = "propValveTextLabel";
            this.propValveTextLabel.Size = new System.Drawing.Size(213, 38);
            this.propValveTextLabel.TabIndex = 47;
            this.propValveTextLabel.Text = "Proportional Valve";
            this.propValveTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ventPressureReservoirLabel
            // 
            this.ventPressureReservoirLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventPressureReservoirLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.ventPressureReservoirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ventPressureReservoirLabel.Location = new System.Drawing.Point(306, 439);
            this.ventPressureReservoirLabel.Name = "ventPressureReservoirLabel";
            this.ventPressureReservoirLabel.Size = new System.Drawing.Size(111, 100);
            this.ventPressureReservoirLabel.TabIndex = 50;
            this.ventPressureReservoirLabel.Text = "Vent\r\nPressure\r\nReservoir";
            this.ventPressureReservoirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ventPressureReservoirLabel.Click += new System.EventHandler(this.ventPressureReservoirLabel_Click);
            // 
            // ventCellReservoirLabel
            // 
            this.ventCellReservoirLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventCellReservoirLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.ventCellReservoirLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ventCellReservoirLabel.Location = new System.Drawing.Point(446, 439);
            this.ventCellReservoirLabel.Name = "ventCellReservoirLabel";
            this.ventCellReservoirLabel.Size = new System.Drawing.Size(111, 100);
            this.ventCellReservoirLabel.TabIndex = 51;
            this.ventCellReservoirLabel.Text = "Vent\r\nCell\r\nReservoir";
            this.ventCellReservoirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ventCellReservoirLabel.Click += new System.EventHandler(this.ventCellReservoirLabel_Click);
            // 
            // runPumpLabel
            // 
            this.runPumpLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.runPumpLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.runPumpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.runPumpLabel.Location = new System.Drawing.Point(307, 572);
            this.runPumpLabel.Name = "runPumpLabel";
            this.runPumpLabel.Size = new System.Drawing.Size(111, 100);
            this.runPumpLabel.TabIndex = 50;
            this.runPumpLabel.Text = "Pressurize Pressure Reservoir";
            this.runPumpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.runPumpLabel.Click += new System.EventHandler(this.runPumpLabel_Click);
            // 
            // remeasureAtmosphericPressureLabel
            // 
            this.remeasureAtmosphericPressureLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.remeasureAtmosphericPressureLabel.Font = new System.Drawing.Font("Bahnschrift", 12.7F);
            this.remeasureAtmosphericPressureLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.remeasureAtmosphericPressureLabel.Location = new System.Drawing.Point(447, 572);
            this.remeasureAtmosphericPressureLabel.Name = "remeasureAtmosphericPressureLabel";
            this.remeasureAtmosphericPressureLabel.Size = new System.Drawing.Size(111, 100);
            this.remeasureAtmosphericPressureLabel.TabIndex = 50;
            this.remeasureAtmosphericPressureLabel.Text = "Remeasure Atmospheric Pressure";
            this.remeasureAtmosphericPressureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.remeasureAtmosphericPressureLabel.Click += new System.EventHandler(this.remeasureAtmosphericPressureLabel_Click);
            // 
            // propCurrentTextLabel
            // 
            this.propCurrentTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.propCurrentTextLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propCurrentTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.propCurrentTextLabel.Location = new System.Drawing.Point(32, 495);
            this.propCurrentTextLabel.Name = "propCurrentTextLabel";
            this.propCurrentTextLabel.Size = new System.Drawing.Size(144, 31);
            this.propCurrentTextLabel.TabIndex = 54;
            this.propCurrentTextLabel.Text = "Current (%)";
            this.propCurrentTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propTargetTextLabel
            // 
            this.propTargetTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.propTargetTextLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propTargetTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.propTargetTextLabel.Location = new System.Drawing.Point(32, 530);
            this.propTargetTextLabel.Name = "propTargetTextLabel";
            this.propTargetTextLabel.Size = new System.Drawing.Size(144, 31);
            this.propTargetTextLabel.TabIndex = 55;
            this.propTargetTextLabel.Text = "Target (%)";
            this.propTargetTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // propCurrentLabel
            // 
            this.propCurrentLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.propCurrentLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propCurrentLabel.ForeColor = System.Drawing.Color.White;
            this.propCurrentLabel.Location = new System.Drawing.Point(188, 495);
            this.propCurrentLabel.Name = "propCurrentLabel";
            this.propCurrentLabel.Size = new System.Drawing.Size(70, 31);
            this.propCurrentLabel.TabIndex = 54;
            this.propCurrentLabel.Text = "00";
            this.propCurrentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propTargetLabel
            // 
            this.propTargetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.propTargetLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propTargetLabel.ForeColor = System.Drawing.Color.White;
            this.propTargetLabel.Location = new System.Drawing.Point(188, 530);
            this.propTargetLabel.Name = "propTargetLabel";
            this.propTargetLabel.Size = new System.Drawing.Size(70, 31);
            this.propTargetLabel.TabIndex = 55;
            this.propTargetLabel.Text = "00";
            this.propTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // propValveSetLabel
            // 
            this.propValveSetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.propValveSetLabel.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.propValveSetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.propValveSetLabel.Location = new System.Drawing.Point(195, 584);
            this.propValveSetLabel.Name = "propValveSetLabel";
            this.propValveSetLabel.Size = new System.Drawing.Size(62, 66);
            this.propValveSetLabel.TabIndex = 56;
            this.propValveSetLabel.Text = "Set";
            this.propValveSetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.propValveSetLabel.Click += new System.EventHandler(this.propValveSetLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.panel2.Location = new System.Drawing.Point(103, 587);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 60);
            this.panel2.TabIndex = 58;
            // 
            // propDecLabel
            // 
            this.propDecLabel.Image = global::Pump_on_a_Chip.Properties.Resources.dec2;
            this.propDecLabel.Location = new System.Drawing.Point(107, 582);
            this.propDecLabel.Name = "propDecLabel";
            this.propDecLabel.Size = new System.Drawing.Size(58, 70);
            this.propDecLabel.TabIndex = 59;
            this.propDecLabel.Click += new System.EventHandler(this.propDecLabel_Click);
            // 
            // propIncLabel
            // 
            this.propIncLabel.Image = global::Pump_on_a_Chip.Properties.Resources.inc2;
            this.propIncLabel.Location = new System.Drawing.Point(43, 582);
            this.propIncLabel.Name = "propIncLabel";
            this.propIncLabel.Size = new System.Drawing.Size(58, 70);
            this.propIncLabel.TabIndex = 59;
            this.propIncLabel.Click += new System.EventHandler(this.propIncLabel_Click);
            // 
            // pinch1Switch
            // 
            this.pinch1Switch.AutoSize = true;
            this.pinch1Switch.Depth = 0;
            this.pinch1Switch.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.pinch1Switch.ForeColor = System.Drawing.Color.White;
            this.pinch1Switch.Location = new System.Drawing.Point(80, 706);
            this.pinch1Switch.Margin = new System.Windows.Forms.Padding(0);
            this.pinch1Switch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinch1Switch.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinch1Switch.Name = "pinch1Switch";
            this.pinch1Switch.Ripple = true;
            this.pinch1Switch.Size = new System.Drawing.Size(154, 37);
            this.pinch1Switch.TabIndex = 60;
            this.pinch1Switch.Text = "Pinch Valve 1";
            this.pinch1Switch.UseVisualStyleBackColor = true;
            this.pinch1Switch.CheckedChanged += new System.EventHandler(this.pinch1Switch_CheckedChanged);
            // 
            // pinch2Switch
            // 
            this.pinch2Switch.AutoSize = true;
            this.pinch2Switch.Depth = 0;
            this.pinch2Switch.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.pinch2Switch.ForeColor = System.Drawing.Color.White;
            this.pinch2Switch.Location = new System.Drawing.Point(80, 754);
            this.pinch2Switch.Margin = new System.Windows.Forms.Padding(0);
            this.pinch2Switch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinch2Switch.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinch2Switch.Name = "pinch2Switch";
            this.pinch2Switch.Ripple = true;
            this.pinch2Switch.Size = new System.Drawing.Size(154, 37);
            this.pinch2Switch.TabIndex = 61;
            this.pinch2Switch.Text = "Pinch Valve 2";
            this.pinch2Switch.UseVisualStyleBackColor = true;
            this.pinch2Switch.CheckedChanged += new System.EventHandler(this.pinch2Switch_CheckedChanged);
            // 
            // pump2Switch
            // 
            this.pump2Switch.AutoSize = true;
            this.pump2Switch.Depth = 0;
            this.pump2Switch.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.pump2Switch.ForeColor = System.Drawing.Color.White;
            this.pump2Switch.Location = new System.Drawing.Point(80, 802);
            this.pump2Switch.Margin = new System.Windows.Forms.Padding(0);
            this.pump2Switch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pump2Switch.MouseState = MaterialSkin.MouseState.HOVER;
            this.pump2Switch.Name = "pump2Switch";
            this.pump2Switch.Ripple = true;
            this.pump2Switch.Size = new System.Drawing.Size(163, 37);
            this.pump2Switch.TabIndex = 63;
            this.pump2Switch.Text = "Drawing Pump";
            this.pump2Switch.UseVisualStyleBackColor = true;
            this.pump2Switch.CheckedChanged += new System.EventHandler(this.pump2Switch_CheckedChanged);
            // 
            // roundControl8
            // 
            this.roundControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.roundControl8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.roundControl8.BorderWidth = 0F;
            this.roundControl8.Location = new System.Drawing.Point(28, 567);
            this.roundControl8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.roundControl8.Name = "roundControl8";
            this.roundControl8.Radius = 20;
            this.roundControl8.Size = new System.Drawing.Size(152, 99);
            this.roundControl8.TabIndex = 57;
            // 
            // propValveSetButton
            // 
            this.propValveSetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.propValveSetButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.propValveSetButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.propValveSetButton.BorderWidth = 0F;
            this.propValveSetButton.Location = new System.Drawing.Point(179, 567);
            this.propValveSetButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.propValveSetButton.Name = "propValveSetButton";
            this.propValveSetButton.Radius = 20;
            this.propValveSetButton.Size = new System.Drawing.Size(94, 99);
            this.propValveSetButton.TabIndex = 53;
            // 
            // runPumpButton
            // 
            this.runPumpButton.BackColor = System.Drawing.Color.Transparent;
            this.runPumpButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.runPumpButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.runPumpButton.BorderWidth = 0F;
            this.runPumpButton.Location = new System.Drawing.Point(290, 556);
            this.runPumpButton.Margin = new System.Windows.Forms.Padding(405, 2519, 405, 2519);
            this.runPumpButton.Name = "runPumpButton";
            this.runPumpButton.Radius = 20;
            this.runPumpButton.Size = new System.Drawing.Size(142, 131);
            this.runPumpButton.TabIndex = 49;
            // 
            // remeasureAtmosphericPressureButton
            // 
            this.remeasureAtmosphericPressureButton.BackColor = System.Drawing.Color.Transparent;
            this.remeasureAtmosphericPressureButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.remeasureAtmosphericPressureButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.remeasureAtmosphericPressureButton.BorderWidth = 0F;
            this.remeasureAtmosphericPressureButton.Location = new System.Drawing.Point(430, 556);
            this.remeasureAtmosphericPressureButton.Margin = new System.Windows.Forms.Padding(189, 916, 189, 916);
            this.remeasureAtmosphericPressureButton.Name = "remeasureAtmosphericPressureButton";
            this.remeasureAtmosphericPressureButton.Radius = 20;
            this.remeasureAtmosphericPressureButton.Size = new System.Drawing.Size(142, 131);
            this.remeasureAtmosphericPressureButton.TabIndex = 48;
            // 
            // ventCellReservoirButton
            // 
            this.ventCellReservoirButton.BackColor = System.Drawing.Color.Transparent;
            this.ventCellReservoirButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventCellReservoirButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventCellReservoirButton.BorderWidth = 0F;
            this.ventCellReservoirButton.Location = new System.Drawing.Point(430, 423);
            this.ventCellReservoirButton.Margin = new System.Windows.Forms.Padding(88, 333, 88, 333);
            this.ventCellReservoirButton.Name = "ventCellReservoirButton";
            this.ventCellReservoirButton.Radius = 20;
            this.ventCellReservoirButton.Size = new System.Drawing.Size(142, 131);
            this.ventCellReservoirButton.TabIndex = 48;
            // 
            // ventPressureReservoirButton
            // 
            this.ventPressureReservoirButton.BackColor = System.Drawing.Color.Transparent;
            this.ventPressureReservoirButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventPressureReservoirButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.ventPressureReservoirButton.BorderWidth = 0F;
            this.ventPressureReservoirButton.Location = new System.Drawing.Point(290, 423);
            this.ventPressureReservoirButton.Margin = new System.Windows.Forms.Padding(41, 121, 41, 121);
            this.ventPressureReservoirButton.Name = "ventPressureReservoirButton";
            this.ventPressureReservoirButton.Radius = 20;
            this.ventPressureReservoirButton.Size = new System.Drawing.Size(142, 131);
            this.ventPressureReservoirButton.TabIndex = 48;
            // 
            // roundControl6
            // 
            this.roundControl6.BackColor = System.Drawing.Color.Transparent;
            this.roundControl6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl6.BorderWidth = 0F;
            this.roundControl6.Location = new System.Drawing.Point(11, 482);
            this.roundControl6.Margin = new System.Windows.Forms.Padding(41, 121, 41, 121);
            this.roundControl6.Name = "roundControl6";
            this.roundControl6.Radius = 20;
            this.roundControl6.Size = new System.Drawing.Size(281, 205);
            this.roundControl6.TabIndex = 45;
            // 
            // roundControl5
            // 
            this.roundControl5.BackColor = System.Drawing.Color.Transparent;
            this.roundControl5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.roundControl5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.roundControl5.BorderWidth = 0F;
            this.roundControl5.Location = new System.Drawing.Point(13, 423);
            this.roundControl5.Margin = new System.Windows.Forms.Padding(19, 44, 19, 44);
            this.roundControl5.Name = "roundControl5";
            this.roundControl5.Radius = 20;
            this.roundControl5.Size = new System.Drawing.Size(279, 270);
            this.roundControl5.TabIndex = 44;
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.Transparent;
            this.roundControl2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl2.BorderWidth = 0F;
            this.roundControl2.Location = new System.Drawing.Point(291, 11);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 20;
            this.roundControl2.Size = new System.Drawing.Size(281, 140);
            this.roundControl2.TabIndex = 1;
            // 
            // roundControl4
            // 
            this.roundControl4.BackColor = System.Drawing.Color.Transparent;
            this.roundControl4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl4.BorderWidth = 0F;
            this.roundControl4.Location = new System.Drawing.Point(291, 151);
            this.roundControl4.Margin = new System.Windows.Forms.Padding(19, 44, 19, 44);
            this.roundControl4.Name = "roundControl4";
            this.roundControl4.Radius = 20;
            this.roundControl4.Size = new System.Drawing.Size(281, 140);
            this.roundControl4.TabIndex = 0;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.Transparent;
            this.roundControl3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl3.BorderWidth = 0F;
            this.roundControl3.Location = new System.Drawing.Point(11, 151);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(9, 16, 9, 16);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 20;
            this.roundControl3.Size = new System.Drawing.Size(281, 140);
            this.roundControl3.TabIndex = 0;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.Transparent;
            this.roundControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(57)))), ((int)(((byte)(71)))));
            this.roundControl1.BorderWidth = 0F;
            this.roundControl1.Location = new System.Drawing.Point(11, 11);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 20;
            this.roundControl1.Size = new System.Drawing.Size(281, 140);
            this.roundControl1.TabIndex = 0;
            // 
            // pinch3CellWasteRadio
            // 
            this.pinch3CellWasteRadio.AutoSize = true;
            this.pinch3CellWasteRadio.Checked = true;
            this.pinch3CellWasteRadio.Depth = 0;
            this.pinch3CellWasteRadio.Location = new System.Drawing.Point(334, 746);
            this.pinch3CellWasteRadio.Margin = new System.Windows.Forms.Padding(0);
            this.pinch3CellWasteRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinch3CellWasteRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinch3CellWasteRadio.Name = "pinch3CellWasteRadio";
            this.pinch3CellWasteRadio.Ripple = true;
            this.pinch3CellWasteRadio.Size = new System.Drawing.Size(178, 37);
            this.pinch3CellWasteRadio.TabIndex = 64;
            this.pinch3CellWasteRadio.TabStop = true;
            this.pinch3CellWasteRadio.Text = "Cell Waste Reservoir";
            this.pinch3CellWasteRadio.UseVisualStyleBackColor = true;
            // 
            // pinch3CellRadio
            // 
            this.pinch3CellRadio.AutoSize = true;
            this.pinch3CellRadio.Depth = 0;
            this.pinch3CellRadio.Location = new System.Drawing.Point(334, 783);
            this.pinch3CellRadio.Margin = new System.Windows.Forms.Padding(0);
            this.pinch3CellRadio.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pinch3CellRadio.MouseState = MaterialSkin.MouseState.HOVER;
            this.pinch3CellRadio.Name = "pinch3CellRadio";
            this.pinch3CellRadio.Ripple = true;
            this.pinch3CellRadio.Size = new System.Drawing.Size(130, 37);
            this.pinch3CellRadio.TabIndex = 65;
            this.pinch3CellRadio.TabStop = true;
            this.pinch3CellRadio.Text = "Cell Reservoir";
            this.pinch3CellRadio.UseVisualStyleBackColor = true;
            this.pinch3CellRadio.CheckedChanged += new System.EventHandler(this.pinch3CellRadio_CheckedChanged);
            // 
            // pinch3TextLabel
            // 
            this.pinch3TextLabel.AutoSize = true;
            this.pinch3TextLabel.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.pinch3TextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(193)))), ((int)(((byte)(198)))));
            this.pinch3TextLabel.Location = new System.Drawing.Point(372, 717);
            this.pinch3TextLabel.Name = "pinch3TextLabel";
            this.pinch3TextLabel.Size = new System.Drawing.Size(125, 23);
            this.pinch3TextLabel.TabIndex = 66;
            this.pinch3TextLabel.Text = "Pinch Valve 3";
            // 
            // AdminModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(34)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(584, 943);
            this.Controls.Add(this.pinch3TextLabel);
            this.Controls.Add(this.pinch3CellRadio);
            this.Controls.Add(this.pinch3CellWasteRadio);
            this.Controls.Add(this.pump2Switch);
            this.Controls.Add(this.pinch2Switch);
            this.Controls.Add(this.pinch1Switch);
            this.Controls.Add(this.propDecLabel);
            this.Controls.Add(this.propIncLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.roundControl8);
            this.Controls.Add(this.propValveSetLabel);
            this.Controls.Add(this.propTargetLabel);
            this.Controls.Add(this.propCurrentLabel);
            this.Controls.Add(this.propTargetTextLabel);
            this.Controls.Add(this.propCurrentTextLabel);
            this.Controls.Add(this.propValveSetButton);
            this.Controls.Add(this.ventCellReservoirLabel);
            this.Controls.Add(this.remeasureAtmosphericPressureLabel);
            this.Controls.Add(this.runPumpLabel);
            this.Controls.Add(this.ventPressureReservoirLabel);
            this.Controls.Add(this.runPumpButton);
            this.Controls.Add(this.remeasureAtmosphericPressureButton);
            this.Controls.Add(this.ventCellReservoirButton);
            this.Controls.Add(this.ventPressureReservoirButton);
            this.Controls.Add(this.propValveTextLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundControl6);
            this.Controls.Add(this.roundControl5);
            this.Controls.Add(this.resPTargetSlider);
            this.Controls.Add(this.resPTargetLabel);
            this.Controls.Add(this.resPTargetTextLabel);
            this.Controls.Add(this.userModeButton);
            this.Controls.Add(this.cellPLabel);
            this.Controls.Add(this.flowrateLabel);
            this.Controls.Add(this.atPLabel);
            this.Controls.Add(this.resPLabel);
            this.Controls.Add(this.cellPTextLabel);
            this.Controls.Add(this.flowrateTextLabel);
            this.Controls.Add(this.atPTextLabel);
            this.Controls.Add(this.resPTextLabel);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.roundControl4);
            this.Controls.Add(this.roundControl3);
            this.Controls.Add(this.roundControl1);
            this.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AdminModeForm";
            this.Text = "AdminModeForm";
            this.Load += new System.EventHandler(this.AdminModeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundControl roundControl1;
        private RoundControl roundControl2;
        private RoundControl roundControl3;
        private RoundControl roundControl4;
        private System.Windows.Forms.Label resPTextLabel;
        private System.Windows.Forms.Label cellPTextLabel;
        private System.Windows.Forms.Label atPTextLabel;
        private System.Windows.Forms.Label flowrateTextLabel;
        private System.Windows.Forms.Button userModeButton;
        private MaterialSkin.Controls.MaterialSlider resPTargetSlider;
        private System.Windows.Forms.Label resPTargetLabel;
        private System.Windows.Forms.Label resPTargetTextLabel;
        private RoundControl roundControl5;
        private RoundControl roundControl6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label propValveTextLabel;
        private RoundControl ventPressureReservoirButton;
        private RoundControl ventCellReservoirButton;
        private RoundControl remeasureAtmosphericPressureButton;
        private RoundControl runPumpButton;
        private System.Windows.Forms.Label ventPressureReservoirLabel;
        private System.Windows.Forms.Label ventCellReservoirLabel;
        private System.Windows.Forms.Label runPumpLabel;
        private System.Windows.Forms.Label remeasureAtmosphericPressureLabel;
        private RoundControl propValveSetButton;
        private System.Windows.Forms.Label propCurrentTextLabel;
        private System.Windows.Forms.Label propTargetTextLabel;
        private System.Windows.Forms.Label propValveSetLabel;
        private RoundControl roundControl8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label propIncLabel;
        private System.Windows.Forms.Label propDecLabel;
        public System.Windows.Forms.Label resPLabel;
        public System.Windows.Forms.Label cellPLabel;
        public System.Windows.Forms.Label atPLabel;
        public System.Windows.Forms.Label flowrateLabel;
        public System.Windows.Forms.Label propCurrentLabel;
        public System.Windows.Forms.Label propTargetLabel;
        private MaterialSkin.Controls.MaterialSwitch pinch1Switch;
        private MaterialSkin.Controls.MaterialSwitch pinch2Switch;
        private MaterialSkin.Controls.MaterialSwitch pump2Switch;
        private MaterialSkin.Controls.MaterialRadioButton pinch3CellWasteRadio;
        private MaterialSkin.Controls.MaterialRadioButton pinch3CellRadio;
        private System.Windows.Forms.Label pinch3TextLabel;
    }
}