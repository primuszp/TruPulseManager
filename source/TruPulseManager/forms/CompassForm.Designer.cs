namespace TruPulseManager
{
    partial class CompassForm
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
            this.slidingScale = new TB.Instruments.SlidingScale();
            this.tCGeneral = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnMeasure = new System.Windows.Forms.Button();
            this.lbDeltaDegree = new System.Windows.Forms.Label();
            this.lbCompass = new System.Windows.Forms.Label();
            this.pBCompass = new System.Windows.Forms.PictureBox();
            this.tCGeneral.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompass)).BeginInit();
            this.SuspendLayout();
            // 
            // slidingScale
            // 
            this.slidingScale.BackColor = System.Drawing.Color.White;
            this.slidingScale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.slidingScale.ForeColor = System.Drawing.Color.Black;
            this.slidingScale.Location = new System.Drawing.Point(6, 86);
            this.slidingScale.Name = "slidingScale";
            this.slidingScale.NeedleColor = System.Drawing.Color.Firebrick;
            this.slidingScale.Size = new System.Drawing.Size(270, 40);
            this.slidingScale.TabIndex = 0;
            this.slidingScale.Value = 90;
            // 
            // tCGeneral
            // 
            this.tCGeneral.Controls.Add(this.tabPage1);
            this.tCGeneral.Location = new System.Drawing.Point(2, 2);
            this.tCGeneral.Name = "tCGeneral";
            this.tCGeneral.SelectedIndex = 0;
            this.tCGeneral.Size = new System.Drawing.Size(290, 239);
            this.tCGeneral.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnStop);
            this.tabPage1.Controls.Add(this.btnMeasure);
            this.tabPage1.Controls.Add(this.lbDeltaDegree);
            this.tabPage1.Controls.Add(this.lbCompass);
            this.tabPage1.Controls.Add(this.slidingScale);
            this.tabPage1.Controls.Add(this.pBCompass);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(282, 213);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(201, 173);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "&Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnMeasure
            // 
            this.btnMeasure.Location = new System.Drawing.Point(6, 173);
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(75, 34);
            this.btnMeasure.TabIndex = 3;
            this.btnMeasure.Text = "&Measure";
            this.btnMeasure.UseVisualStyleBackColor = true;
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // lbDeltaDegree
            // 
            this.lbDeltaDegree.AutoSize = true;
            this.lbDeltaDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDeltaDegree.Location = new System.Drawing.Point(108, 139);
            this.lbDeltaDegree.Name = "lbDeltaDegree";
            this.lbDeltaDegree.Size = new System.Drawing.Size(63, 24);
            this.lbDeltaDegree.TabIndex = 2;
            this.lbDeltaDegree.Text = "Delta:";
            // 
            // lbCompass
            // 
            this.lbCompass.AutoSize = true;
            this.lbCompass.Location = new System.Drawing.Point(57, 23);
            this.lbCompass.Name = "lbCompass";
            this.lbCompass.Size = new System.Drawing.Size(82, 13);
            this.lbCompass.TabIndex = 1;
            this.lbCompass.Text = "Digital Compass";
            // 
            // pBCompass
            // 
            this.pBCompass.Image = global::TruPulseManager.Properties.Resources.compass;
            this.pBCompass.Location = new System.Drawing.Point(6, 6);
            this.pBCompass.Name = "pBCompass";
            this.pBCompass.Size = new System.Drawing.Size(45, 45);
            this.pBCompass.TabIndex = 0;
            this.pBCompass.TabStop = false;
            // 
            // CompassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 241);
            this.Controls.Add(this.tCGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compass";
            this.Load += new System.EventHandler(this.Compass_Load);
            this.tCGeneral.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCompass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TB.Instruments.SlidingScale slidingScale;
        private System.Windows.Forms.TabControl tCGeneral;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbCompass;
        private System.Windows.Forms.PictureBox pBCompass;
        private System.Windows.Forms.Label lbDeltaDegree;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnMeasure;
    }
}