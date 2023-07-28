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
            this.timeLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.globalTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            // desktopPanel
            // 
            this.desktopPanel.Location = new System.Drawing.Point(0, 42);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(583, 943);
            this.desktopPanel.TabIndex = 24;
            // 
            // globalTimer
            // 
            this.globalTimer.Tick += new System.EventHandler(this.globalTimer_Tick);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(583, 42);
            this.topPanel.TabIndex = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(584, 985);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Bahnschrift", 20F);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 7, 7);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biomedical Microsystems Laboratory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer globalTimer;
        private System.Windows.Forms.Panel topPanel;
        public System.Windows.Forms.Panel desktopPanel;
    }
}

