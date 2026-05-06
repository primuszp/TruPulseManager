namespace TruPulseManager
{
    partial class StationSetupForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonStation = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nUpDownID = new System.Windows.Forms.NumericUpDown();
            this.lbID = new System.Windows.Forms.Label();
            this.lbStationSetup = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.nUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.lbStationHeight = new System.Windows.Forms.Label();
            this.tBElevation = new System.Windows.Forms.TextBox();
            this.lbElevation = new System.Windows.Forms.Label();
            this.tBEasting = new System.Windows.Forms.TextBox();
            this.lbEasting = new System.Windows.Forms.Label();
            this.tBNorthing = new System.Windows.Forms.TextBox();
            this.lbNorthing = new System.Windows.Forms.Label();
            this.pBStation = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStation)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(152, 307);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 45);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonStation
            // 
            this.buttonStation.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStation.FlatAppearance.BorderSize = 2;
            this.buttonStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStation.Location = new System.Drawing.Point(2, 307);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.Size = new System.Drawing.Size(140, 45);
            this.buttonStation.TabIndex = 4;
            this.buttonStation.Text = "STATION";
            this.buttonStation.UseVisualStyleBackColor = false;
            this.buttonStation.Click += new System.EventHandler(this.buttonStation_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 300);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nUpDownID);
            this.tabPage1.Controls.Add(this.lbID);
            this.tabPage1.Controls.Add(this.lbStationSetup);
            this.tabPage1.Controls.Add(this.tBCode);
            this.tabPage1.Controls.Add(this.lbCode);
            this.tabPage1.Controls.Add(this.nUpDownHeight);
            this.tabPage1.Controls.Add(this.lbStationHeight);
            this.tabPage1.Controls.Add(this.tBElevation);
            this.tabPage1.Controls.Add(this.lbElevation);
            this.tabPage1.Controls.Add(this.tBEasting);
            this.tabPage1.Controls.Add(this.lbEasting);
            this.tabPage1.Controls.Add(this.tBNorthing);
            this.tabPage1.Controls.Add(this.lbNorthing);
            this.tabPage1.Controls.Add(this.pBStation);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 271);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nUpDownID
            // 
            this.nUpDownID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUpDownID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nUpDownID.Location = new System.Drawing.Point(166, 76);
            this.nUpDownID.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nUpDownID.Name = "nUpDownID";
            this.nUpDownID.Size = new System.Drawing.Size(100, 26);
            this.nUpDownID.TabIndex = 20;
            this.nUpDownID.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(135, 81);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 19;
            this.lbID.Text = "ID:";
            // 
            // lbStationSetup
            // 
            this.lbStationSetup.AutoSize = true;
            this.lbStationSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbStationSetup.Location = new System.Drawing.Point(57, 22);
            this.lbStationSetup.Name = "lbStationSetup";
            this.lbStationSetup.Size = new System.Drawing.Size(71, 13);
            this.lbStationSetup.TabIndex = 18;
            this.lbStationSetup.Text = "Station Setup";
            // 
            // tBCode
            // 
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tBCode.Location = new System.Drawing.Point(166, 108);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(100, 23);
            this.tBCode.TabIndex = 17;
            this.tBCode.Text = "NA";
            this.tBCode.Click += new System.EventHandler(this.tBCode_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(115, 111);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(45, 17);
            this.lbCode.TabIndex = 16;
            this.lbCode.Text = "Code:";
            // 
            // nUpDownHeight
            // 
            this.nUpDownHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUpDownHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nUpDownHeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUpDownHeight.Location = new System.Drawing.Point(166, 224);
            this.nUpDownHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nUpDownHeight.Name = "nUpDownHeight";
            this.nUpDownHeight.Size = new System.Drawing.Size(100, 26);
            this.nUpDownHeight.TabIndex = 13;
            this.nUpDownHeight.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            // 
            // lbStationHeight
            // 
            this.lbStationHeight.AutoSize = true;
            this.lbStationHeight.Location = new System.Drawing.Point(59, 229);
            this.lbStationHeight.Name = "lbStationHeight";
            this.lbStationHeight.Size = new System.Drawing.Size(101, 17);
            this.lbStationHeight.TabIndex = 12;
            this.lbStationHeight.Text = "Station Height:";
            // 
            // tBElevation
            // 
            this.tBElevation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBElevation.Location = new System.Drawing.Point(166, 195);
            this.tBElevation.Name = "tBElevation";
            this.tBElevation.Size = new System.Drawing.Size(100, 23);
            this.tBElevation.TabIndex = 9;
            this.tBElevation.Text = "NA";
            this.tBElevation.Click += new System.EventHandler(this.tBElevation_Click);
            // 
            // lbElevation
            // 
            this.lbElevation.AutoSize = true;
            this.lbElevation.Location = new System.Drawing.Point(94, 198);
            this.lbElevation.Name = "lbElevation";
            this.lbElevation.Size = new System.Drawing.Size(66, 17);
            this.lbElevation.TabIndex = 8;
            this.lbElevation.Text = "Elevation";
            // 
            // tBEasting
            // 
            this.tBEasting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBEasting.Location = new System.Drawing.Point(166, 166);
            this.tBEasting.Name = "tBEasting";
            this.tBEasting.Size = new System.Drawing.Size(100, 23);
            this.tBEasting.TabIndex = 7;
            this.tBEasting.Text = "NA";
            this.tBEasting.Click += new System.EventHandler(this.tBEasting_Click);
            // 
            // lbEasting
            // 
            this.lbEasting.AutoSize = true;
            this.lbEasting.Location = new System.Drawing.Point(101, 169);
            this.lbEasting.Name = "lbEasting";
            this.lbEasting.Size = new System.Drawing.Size(59, 17);
            this.lbEasting.TabIndex = 6;
            this.lbEasting.Text = "Easting:";
            // 
            // tBNorthing
            // 
            this.tBNorthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBNorthing.Location = new System.Drawing.Point(166, 137);
            this.tBNorthing.Name = "tBNorthing";
            this.tBNorthing.Size = new System.Drawing.Size(100, 23);
            this.tBNorthing.TabIndex = 5;
            this.tBNorthing.Text = "NA";
            this.tBNorthing.Click += new System.EventHandler(this.tBNorthing_Click);
            // 
            // lbNorthing
            // 
            this.lbNorthing.AutoSize = true;
            this.lbNorthing.Location = new System.Drawing.Point(94, 140);
            this.lbNorthing.Name = "lbNorthing";
            this.lbNorthing.Size = new System.Drawing.Size(66, 17);
            this.lbNorthing.TabIndex = 4;
            this.lbNorthing.Text = "Northing:";
            // 
            // pBStation
            // 
            this.pBStation.Image = global::TruPulseManager.Properties.Resources.stationsetup;
            this.pBStation.Location = new System.Drawing.Point(6, 6);
            this.pBStation.Name = "pBStation";
            this.pBStation.Size = new System.Drawing.Size(45, 45);
            this.pBStation.TabIndex = 3;
            this.pBStation.TabStop = false;
            // 
            // StationSetupForm
            // 
            this.AcceptButton = this.buttonStation;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 356);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStation);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StationSetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Station Setup";
            this.Load += new System.EventHandler(this.StationSetupForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBStation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonStation;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.NumericUpDown nUpDownID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbStationSetup;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.NumericUpDown nUpDownHeight;
        private System.Windows.Forms.Label lbStationHeight;
        private System.Windows.Forms.TextBox tBElevation;
        private System.Windows.Forms.Label lbElevation;
        private System.Windows.Forms.TextBox tBEasting;
        private System.Windows.Forms.Label lbEasting;
        private System.Windows.Forms.TextBox tBNorthing;
        private System.Windows.Forms.Label lbNorthing;
        private System.Windows.Forms.PictureBox pBStation;
    }
}