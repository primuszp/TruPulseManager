namespace TruPulseManager
{
    partial class CrossSectionForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.tBSection = new System.Windows.Forms.TextBox();
            this.gBoxCrossSections = new System.Windows.Forms.GroupBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lBoxCrossSection = new System.Windows.Forms.ListBox();
            this.lbCrossSection = new System.Windows.Forms.Label();
            this.pBCrossSection = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gBoxCrossSections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCrossSection)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(2, 2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 354);
            this.tabControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCancel);
            this.tabPage1.Controls.Add(this.tBSection);
            this.tabPage1.Controls.Add(this.gBoxCrossSections);
            this.tabPage1.Controls.Add(this.lbCrossSection);
            this.tabPage1.Controls.Add(this.pBCrossSection);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 325);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(166, 284);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tBSection
            // 
            this.tBSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBSection.Location = new System.Drawing.Point(6, 284);
            this.tBSection.Name = "tBSection";
            this.tBSection.Size = new System.Drawing.Size(154, 29);
            this.tBSection.TabIndex = 4;
            this.tBSection.Click += new System.EventHandler(this.tBSection_Click);
            // 
            // gBoxCrossSections
            // 
            this.gBoxCrossSections.Controls.Add(this.btnInsert);
            this.gBoxCrossSections.Controls.Add(this.btnDel);
            this.gBoxCrossSections.Controls.Add(this.btnNew);
            this.gBoxCrossSections.Controls.Add(this.lBoxCrossSection);
            this.gBoxCrossSections.Location = new System.Drawing.Point(6, 58);
            this.gBoxCrossSections.Name = "gBoxCrossSections";
            this.gBoxCrossSections.Size = new System.Drawing.Size(272, 215);
            this.gBoxCrossSections.TabIndex = 21;
            this.gBoxCrossSections.TabStop = false;
            this.gBoxCrossSections.Text = "Cross Sections";
            // 
            // btnInsert
            // 
            this.btnInsert.Enabled = false;
            this.btnInsert.Image = global::TruPulseManager.Properties.Resources.insert;
            this.btnInsert.Location = new System.Drawing.Point(160, 159);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(50, 50);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDel
            // 
            this.btnDel.Image = global::TruPulseManager.Properties.Resources.delete;
            this.btnDel.Location = new System.Drawing.Point(216, 159);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 50);
            this.btnDel.TabIndex = 3;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::TruPulseManager.Properties.Resources.newcrosssection;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(6, 159);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(148, 50);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "&New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lBoxCrossSection
            // 
            this.lBoxCrossSection.FormattingEnabled = true;
            this.lBoxCrossSection.ItemHeight = 16;
            this.lBoxCrossSection.Location = new System.Drawing.Point(6, 22);
            this.lBoxCrossSection.Name = "lBoxCrossSection";
            this.lBoxCrossSection.ScrollAlwaysVisible = true;
            this.lBoxCrossSection.Size = new System.Drawing.Size(260, 132);
            this.lBoxCrossSection.TabIndex = 0;
            this.lBoxCrossSection.SelectedIndexChanged += new System.EventHandler(this.lBoxCrossSection_SelectedIndexChanged);
            // 
            // lbCrossSection
            // 
            this.lbCrossSection.AutoSize = true;
            this.lbCrossSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbCrossSection.Location = new System.Drawing.Point(57, 22);
            this.lbCrossSection.Name = "lbCrossSection";
            this.lbCrossSection.Size = new System.Drawing.Size(72, 13);
            this.lbCrossSection.TabIndex = 18;
            this.lbCrossSection.Text = "Cross Section";
            // 
            // pBCrossSection
            // 
            this.pBCrossSection.Image = global::TruPulseManager.Properties.Resources.crosssection;
            this.pBCrossSection.Location = new System.Drawing.Point(6, 6);
            this.pBCrossSection.Name = "pBCrossSection";
            this.pBCrossSection.Size = new System.Drawing.Size(45, 45);
            this.pBCrossSection.TabIndex = 3;
            this.pBCrossSection.TabStop = false;
            // 
            // CrossSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(294, 356);
            this.Controls.Add(this.tabControl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CrossSectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross Section";
            this.Load += new System.EventHandler(this.CrossSectionForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrossSectionForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gBoxCrossSections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBCrossSection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gBoxCrossSections;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lbCrossSection;
        private System.Windows.Forms.PictureBox pBCrossSection;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox lBoxCrossSection;
        private System.Windows.Forms.TextBox tBSection;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
    }
}