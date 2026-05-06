namespace TruPulseManager
{
    partial class PointForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nUpDownID = new System.Windows.Forms.NumericUpDown();
            this.lbID = new System.Windows.Forms.Label();
            this.lbMeasuredPoint = new System.Windows.Forms.Label();
            this.tBCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.tBQualityTarget = new System.Windows.Forms.TextBox();
            this.lbQualityTarget = new System.Windows.Forms.Label();
            this.nUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.lbMarkHeight = new System.Windows.Forms.Label();
            this.tBAzimuth = new System.Windows.Forms.TextBox();
            this.lbAzimuth = new System.Windows.Forms.Label();
            this.tBAltitudeAngle = new System.Windows.Forms.TextBox();
            this.lbAltitudeAngle = new System.Windows.Forms.Label();
            this.tBHorizontalDistance = new System.Windows.Forms.TextBox();
            this.lbHorizintalDistance = new System.Windows.Forms.Label();
            this.tBSlopeDistance = new System.Windows.Forms.TextBox();
            this.lbSlopeDistance = new System.Windows.Forms.Label();
            this.pBFlag = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gBElevation = new System.Windows.Forms.GroupBox();
            this.lbElevation = new System.Windows.Forms.Label();
            this.gBEasting = new System.Windows.Forms.GroupBox();
            this.lbEasting = new System.Windows.Forms.Label();
            this.gBNorthing = new System.Windows.Forms.GroupBox();
            this.lbNorthing = new System.Windows.Forms.Label();
            this.buttonStore = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFlag)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gBElevation.SuspendLayout();
            this.gBEasting.SuspendLayout();
            this.gBNorthing.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 297);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.nUpDownID);
            this.tabPage1.Controls.Add(this.lbID);
            this.tabPage1.Controls.Add(this.lbMeasuredPoint);
            this.tabPage1.Controls.Add(this.tBCode);
            this.tabPage1.Controls.Add(this.lbCode);
            this.tabPage1.Controls.Add(this.tBQualityTarget);
            this.tabPage1.Controls.Add(this.lbQualityTarget);
            this.tabPage1.Controls.Add(this.nUpDownHeight);
            this.tabPage1.Controls.Add(this.lbMarkHeight);
            this.tabPage1.Controls.Add(this.tBAzimuth);
            this.tabPage1.Controls.Add(this.lbAzimuth);
            this.tabPage1.Controls.Add(this.tBAltitudeAngle);
            this.tabPage1.Controls.Add(this.lbAltitudeAngle);
            this.tabPage1.Controls.Add(this.tBHorizontalDistance);
            this.tabPage1.Controls.Add(this.lbHorizintalDistance);
            this.tabPage1.Controls.Add(this.tBSlopeDistance);
            this.tabPage1.Controls.Add(this.lbSlopeDistance);
            this.tabPage1.Controls.Add(this.pBFlag);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Measured Values";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // nUpDownID
            // 
            this.nUpDownID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nUpDownID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nUpDownID.Location = new System.Drawing.Point(166, 36);
            this.nUpDownID.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUpDownID.Name = "nUpDownID";
            this.nUpDownID.Size = new System.Drawing.Size(100, 26);
            this.nUpDownID.TabIndex = 1;
            this.nUpDownID.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nUpDownID.Click += new System.EventHandler(this.nUpDownID_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(135, 41);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 19;
            this.lbID.Text = "ID:";
            // 
            // lbMeasuredPoint
            // 
            this.lbMeasuredPoint.AutoSize = true;
            this.lbMeasuredPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbMeasuredPoint.Location = new System.Drawing.Point(57, 22);
            this.lbMeasuredPoint.Name = "lbMeasuredPoint";
            this.lbMeasuredPoint.Size = new System.Drawing.Size(81, 13);
            this.lbMeasuredPoint.TabIndex = 18;
            this.lbMeasuredPoint.Text = "Measured Point";
            // 
            // tBCode
            // 
            this.tBCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tBCode.Location = new System.Drawing.Point(166, 67);
            this.tBCode.Name = "tBCode";
            this.tBCode.Size = new System.Drawing.Size(100, 23);
            this.tBCode.TabIndex = 2;
            this.tBCode.Text = "NA";
            this.tBCode.Click += new System.EventHandler(this.tBCode_Click);
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(115, 70);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(45, 17);
            this.lbCode.TabIndex = 16;
            this.lbCode.Text = "Code:";
            // 
            // tBQualityTarget
            // 
            this.tBQualityTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBQualityTarget.Location = new System.Drawing.Point(166, 212);
            this.tBQualityTarget.Name = "tBQualityTarget";
            this.tBQualityTarget.ReadOnly = true;
            this.tBQualityTarget.Size = new System.Drawing.Size(100, 23);
            this.tBQualityTarget.TabIndex = 7;
            this.tBQualityTarget.Text = "NA";
            // 
            // lbQualityTarget
            // 
            this.lbQualityTarget.AutoSize = true;
            this.lbQualityTarget.Location = new System.Drawing.Point(58, 215);
            this.lbQualityTarget.Name = "lbQualityTarget";
            this.lbQualityTarget.Size = new System.Drawing.Size(102, 17);
            this.lbQualityTarget.TabIndex = 14;
            this.lbQualityTarget.Text = "Quality Target:";
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
            this.nUpDownHeight.Location = new System.Drawing.Point(166, 240);
            this.nUpDownHeight.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.nUpDownHeight.Name = "nUpDownHeight";
            this.nUpDownHeight.Size = new System.Drawing.Size(100, 26);
            this.nUpDownHeight.TabIndex = 8;
            this.nUpDownHeight.Value = new decimal(new int[] {
            1700,
            0,
            0,
            0});
            this.nUpDownHeight.ValueChanged += new System.EventHandler(this.nUpDownHeight_ValueChanged);
            this.nUpDownHeight.Click += new System.EventHandler(this.nUpDownHeight_Click);
            // 
            // lbMarkHeight
            // 
            this.lbMarkHeight.AutoSize = true;
            this.lbMarkHeight.Location = new System.Drawing.Point(72, 246);
            this.lbMarkHeight.Name = "lbMarkHeight";
            this.lbMarkHeight.Size = new System.Drawing.Size(88, 17);
            this.lbMarkHeight.TabIndex = 12;
            this.lbMarkHeight.Text = "Mark Height:";
            // 
            // tBAzimuth
            // 
            this.tBAzimuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBAzimuth.Location = new System.Drawing.Point(166, 183);
            this.tBAzimuth.Name = "tBAzimuth";
            this.tBAzimuth.ReadOnly = true;
            this.tBAzimuth.Size = new System.Drawing.Size(100, 23);
            this.tBAzimuth.TabIndex = 6;
            this.tBAzimuth.Text = "NA";
            // 
            // lbAzimuth
            // 
            this.lbAzimuth.AutoSize = true;
            this.lbAzimuth.Location = new System.Drawing.Point(58, 186);
            this.lbAzimuth.Name = "lbAzimuth";
            this.lbAzimuth.Size = new System.Drawing.Size(102, 17);
            this.lbAzimuth.TabIndex = 10;
            this.lbAzimuth.Text = "Azimuth Angle:";
            // 
            // tBAltitudeAngle
            // 
            this.tBAltitudeAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBAltitudeAngle.Location = new System.Drawing.Point(166, 154);
            this.tBAltitudeAngle.Name = "tBAltitudeAngle";
            this.tBAltitudeAngle.ReadOnly = true;
            this.tBAltitudeAngle.Size = new System.Drawing.Size(100, 23);
            this.tBAltitudeAngle.TabIndex = 5;
            this.tBAltitudeAngle.Text = "NA";
            // 
            // lbAltitudeAngle
            // 
            this.lbAltitudeAngle.AutoSize = true;
            this.lbAltitudeAngle.Location = new System.Drawing.Point(61, 157);
            this.lbAltitudeAngle.Name = "lbAltitudeAngle";
            this.lbAltitudeAngle.Size = new System.Drawing.Size(99, 17);
            this.lbAltitudeAngle.TabIndex = 8;
            this.lbAltitudeAngle.Text = "Altitude Angle:";
            // 
            // tBHorizontalDistance
            // 
            this.tBHorizontalDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBHorizontalDistance.Location = new System.Drawing.Point(166, 125);
            this.tBHorizontalDistance.Name = "tBHorizontalDistance";
            this.tBHorizontalDistance.ReadOnly = true;
            this.tBHorizontalDistance.Size = new System.Drawing.Size(100, 23);
            this.tBHorizontalDistance.TabIndex = 4;
            this.tBHorizontalDistance.Text = "NA";
            // 
            // lbHorizintalDistance
            // 
            this.lbHorizintalDistance.AutoSize = true;
            this.lbHorizintalDistance.Location = new System.Drawing.Point(25, 128);
            this.lbHorizintalDistance.Name = "lbHorizintalDistance";
            this.lbHorizintalDistance.Size = new System.Drawing.Size(135, 17);
            this.lbHorizintalDistance.TabIndex = 6;
            this.lbHorizintalDistance.Text = "Horizontal Distance:";
            // 
            // tBSlopeDistance
            // 
            this.tBSlopeDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBSlopeDistance.Location = new System.Drawing.Point(166, 96);
            this.tBSlopeDistance.Name = "tBSlopeDistance";
            this.tBSlopeDistance.ReadOnly = true;
            this.tBSlopeDistance.Size = new System.Drawing.Size(100, 23);
            this.tBSlopeDistance.TabIndex = 3;
            this.tBSlopeDistance.Text = "NA";
            // 
            // lbSlopeDistance
            // 
            this.lbSlopeDistance.AutoSize = true;
            this.lbSlopeDistance.Location = new System.Drawing.Point(53, 99);
            this.lbSlopeDistance.Name = "lbSlopeDistance";
            this.lbSlopeDistance.Size = new System.Drawing.Size(107, 17);
            this.lbSlopeDistance.TabIndex = 4;
            this.lbSlopeDistance.Text = "Slope Distance:";
            // 
            // pBFlag
            // 
            this.pBFlag.Image = global::TruPulseManager.Properties.Resources.greenflag;
            this.pBFlag.Location = new System.Drawing.Point(6, 6);
            this.pBFlag.Name = "pBFlag";
            this.pBFlag.Size = new System.Drawing.Size(45, 45);
            this.pBFlag.TabIndex = 3;
            this.pBFlag.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gBElevation);
            this.tabPage2.Controls.Add(this.gBEasting);
            this.tabPage2.Controls.Add(this.gBNorthing);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(284, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coordinates";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gBElevation
            // 
            this.gBElevation.Controls.Add(this.lbElevation);
            this.gBElevation.Location = new System.Drawing.Point(6, 178);
            this.gBElevation.Name = "gBElevation";
            this.gBElevation.Size = new System.Drawing.Size(270, 80);
            this.gBElevation.TabIndex = 1;
            this.gBElevation.TabStop = false;
            this.gBElevation.Text = "Elevation";
            // 
            // lbElevation
            // 
            this.lbElevation.AutoSize = true;
            this.lbElevation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbElevation.Location = new System.Drawing.Point(45, 32);
            this.lbElevation.Name = "lbElevation";
            this.lbElevation.Size = new System.Drawing.Size(92, 25);
            this.lbElevation.TabIndex = 1;
            this.lbElevation.Text = "Elevation";
            this.lbElevation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBEasting
            // 
            this.gBEasting.Controls.Add(this.lbEasting);
            this.gBEasting.Location = new System.Drawing.Point(6, 92);
            this.gBEasting.Name = "gBEasting";
            this.gBEasting.Size = new System.Drawing.Size(270, 80);
            this.gBEasting.TabIndex = 1;
            this.gBEasting.TabStop = false;
            this.gBEasting.Text = "Easting";
            // 
            // lbEasting
            // 
            this.lbEasting.AutoSize = true;
            this.lbEasting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbEasting.Location = new System.Drawing.Point(45, 31);
            this.lbEasting.Name = "lbEasting";
            this.lbEasting.Size = new System.Drawing.Size(77, 25);
            this.lbEasting.TabIndex = 1;
            this.lbEasting.Text = "Easting";
            this.lbEasting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBNorthing
            // 
            this.gBNorthing.Controls.Add(this.lbNorthing);
            this.gBNorthing.Location = new System.Drawing.Point(6, 5);
            this.gBNorthing.Name = "gBNorthing";
            this.gBNorthing.Size = new System.Drawing.Size(270, 80);
            this.gBNorthing.TabIndex = 0;
            this.gBNorthing.TabStop = false;
            this.gBNorthing.Text = "Northing";
            // 
            // lbNorthing
            // 
            this.lbNorthing.AutoSize = true;
            this.lbNorthing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbNorthing.Location = new System.Drawing.Point(45, 29);
            this.lbNorthing.Name = "lbNorthing";
            this.lbNorthing.Size = new System.Drawing.Size(85, 25);
            this.lbNorthing.TabIndex = 0;
            this.lbNorthing.Text = "Northing";
            this.lbNorthing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStore
            // 
            this.buttonStore.BackColor = System.Drawing.Color.LightGreen;
            this.buttonStore.FlatAppearance.BorderSize = 2;
            this.buttonStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStore.Location = new System.Drawing.Point(2, 305);
            this.buttonStore.Name = "buttonStore";
            this.buttonStore.Size = new System.Drawing.Size(140, 45);
            this.buttonStore.TabIndex = 9;
            this.buttonStore.Text = "&STORE";
            this.buttonStore.UseVisualStyleBackColor = false;
            this.buttonStore.Click += new System.EventHandler(this.buttonStore_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.FlatAppearance.BorderSize = 2;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCancel.Location = new System.Drawing.Point(151, 305);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(140, 45);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "&CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // PointForm
            // 
            this.AcceptButton = this.buttonStore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(294, 356);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonStore);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PointForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Measured Point";
            this.Load += new System.EventHandler(this.PointForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBFlag)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gBElevation.ResumeLayout(false);
            this.gBElevation.PerformLayout();
            this.gBEasting.ResumeLayout(false);
            this.gBEasting.PerformLayout();
            this.gBNorthing.ResumeLayout(false);
            this.gBNorthing.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox pBFlag;
        private System.Windows.Forms.Label lbSlopeDistance;
        private System.Windows.Forms.TextBox tBSlopeDistance;
        private System.Windows.Forms.TextBox tBHorizontalDistance;
        private System.Windows.Forms.Label lbHorizintalDistance;
        private System.Windows.Forms.TextBox tBAltitudeAngle;
        private System.Windows.Forms.Label lbAltitudeAngle;
        private System.Windows.Forms.TextBox tBAzimuth;
        private System.Windows.Forms.Label lbAzimuth;
        private System.Windows.Forms.Label lbMarkHeight;
        private System.Windows.Forms.NumericUpDown nUpDownHeight;
        private System.Windows.Forms.TextBox tBQualityTarget;
        private System.Windows.Forms.Label lbQualityTarget;
        private System.Windows.Forms.TextBox tBCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Button buttonStore;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lbMeasuredPoint;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.NumericUpDown nUpDownID;
        private System.Windows.Forms.GroupBox gBElevation;
        private System.Windows.Forms.GroupBox gBEasting;
        private System.Windows.Forms.GroupBox gBNorthing;
        private System.Windows.Forms.Label lbNorthing;
        private System.Windows.Forms.Label lbElevation;
        private System.Windows.Forms.Label lbEasting;
    }
}