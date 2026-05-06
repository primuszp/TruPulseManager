namespace TruPulseManager
{
    partial class BatteryBarForm
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
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCharge = new System.Windows.Forms.Label();
            this.DeviceIndicator = new System.Windows.Forms.ProgressBar();
            this.MainsPower = new System.Windows.Forms.CheckBox();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gBDevice = new System.Windows.Forms.GroupBox();
            this.lbBattery = new System.Windows.Forms.Label();
            this.gBTruPulse = new System.Windows.Forms.GroupBox();
            this.TruPulseIndicator = new System.Windows.Forms.ProgressBar();
            this.lbChargeValue = new System.Windows.Forms.Label();
            this.lbStatusValue = new System.Windows.Forms.Label();
            this.btnReFresh = new System.Windows.Forms.Button();
            this.pBBattery = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBDevice.SuspendLayout();
            this.gBTruPulse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBBattery)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(37, 112);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(99, 17);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Battery status:";
            // 
            // lbCharge
            // 
            this.lbCharge.AutoSize = true;
            this.lbCharge.Location = new System.Drawing.Point(12, 84);
            this.lbCharge.Name = "lbCharge";
            this.lbCharge.Size = new System.Drawing.Size(124, 17);
            this.lbCharge.TabIndex = 9;
            this.lbCharge.Text = "Charge remaining:";
            // 
            // DeviceIndicator
            // 
            this.DeviceIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DeviceIndicator.Location = new System.Drawing.Point(15, 47);
            this.DeviceIndicator.Name = "DeviceIndicator";
            this.DeviceIndicator.Size = new System.Drawing.Size(305, 30);
            this.DeviceIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DeviceIndicator.TabIndex = 7;
            // 
            // MainsPower
            // 
            this.MainsPower.AutoCheck = false;
            this.MainsPower.AutoSize = true;
            this.MainsPower.Location = new System.Drawing.Point(15, 24);
            this.MainsPower.Name = "MainsPower";
            this.MainsPower.Size = new System.Drawing.Size(184, 21);
            this.MainsPower.TabIndex = 6;
            this.MainsPower.Text = "Running on Mains Power";
            this.MainsPower.ThreeState = true;
            this.MainsPower.UseVisualStyleBackColor = true;
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Interval = 1000;
            this.RefreshTimer.Tick += new System.EventHandler(this.RefreshTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 304);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gBTruPulse);
            this.tabPage1.Controls.Add(this.lbBattery);
            this.tabPage1.Controls.Add(this.gBDevice);
            this.tabPage1.Controls.Add(this.pBBattery);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gBDevice
            // 
            this.gBDevice.Controls.Add(this.lbStatusValue);
            this.gBDevice.Controls.Add(this.lbChargeValue);
            this.gBDevice.Controls.Add(this.MainsPower);
            this.gBDevice.Controls.Add(this.lbStatus);
            this.gBDevice.Controls.Add(this.DeviceIndicator);
            this.gBDevice.Controls.Add(this.lbCharge);
            this.gBDevice.Location = new System.Drawing.Point(11, 56);
            this.gBDevice.Name = "gBDevice";
            this.gBDevice.Size = new System.Drawing.Size(337, 138);
            this.gBDevice.TabIndex = 0;
            this.gBDevice.TabStop = false;
            this.gBDevice.Text = "Device";
            // 
            // lbBattery
            // 
            this.lbBattery.AutoSize = true;
            this.lbBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbBattery.Location = new System.Drawing.Point(58, 22);
            this.lbBattery.Name = "lbBattery";
            this.lbBattery.Size = new System.Drawing.Size(59, 13);
            this.lbBattery.TabIndex = 20;
            this.lbBattery.Text = "Battery Bar";
            // 
            // gBTruPulse
            // 
            this.gBTruPulse.Controls.Add(this.TruPulseIndicator);
            this.gBTruPulse.Location = new System.Drawing.Point(11, 196);
            this.gBTruPulse.Name = "gBTruPulse";
            this.gBTruPulse.Size = new System.Drawing.Size(337, 71);
            this.gBTruPulse.TabIndex = 12;
            this.gBTruPulse.TabStop = false;
            this.gBTruPulse.Text = "TruPulse";
            // 
            // TruPulseIndicator
            // 
            this.TruPulseIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TruPulseIndicator.Location = new System.Drawing.Point(15, 28);
            this.TruPulseIndicator.Name = "TruPulseIndicator";
            this.TruPulseIndicator.Size = new System.Drawing.Size(305, 30);
            this.TruPulseIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TruPulseIndicator.TabIndex = 7;
            // 
            // lbChargeValue
            // 
            this.lbChargeValue.AutoSize = true;
            this.lbChargeValue.Location = new System.Drawing.Point(142, 84);
            this.lbChargeValue.Name = "lbChargeValue";
            this.lbChargeValue.Size = new System.Drawing.Size(16, 17);
            this.lbChargeValue.TabIndex = 12;
            this.lbChargeValue.Text = "?";
            // 
            // lbStatusValue
            // 
            this.lbStatusValue.AutoSize = true;
            this.lbStatusValue.Location = new System.Drawing.Point(142, 112);
            this.lbStatusValue.Name = "lbStatusValue";
            this.lbStatusValue.Size = new System.Drawing.Size(16, 17);
            this.lbStatusValue.TabIndex = 13;
            this.lbStatusValue.Text = "?";
            // 
            // btnReFresh
            // 
            this.btnReFresh.Image = global::TruPulseManager.Properties.Resources.refresh;
            this.btnReFresh.Location = new System.Drawing.Point(236, 308);
            this.btnReFresh.Name = "btnReFresh";
            this.btnReFresh.Size = new System.Drawing.Size(51, 51);
            this.btnReFresh.TabIndex = 12;
            this.btnReFresh.UseVisualStyleBackColor = true;
            // 
            // pBBattery
            // 
            this.pBBattery.Image = global::TruPulseManager.Properties.Resources.battery;
            this.pBBattery.Location = new System.Drawing.Point(6, 6);
            this.pBBattery.Name = "pBBattery";
            this.pBBattery.Size = new System.Drawing.Size(45, 45);
            this.pBBattery.TabIndex = 19;
            this.pBBattery.TabStop = false;
            // 
            // BatteryBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 361);
            this.Controls.Add(this.btnReFresh);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BatteryBarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Battery Bar";
            this.Load += new System.EventHandler(this.BatteryBarForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gBDevice.ResumeLayout(false);
            this.gBDevice.PerformLayout();
            this.gBTruPulse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBBattery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbCharge;
        private System.Windows.Forms.ProgressBar DeviceIndicator;
        private System.Windows.Forms.CheckBox MainsPower;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gBDevice;
        private System.Windows.Forms.Label lbBattery;
        private System.Windows.Forms.PictureBox pBBattery;
        private System.Windows.Forms.GroupBox gBTruPulse;
        private System.Windows.Forms.ProgressBar TruPulseIndicator;
        private System.Windows.Forms.Button btnReFresh;
        private System.Windows.Forms.Label lbStatusValue;
        private System.Windows.Forms.Label lbChargeValue;
    }
}