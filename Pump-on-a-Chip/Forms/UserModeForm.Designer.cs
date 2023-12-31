﻿namespace Pump_on_a_Chip.Forms
{
    partial class UserModeForm
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
            this.adminModeButton = new System.Windows.Forms.Button();
            this.pCellTargetLabel = new System.Windows.Forms.Label();
            this.pCellTargetTextLabel = new System.Windows.Forms.Label();
            this.flowrateLabel = new System.Windows.Forms.Label();
            this.pCellLabel = new System.Windows.Forms.Label();
            this.flowrateTextLabel = new System.Windows.Forms.Label();
            this.pCellTextLabel = new System.Windows.Forms.Label();
            this.operatingTimeLabel = new System.Windows.Forms.Label();
            this.operatingTimeTextLabel = new System.Windows.Forms.Label();
            this.operatingTimePanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.operatingTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new Pump_on_a_Chip.RoundButton();
            this.roundControl4 = new Pump_on_a_Chip.RoundControl();
            this.roundControl3 = new Pump_on_a_Chip.RoundControl();
            this.roundControl2 = new Pump_on_a_Chip.RoundControl();
            this.roundControl1 = new Pump_on_a_Chip.RoundControl();
            this.pCellTrackBar = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pCellTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // adminModeButton
            // 
            this.adminModeButton.ForeColor = System.Drawing.Color.Black;
            this.adminModeButton.Location = new System.Drawing.Point(19, 871);
            this.adminModeButton.Name = "adminModeButton";
            this.adminModeButton.Size = new System.Drawing.Size(545, 51);
            this.adminModeButton.TabIndex = 39;
            this.adminModeButton.Text = "Administrator Mode";
            this.adminModeButton.UseVisualStyleBackColor = true;
            this.adminModeButton.Click += new System.EventHandler(this.adminModeButton_Click);
            // 
            // pCellTargetLabel
            // 
            this.pCellTargetLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pCellTargetLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.pCellTargetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.pCellTargetLabel.Location = new System.Drawing.Point(370, 752);
            this.pCellTargetLabel.Name = "pCellTargetLabel";
            this.pCellTargetLabel.Size = new System.Drawing.Size(200, 50);
            this.pCellTargetLabel.TabIndex = 38;
            this.pCellTargetLabel.Text = "300 mbar";
            this.pCellTargetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pCellTargetTextLabel
            // 
            this.pCellTargetTextLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pCellTargetTextLabel.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.pCellTargetTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.pCellTargetTextLabel.Location = new System.Drawing.Point(16, 752);
            this.pCellTargetTextLabel.Name = "pCellTargetTextLabel";
            this.pCellTargetTextLabel.Size = new System.Drawing.Size(320, 50);
            this.pCellTargetTextLabel.TabIndex = 37;
            this.pCellTargetTextLabel.Text = "Target of Cell Peservoir";
            this.pCellTargetTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowrateLabel
            // 
            this.flowrateLabel.BackColor = System.Drawing.Color.White;
            this.flowrateLabel.Font = new System.Drawing.Font("Bahnschrift", 36F);
            this.flowrateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.flowrateLabel.Location = new System.Drawing.Point(342, 304);
            this.flowrateLabel.Name = "flowrateLabel";
            this.flowrateLabel.Size = new System.Drawing.Size(199, 69);
            this.flowrateLabel.TabIndex = 34;
            this.flowrateLabel.Text = "0.00";
            this.flowrateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCellLabel
            // 
            this.pCellLabel.BackColor = System.Drawing.Color.White;
            this.pCellLabel.Font = new System.Drawing.Font("Bahnschrift", 36F);
            this.pCellLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.pCellLabel.Location = new System.Drawing.Point(52, 304);
            this.pCellLabel.Name = "pCellLabel";
            this.pCellLabel.Size = new System.Drawing.Size(199, 69);
            this.pCellLabel.TabIndex = 33;
            this.pCellLabel.Text = "0.00";
            this.pCellLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowrateTextLabel
            // 
            this.flowrateTextLabel.BackColor = System.Drawing.Color.White;
            this.flowrateTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.flowrateTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.flowrateTextLabel.Location = new System.Drawing.Point(356, 224);
            this.flowrateTextLabel.Name = "flowrateTextLabel";
            this.flowrateTextLabel.Size = new System.Drawing.Size(170, 70);
            this.flowrateTextLabel.TabIndex = 32;
            this.flowrateTextLabel.Text = "Flow rate (ml/min)";
            this.flowrateTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCellTextLabel
            // 
            this.pCellTextLabel.BackColor = System.Drawing.Color.White;
            this.pCellTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.pCellTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.pCellTextLabel.Location = new System.Drawing.Point(66, 224);
            this.pCellTextLabel.Name = "pCellTextLabel";
            this.pCellTextLabel.Size = new System.Drawing.Size(170, 70);
            this.pCellTextLabel.TabIndex = 31;
            this.pCellTextLabel.Text = "Cell Reservoir (mbar)";
            this.pCellTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operatingTimeLabel
            // 
            this.operatingTimeLabel.AutoSize = true;
            this.operatingTimeLabel.BackColor = System.Drawing.Color.White;
            this.operatingTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 54F);
            this.operatingTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.operatingTimeLabel.Location = new System.Drawing.Point(254, 95);
            this.operatingTimeLabel.Name = "operatingTimeLabel";
            this.operatingTimeLabel.Size = new System.Drawing.Size(298, 87);
            this.operatingTimeLabel.TabIndex = 28;
            this.operatingTimeLabel.Text = "00:00:00";
            this.operatingTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // operatingTimeTextLabel
            // 
            this.operatingTimeTextLabel.AutoSize = true;
            this.operatingTimeTextLabel.BackColor = System.Drawing.Color.White;
            this.operatingTimeTextLabel.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.operatingTimeTextLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.operatingTimeTextLabel.Location = new System.Drawing.Point(37, 106);
            this.operatingTimeTextLabel.Name = "operatingTimeTextLabel";
            this.operatingTimeTextLabel.Size = new System.Drawing.Size(175, 29);
            this.operatingTimeTextLabel.TabIndex = 27;
            this.operatingTimeTextLabel.Text = "Operating Time";
            // 
            // operatingTimePanel
            // 
            this.operatingTimePanel.BackColor = System.Drawing.Color.White;
            this.operatingTimePanel.Location = new System.Drawing.Point(19, 88);
            this.operatingTimePanel.Name = "operatingTimePanel";
            this.operatingTimePanel.Size = new System.Drawing.Size(548, 44);
            this.operatingTimePanel.TabIndex = 26;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.statusLabel.Font = new System.Drawing.Font("Bahnschrift", 32F);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(125, 28);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(348, 52);
            this.statusLabel.TabIndex = 24;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // operatingTimer
            // 
            this.operatingTimer.Tick += new System.EventHandler(this.operatingTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(191)))), ((int)(((byte)(73)))));
            this.startButton.Font = new System.Drawing.Font("Bahnschrift", 44F);
            this.startButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(85)))), ((int)(((byte)(2)))));
            this.startButton.Location = new System.Drawing.Point(143, 428);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(300, 300);
            this.startButton.TabIndex = 35;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // roundControl4
            // 
            this.roundControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl4.BackgroundColor = System.Drawing.Color.White;
            this.roundControl4.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl4.BorderWidth = 0F;
            this.roundControl4.Location = new System.Drawing.Point(296, 210);
            this.roundControl4.Margin = new System.Windows.Forms.Padding(69, 160, 69, 160);
            this.roundControl4.Name = "roundControl4";
            this.roundControl4.Radius = 25;
            this.roundControl4.Size = new System.Drawing.Size(280, 195);
            this.roundControl4.TabIndex = 30;
            // 
            // roundControl3
            // 
            this.roundControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl3.BackgroundColor = System.Drawing.Color.White;
            this.roundControl3.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl3.BorderWidth = 0F;
            this.roundControl3.Location = new System.Drawing.Point(8, 210);
            this.roundControl3.Margin = new System.Windows.Forms.Padding(32, 58, 32, 58);
            this.roundControl3.Name = "roundControl3";
            this.roundControl3.Radius = 25;
            this.roundControl3.Size = new System.Drawing.Size(280, 195);
            this.roundControl3.TabIndex = 29;
            // 
            // roundControl2
            // 
            this.roundControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl2.BackgroundColor = System.Drawing.Color.White;
            this.roundControl2.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl2.BorderWidth = 0F;
            this.roundControl2.Location = new System.Drawing.Point(8, 88);
            this.roundControl2.Margin = new System.Windows.Forms.Padding(32, 60, 32, 60);
            this.roundControl2.Name = "roundControl2";
            this.roundControl2.Radius = 25;
            this.roundControl2.Size = new System.Drawing.Size(568, 118);
            this.roundControl2.TabIndex = 25;
            // 
            // roundControl1
            // 
            this.roundControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.roundControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(48)))), ((int)(((byte)(73)))));
            this.roundControl1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundControl1.BorderWidth = 0F;
            this.roundControl1.Location = new System.Drawing.Point(8, 9);
            this.roundControl1.Margin = new System.Windows.Forms.Padding(13, 22, 13, 22);
            this.roundControl1.Name = "roundControl1";
            this.roundControl1.Radius = 25;
            this.roundControl1.Size = new System.Drawing.Size(568, 173);
            this.roundControl1.TabIndex = 23;
            // 
            // pCellTrackBar
            // 
            this.pCellTrackBar.LargeChange = 10;
            this.pCellTrackBar.Location = new System.Drawing.Point(19, 800);
            this.pCellTrackBar.Maximum = 400;
            this.pCellTrackBar.Minimum = 200;
            this.pCellTrackBar.Name = "pCellTrackBar";
            this.pCellTrackBar.Size = new System.Drawing.Size(548, 45);
            this.pCellTrackBar.TabIndex = 40;
            this.pCellTrackBar.Value = 300;
            this.pCellTrackBar.Scroll += new System.EventHandler(this.pCellTrackBar_Scroll);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(22, 822);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 23);
            this.panel1.TabIndex = 41;
            // 
            // UserModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(584, 943);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pCellTrackBar);
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
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.roundControl2);
            this.Controls.Add(this.roundControl1);
            this.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "UserModeForm";
            this.ShowIcon = false;
            this.Text = "UserModeForm";
            this.Load += new System.EventHandler(this.UserModeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCellTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label flowrateTextLabel;
        private System.Windows.Forms.Label pCellTextLabel;
        private RoundControl roundControl4;
        private RoundControl roundControl3;
        private System.Windows.Forms.Panel operatingTimePanel;
        private RoundControl roundControl2;
        public System.Windows.Forms.Timer operatingTimer;
        public System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label operatingTimeLabel;
        private System.Windows.Forms.Label operatingTimeTextLabel;
        private RoundControl roundControl1;
        private System.Windows.Forms.Button adminModeButton;
        private System.Windows.Forms.Label pCellTargetLabel;
        private System.Windows.Forms.Label pCellTargetTextLabel;
        private RoundButton startButton;
        public System.Windows.Forms.Label pCellLabel;
        public System.Windows.Forms.Label flowrateLabel;
        private System.Windows.Forms.TrackBar pCellTrackBar;
        private System.Windows.Forms.Panel panel1;
    }
}