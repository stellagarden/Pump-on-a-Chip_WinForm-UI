namespace Pump_on_a_Chip
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.operatingTimePanel = new System.Windows.Forms.Panel();
            this.operatingTimeTextLabel = new System.Windows.Forms.Label();
            this.roundControl2 = new Pump_on_a_Chip.RoundControl();
            this.roundControl1 = new Pump_on_a_Chip.RoundControl();
            this.operatingTimeLabel = new System.Windows.Forms.Label();
            this.roundControl3 = new Pump_on_a_Chip.RoundControl();
            this.pCellTextLabel = new System.Windows.Forms.Label();
            this.pCellLabel = new System.Windows.Forms.Label();
            this.roundControl4 = new Pump_on_a_Chip.RoundControl();
            this.flowrateTextLabel = new System.Windows.Forms.Label();
            this.flowrateLabel = new System.Windows.Forms.Label();
            this.startButton = new Pump_on_a_Chip.RoundButton();
            this.pCellSlider = new MaterialSkin.Controls.MaterialSlider();
            this.pCellTargetTextLabel = new System.Windows.Forms.Label();
            this.pCellTargetLabel = new System.Windows.Forms.Label();
            this.adminModeButton = new System.Windows.Forms.Button();
            this.operatingTimer = new System.Windows.Forms.Timer(this.components);
            this.statusBarPanel = new System.Windows.Forms.Panel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.timeLabel.Location = new System.Drawing.Point(364, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(205, 39);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "00:00 PM";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateLabel.Font = new System.Drawing.Font("Bahnschrift", 14F);
            this.dateLabel.Location = new System.Drawing.Point(10, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(192, 39);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "00/00/0000";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.statusLabel.Font = new System.Drawing.Font("Bahnschrift", 32F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(124, 66);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(348, 52);
            this.statusLabel.TabIndex = 10;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operatingTimePanel
            // 
            this.operatingTimePanel.BackColor = System.Drawing.Color.White;
            this.operatingTimePanel.Location = new System.Drawing.Point(20, 126);
            this.operatingTimePanel.Name = "operatingTimePanel";
            this.operatingTimePanel.Size = new System.Drawing.Size(539, 44);
            this.operatingTimePanel.TabIndex = 12;
            // 
            // operatingTimeTextLabel
            // 
            this.operatingTimeTextLabel.AutoSize = true;
            this.operatingTimeTextLabel.BackColor = System.Drawing.Color.White;
            this.operatingTimeTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.operatingTimeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.operatingTimeTextLabel.Location = new System.Drawing.Point(38, 144);
            this.operatingTimeTextLabel.Name = "operatingTimeTextLabel";
            this.operatingTimeTextLabel.Size = new System.Drawing.Size(175, 29);
            this.operatingTimeTextLabel.TabIndex = 13;
            this.operatingTimeTextLabel.Text = "Operating Time";
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl2.BackgroundColor = System.Drawing.Color.White;
            this.roundControl2.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl2.BorderWidth = 0F;
            this.roundControl2.Location = new System.Drawing.Point(9, 126);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(15, 22, 15, 22);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 25;
            this.roundControl2.Size = new System.Drawing.Size(559, 118);
            this.roundControl2.TabIndex = 11;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.roundControl1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl1.BorderWidth = 0F;
            this.roundControl1.Location = new System.Drawing.Point(9, 47);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 25;
            this.roundControl1.Size = new System.Drawing.Size(559, 173);
            this.roundControl1.TabIndex = 4;
            // 
            // operatingTimeLabel
            // 
            this.operatingTimeLabel.AutoSize = true;
            this.operatingTimeLabel.BackColor = System.Drawing.Color.White;
            this.operatingTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 54F);
            this.operatingTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.operatingTimeLabel.Location = new System.Drawing.Point(251, 133);
            this.operatingTimeLabel.Name = "operatingTimeLabel";
            this.operatingTimeLabel.Size = new System.Drawing.Size(298, 87);
            this.operatingTimeLabel.TabIndex = 14;
            this.operatingTimeLabel.Text = "00:00:00";
            this.operatingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl3.BackgroundColor = System.Drawing.Color.White;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 0F;
            this.roundControl3.Location = new System.Drawing.Point(9, 248);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(32, 58, 32, 58);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 25;
            this.roundControl3.Size = new System.Drawing.Size(277, 195);
            this.roundControl3.TabIndex = 15;
            // 
            // pCellTextLabel
            // 
            this.pCellTextLabel.BackColor = System.Drawing.Color.White;
            this.pCellTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.pCellTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pCellTextLabel.Location = new System.Drawing.Point(63, 262);
            this.pCellTextLabel.Name = "pCellTextLabel";
            this.pCellTextLabel.Size = new System.Drawing.Size(170, 70);
            this.pCellTextLabel.TabIndex = 16;
            this.pCellTextLabel.Text = "Cell Reservoir (mbar)";
            this.pCellTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCellLabel
            // 
            this.pCellLabel.BackColor = System.Drawing.Color.White;
            this.pCellLabel.Font = new System.Drawing.Font("Bahnschrift", 36F);
            this.pCellLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.pCellLabel.Location = new System.Drawing.Point(49, 342);
            this.pCellLabel.Name = "pCellLabel";
            this.pCellLabel.Size = new System.Drawing.Size(199, 69);
            this.pCellLabel.TabIndex = 17;
            this.pCellLabel.Text = "0.00";
            this.pCellLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundControl4
            // 
            this.roundControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl4.BackgroundColor = System.Drawing.Color.White;
            this.roundControl4.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl4.BorderWidth = 0F;
            this.roundControl4.Location = new System.Drawing.Point(291, 248);
            this.roundControl4.Margin = new System.Windows.Forms.Padding(69, 160, 69, 160);
            this.roundControl4.Name = "roundControl4";
            this.roundControl4.Radius = 25;
            this.roundControl4.Size = new System.Drawing.Size(277, 195);
            this.roundControl4.TabIndex = 15;
            // 
            // flowrateTextLabel
            // 
            this.flowrateTextLabel.BackColor = System.Drawing.Color.White;
            this.flowrateTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.flowrateTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.flowrateTextLabel.Location = new System.Drawing.Point(348, 262);
            this.flowrateTextLabel.Name = "flowrateTextLabel";
            this.flowrateTextLabel.Size = new System.Drawing.Size(170, 70);
            this.flowrateTextLabel.TabIndex = 16;
            this.flowrateTextLabel.Text = "Flow rate (ml/min)";
            this.flowrateTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowrateLabel
            // 
            this.flowrateLabel.BackColor = System.Drawing.Color.White;
            this.flowrateLabel.Font = new System.Drawing.Font("Bahnschrift", 36F);
            this.flowrateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.flowrateLabel.Location = new System.Drawing.Point(334, 342);
            this.flowrateLabel.Name = "flowrateLabel";
            this.flowrateLabel.Size = new System.Drawing.Size(199, 69);
            this.flowrateLabel.TabIndex = 17;
            this.flowrateLabel.Text = "0.00";
            this.flowrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.startButton.Font = new System.Drawing.Font("Bahnschrift", 44F);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.startButton.Location = new System.Drawing.Point(139, 465);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(300, 300);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pCellSlider
            // 
            this.pCellSlider.Depth = 0;
            this.pCellSlider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pCellSlider.Location = new System.Drawing.Point(4, 825);
            this.pCellSlider.MouseState = MaterialSkin.MouseState.HOVER;
            this.pCellSlider.Name = "pCellSlider";
            this.pCellSlider.ShowText = false;
            this.pCellSlider.ShowValue = false;
            this.pCellSlider.Size = new System.Drawing.Size(570, 40);
            this.pCellSlider.TabIndex = 19;
            this.pCellSlider.Text = "";
            this.pCellSlider.onValueChanged += new MaterialSkin.Controls.MaterialSlider.ValueChanged(this.pCellSlider_onValueChanged);
            // 
            // pCellTargetTextLabel
            // 
            this.pCellTargetTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pCellTargetTextLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.pCellTargetTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.pCellTargetTextLabel.Location = new System.Drawing.Point(14, 779);
            this.pCellTargetTextLabel.Name = "pCellTargetTextLabel";
            this.pCellTargetTextLabel.Size = new System.Drawing.Size(320, 50);
            this.pCellTargetTextLabel.TabIndex = 20;
            this.pCellTargetTextLabel.Text = "Target of Cell Peservoir";
            this.pCellTargetTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pCellTargetLabel
            // 
            this.pCellTargetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pCellTargetLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.pCellTargetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.pCellTargetLabel.Location = new System.Drawing.Point(368, 779);
            this.pCellTargetLabel.Name = "pCellTargetLabel";
            this.pCellTargetLabel.Size = new System.Drawing.Size(200, 50);
            this.pCellTargetLabel.TabIndex = 21;
            this.pCellTargetLabel.Text = "300 mbar";
            this.pCellTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // adminModeButton
            // 
            this.adminModeButton.ForeColor = System.Drawing.Color.Black;
            this.adminModeButton.Location = new System.Drawing.Point(19, 898);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Size = new System.Drawing.Size(541, 51);
            this.adminModeButton.TabIndex = 22;
            this.adminModeButton.Text = "Administrator Mode";
            this.adminModeButton.UseVisualStyleBackColor = true;
            // 
            // operatingTimer
            // 
            this.operatingTimer.Tick += new System.EventHandler(this.operatingTimer_Tick_1);
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusBarPanel.Location = new System.Drawing.Point(0, 0);
            this.statusBarPanel.Name = "statusBarPanel";
            this.statusBarPanel.Size = new System.Drawing.Size(578, 42);
            this.statusBarPanel.TabIndex = 23;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(578, 968);
            this.Controls.Add(this.pCellSlider);
            this.Controls.Add(this.adminModeButton);
            this.Controls.Add(this.pCellTargetLabel);
            this.Controls.Add(this.pCellTargetTextLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.flowrateLabel);
            this.Controls.Add(this.pCellLabel);
            this.Controls.Add(this.flowrateTextLabel);
            this.Controls.Add(this.pCellTextLabel);
            this.Controls.Add(this.roundControl4);
            this.Controls.Add(this.roundControl3);
            this.Controls.Add(this.operatingTimeLabel);
            this.Controls.Add(this.operatingTimeTextLabel);
            this.Controls.Add(this.operatingTimePanel);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.roundControl1);
            this.Controls.Add(this.statusBarPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 7, 7);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biomedical Microsystems Laboratory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer globalTimer;
        private RoundControl roundControl1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label statusLabel;
        private RoundControl roundControl2;
        private System.Windows.Forms.Panel operatingTimePanel;
        private System.Windows.Forms.Label operatingTimeTextLabel;
        private System.Windows.Forms.Label operatingTimeLabel;
        private RoundControl roundControl3;
        private System.Windows.Forms.Label pCellTextLabel;
        private System.Windows.Forms.Label pCellLabel;
        private RoundControl roundControl4;
        private System.Windows.Forms.Label flowrateTextLabel;
        private System.Windows.Forms.Label flowrateLabel;
        private RoundButton startButton;
        private MaterialSkin.Controls.MaterialSlider pCellSlider;
        private System.Windows.Forms.Label pCellTargetTextLabel;
        private System.Windows.Forms.Label pCellTargetLabel;
        private System.Windows.Forms.Button adminModeButton;
        private System.Windows.Forms.Timer operatingTimer;
        private System.Windows.Forms.Panel statusBarPanel;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

