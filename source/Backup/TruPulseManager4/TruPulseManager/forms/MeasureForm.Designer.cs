namespace TruPulseManager
{
    partial class MeasureForm
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
            this.tCMeasure = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lBCommand = new System.Windows.Forms.ListBox();
            this.lCommand = new System.Windows.Forms.Label();
            this.cBTargetMode = new System.Windows.Forms.ComboBox();
            this.lbTargetMode = new System.Windows.Forms.Label();
            this.lbMeasure = new System.Windows.Forms.Label();
            this.pBMeasure = new System.Windows.Forms.PictureBox();
            this.cBMeasurementMode = new System.Windows.Forms.ComboBox();
            this.lbMeasurement = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gBAngleUnits = new System.Windows.Forms.GroupBox();
            this.rBPercent = new System.Windows.Forms.RadioButton();
            this.rBDegrees = new System.Windows.Forms.RadioButton();
            this.gBDistanceUnit = new System.Windows.Forms.GroupBox();
            this.rBFeet = new System.Windows.Forms.RadioButton();
            this.rBYards = new System.Windows.Forms.RadioButton();
            this.rBMeters = new System.Windows.Forms.RadioButton();
            this.buttonMeasure = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tCMeasure.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMeasure)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gBAngleUnits.SuspendLayout();
            this.gBDistanceUnit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tCMeasure
            // 
            this.tCMeasure.Controls.Add(this.tabPage1);
            this.tCMeasure.Controls.Add(this.tabPage2);
            this.tCMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tCMeasure.Location = new System.Drawing.Point(3, 3);
            this.tCMeasure.Name = "tCMeasure";
            this.tCMeasure.SelectedIndex = 0;
            this.tCMeasure.Size = new System.Drawing.Size(288, 228);
            this.tCMeasure.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lBCommand);
            this.tabPage1.Controls.Add(this.lCommand);
            this.tabPage1.Controls.Add(this.cBTargetMode);
            this.tabPage1.Controls.Add(this.lbTargetMode);
            this.tabPage1.Controls.Add(this.lbMeasure);
            this.tabPage1.Controls.Add(this.pBMeasure);
            this.tabPage1.Controls.Add(this.cBMeasurementMode);
            this.tabPage1.Controls.Add(this.lbMeasurement);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(280, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lBCommand
            // 
            this.lBCommand.FormattingEnabled = true;
            this.lBCommand.ItemHeight = 16;
            this.lBCommand.Location = new System.Drawing.Point(84, 156);
            this.lBCommand.Name = "lBCommand";
            this.lBCommand.ScrollAlwaysVisible = true;
            this.lBCommand.Size = new System.Drawing.Size(190, 36);
            this.lBCommand.TabIndex = 3;
            // 
            // lCommand
            // 
            this.lCommand.AutoSize = true;
            this.lCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCommand.Location = new System.Drawing.Point(6, 159);
            this.lCommand.Name = "lCommand";
            this.lCommand.Size = new System.Drawing.Size(75, 17);
            this.lCommand.TabIndex = 6;
            this.lCommand.Text = "Command:";
            this.lCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBTargetMode
            // 
            this.cBTargetMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTargetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBTargetMode.FormattingEnabled = true;
            this.cBTargetMode.Items.AddRange(new object[] {
            "Normal",
            "Continuous",
            "Closest",
            "Farthest",
            "Filter"});
            this.cBTargetMode.Location = new System.Drawing.Point(6, 128);
            this.cBTargetMode.Name = "cBTargetMode";
            this.cBTargetMode.Size = new System.Drawing.Size(269, 24);
            this.cBTargetMode.TabIndex = 2;
            this.cBTargetMode.SelectedIndexChanged += new System.EventHandler(this.cBTargetMode_SelectedIndexChanged);
            // 
            // lbTargetMode
            // 
            this.lbTargetMode.AutoSize = true;
            this.lbTargetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTargetMode.Location = new System.Drawing.Point(6, 108);
            this.lbTargetMode.Name = "lbTargetMode";
            this.lbTargetMode.Size = new System.Drawing.Size(93, 17);
            this.lbTargetMode.TabIndex = 4;
            this.lbTargetMode.Text = "Target Mode:";
            // 
            // lbMeasure
            // 
            this.lbMeasure.AutoSize = true;
            this.lbMeasure.Location = new System.Drawing.Point(60, 24);
            this.lbMeasure.Name = "lbMeasure";
            this.lbMeasure.Size = new System.Drawing.Size(52, 17);
            this.lbMeasure.TabIndex = 3;
            this.lbMeasure.Text = "Survey";
            // 
            // pBMeasure
            // 
            this.pBMeasure.Image = global::TruPulseManager.Properties.Resources.measure;
            this.pBMeasure.Location = new System.Drawing.Point(9, 6);
            this.pBMeasure.Name = "pBMeasure";
            this.pBMeasure.Size = new System.Drawing.Size(45, 45);
            this.pBMeasure.TabIndex = 2;
            this.pBMeasure.TabStop = false;
            // 
            // cBMeasurementMode
            // 
            this.cBMeasurementMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMeasurementMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBMeasurementMode.FormattingEnabled = true;
            this.cBMeasurementMode.Items.AddRange(new object[] {
            "Horizontal Distance",
            "Vertical Distance",
            "Slope Distance",
            "Inclination",
            "Height",
            "Azimuth"});
            this.cBMeasurementMode.Location = new System.Drawing.Point(5, 81);
            this.cBMeasurementMode.Name = "cBMeasurementMode";
            this.cBMeasurementMode.Size = new System.Drawing.Size(269, 24);
            this.cBMeasurementMode.TabIndex = 1;
            this.cBMeasurementMode.SelectedIndexChanged += new System.EventHandler(this.cBMeasurementMode_SelectedIndexChanged);
            // 
            // lbMeasurement
            // 
            this.lbMeasurement.AutoSize = true;
            this.lbMeasurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMeasurement.Location = new System.Drawing.Point(6, 61);
            this.lbMeasurement.Name = "lbMeasurement";
            this.lbMeasurement.Size = new System.Drawing.Size(137, 17);
            this.lbMeasurement.TabIndex = 0;
            this.lbMeasurement.Text = "Measurement Mode:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gBAngleUnits);
            this.tabPage2.Controls.Add(this.gBDistanceUnit);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(280, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Units";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gBAngleUnits
            // 
            this.gBAngleUnits.Controls.Add(this.rBPercent);
            this.gBAngleUnits.Controls.Add(this.rBDegrees);
            this.gBAngleUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBAngleUnits.Location = new System.Drawing.Point(6, 117);
            this.gBAngleUnits.Name = "gBAngleUnits";
            this.gBAngleUnits.Size = new System.Drawing.Size(268, 71);
            this.gBAngleUnits.TabIndex = 3;
            this.gBAngleUnits.TabStop = false;
            this.gBAngleUnits.Text = "Angle Units";
            // 
            // rBPercent
            // 
            this.rBPercent.AutoSize = true;
            this.rBPercent.Location = new System.Drawing.Point(153, 42);
            this.rBPercent.Name = "rBPercent";
            this.rBPercent.Size = new System.Drawing.Size(75, 21);
            this.rBPercent.TabIndex = 1;
            this.rBPercent.Text = "Percent";
            this.rBPercent.UseVisualStyleBackColor = true;
            this.rBPercent.CheckedChanged += new System.EventHandler(this.rBPercent_CheckedChanged);
            // 
            // rBDegrees
            // 
            this.rBDegrees.AutoSize = true;
            this.rBDegrees.Checked = true;
            this.rBDegrees.Location = new System.Drawing.Point(153, 19);
            this.rBDegrees.Name = "rBDegrees";
            this.rBDegrees.Size = new System.Drawing.Size(80, 21);
            this.rBDegrees.TabIndex = 0;
            this.rBDegrees.TabStop = true;
            this.rBDegrees.Text = "Degrees";
            this.rBDegrees.UseVisualStyleBackColor = true;
            this.rBDegrees.CheckedChanged += new System.EventHandler(this.rBDegrees_CheckedChanged);
            // 
            // gBDistanceUnit
            // 
            this.gBDistanceUnit.Controls.Add(this.rBFeet);
            this.gBDistanceUnit.Controls.Add(this.rBYards);
            this.gBDistanceUnit.Controls.Add(this.rBMeters);
            this.gBDistanceUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gBDistanceUnit.Location = new System.Drawing.Point(6, 10);
            this.gBDistanceUnit.Name = "gBDistanceUnit";
            this.gBDistanceUnit.Size = new System.Drawing.Size(268, 96);
            this.gBDistanceUnit.TabIndex = 0;
            this.gBDistanceUnit.TabStop = false;
            this.gBDistanceUnit.Text = "Distance Units";
            // 
            // rBFeet
            // 
            this.rBFeet.AutoSize = true;
            this.rBFeet.Location = new System.Drawing.Point(153, 65);
            this.rBFeet.Name = "rBFeet";
            this.rBFeet.Size = new System.Drawing.Size(54, 21);
            this.rBFeet.TabIndex = 2;
            this.rBFeet.Text = "Feet";
            this.rBFeet.UseVisualStyleBackColor = true;
            this.rBFeet.CheckedChanged += new System.EventHandler(this.rBFeet_CheckedChanged);
            // 
            // rBYards
            // 
            this.rBYards.AutoSize = true;
            this.rBYards.Location = new System.Drawing.Point(153, 42);
            this.rBYards.Name = "rBYards";
            this.rBYards.Size = new System.Drawing.Size(63, 21);
            this.rBYards.TabIndex = 1;
            this.rBYards.Text = "Yards";
            this.rBYards.UseVisualStyleBackColor = true;
            this.rBYards.CheckedChanged += new System.EventHandler(this.rBYards_CheckedChanged);
            // 
            // rBMeters
            // 
            this.rBMeters.AutoSize = true;
            this.rBMeters.Checked = true;
            this.rBMeters.Location = new System.Drawing.Point(153, 19);
            this.rBMeters.Name = "rBMeters";
            this.rBMeters.Size = new System.Drawing.Size(69, 21);
            this.rBMeters.TabIndex = 0;
            this.rBMeters.TabStop = true;
            this.rBMeters.Text = "Meters";
            this.rBMeters.UseVisualStyleBackColor = true;
            this.rBMeters.CheckedChanged += new System.EventHandler(this.rBMeters_CheckedChanged);
            // 
            // buttonMeasure
            // 
            this.buttonMeasure.BackColor = System.Drawing.Color.LightGreen;
            this.buttonMeasure.FlatAppearance.BorderSize = 2;
            this.buttonMeasure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMeasure.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMeasure.Location = new System.Drawing.Point(3, 235);
            this.buttonMeasure.Name = "buttonMeasure";
            this.buttonMeasure.Size = new System.Drawing.Size(140, 57);
            this.buttonMeasure.TabIndex = 3;
            this.buttonMeasure.Text = "&MEASURE";
            this.buttonMeasure.UseVisualStyleBackColor = false;
            this.buttonMeasure.Click += new System.EventHandler(this.bNMeasure_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(149, 235);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 57);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "&CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.bNCancel_Click);
            // 
            // MeasureForm
            // 
            this.AcceptButton = this.buttonMeasure;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 296);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonMeasure);
            this.Controls.Add(this.tCMeasure);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MeasureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.MeasureForm_Load);
            this.tCMeasure.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMeasure)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gBAngleUnits.ResumeLayout(false);
            this.gBAngleUnits.PerformLayout();
            this.gBDistanceUnit.ResumeLayout(false);
            this.gBDistanceUnit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tCMeasure;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cBMeasurementMode;
        private System.Windows.Forms.Label lbMeasurement;
        private System.Windows.Forms.PictureBox pBMeasure;
        private System.Windows.Forms.Label lbMeasure;
        private System.Windows.Forms.ComboBox cBTargetMode;
        private System.Windows.Forms.Label lbTargetMode;
        private System.Windows.Forms.GroupBox gBDistanceUnit;
        private System.Windows.Forms.RadioButton rBFeet;
        private System.Windows.Forms.RadioButton rBYards;
        private System.Windows.Forms.RadioButton rBMeters;
        private System.Windows.Forms.GroupBox gBAngleUnits;
        private System.Windows.Forms.RadioButton rBPercent;
        private System.Windows.Forms.RadioButton rBDegrees;
        private System.Windows.Forms.Button buttonMeasure;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lCommand;
        private System.Windows.Forms.ListBox lBCommand;
    }
}