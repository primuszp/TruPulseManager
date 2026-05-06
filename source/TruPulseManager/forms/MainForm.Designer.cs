namespace TruPulseManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tSLCoordinates = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.drawingArea = new TruPulseManager.DrawingArea();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lBSections = new System.Windows.Forms.ListBox();
            this.zedGraphControl = new ZedGraph.ZedGraphControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonConnecting = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBatteryBar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonZoomAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPan = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStation = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMeasure = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCrossSection = new System.Windows.Forms.ToolStripButton();
            this.toolStripCompass = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.fastStorePanel = new TruPulseManager.FastStore();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 4800;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(784, 350);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(784, 424);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLCoordinates});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // tSLCoordinates
            // 
            this.tSLCoordinates.Name = "tSLCoordinates";
            this.tSLCoordinates.Size = new System.Drawing.Size(30, 17);
            this.tSLCoordinates.Text = "X: Y:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(784, 350);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fastStorePanel);
            this.tabPage1.Controls.Add(this.drawingArea);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 321);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Survey Map";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // drawingArea
            // 
            this.drawingArea.BackColor = System.Drawing.Color.Black;
            this.drawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawingArea.Location = new System.Drawing.Point(3, 3);
            this.drawingArea.Margin = new System.Windows.Forms.Padding(4);
            this.drawingArea.MouseButton = System.Windows.Forms.MouseButtons.None;
            this.drawingArea.MouseScreenX = 0;
            this.drawingArea.MouseScreenY = 0;
            this.drawingArea.MouseX = 0;
            this.drawingArea.MouseY = 0;
            this.drawingArea.Name = "drawingArea";
            this.drawingArea.PickPan = false;
            this.drawingArea.ScreenX = -100;
            this.drawingArea.ScreenY = 100;
            this.drawingArea.Size = new System.Drawing.Size(770, 315);
            this.drawingArea.TabIndex = 1;
            this.drawingArea.Zoom = 1;
            this.drawingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawingArea_MouseMove);
            this.drawingArea.SizeChanged += new System.EventHandler(this.drawingArea_SizeChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cross Sections";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Leave += new System.EventHandler(this.tabPage2_Leave);
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.20513F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.79487F));
            this.tableLayoutPanel.Controls.Add(this.lBSections, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.zedGraphControl, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(770, 315);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // lBSections
            // 
            this.lBSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lBSections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lBSections.FormattingEnabled = true;
            this.lBSections.ItemHeight = 20;
            this.lBSections.Location = new System.Drawing.Point(3, 3);
            this.lBSections.Name = "lBSections";
            this.lBSections.Size = new System.Drawing.Size(172, 304);
            this.lBSections.TabIndex = 0;
            this.lBSections.SelectedIndexChanged += new System.EventHandler(this.lBSections_SelectedIndexChanged);
            // 
            // zedGraphControl
            // 
            this.zedGraphControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl.Location = new System.Drawing.Point(182, 4);
            this.zedGraphControl.Margin = new System.Windows.Forms.Padding(4);
            this.zedGraphControl.Name = "zedGraphControl";
            this.zedGraphControl.ScrollGrace = 0;
            this.zedGraphControl.ScrollMaxX = 0;
            this.zedGraphControl.ScrollMaxY = 0;
            this.zedGraphControl.ScrollMaxY2 = 0;
            this.zedGraphControl.ScrollMinX = 0;
            this.zedGraphControl.ScrollMinY = 0;
            this.zedGraphControl.ScrollMinY2 = 0;
            this.zedGraphControl.Size = new System.Drawing.Size(584, 307);
            this.zedGraphControl.TabIndex = 2;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonFile,
            this.toolStripSeparator1,
            this.toolStripButtonConnecting,
            this.toolStripButtonBatteryBar,
            this.toolStripSeparator2,
            this.toolStripButtonZoomIn,
            this.toolStripButtonZoomOut,
            this.toolStripButtonZoomAll,
            this.toolStripButtonPan,
            this.toolStripSeparator3,
            this.toolStripButtonStation,
            this.toolStripButtonMeasure,
            this.toolStripButtonCrossSection,
            this.toolStripCompass,
            this.toolStripSeparator4,
            this.toolStripButtonExit});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip.Size = new System.Drawing.Size(615, 52);
            this.toolStrip.TabIndex = 0;
            // 
            // toolStripButtonFile
            // 
            this.toolStripButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFile.Image = global::TruPulseManager.Properties.Resources.save;
            this.toolStripButtonFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFile.Name = "toolStripButtonFile";
            this.toolStripButtonFile.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonFile.Text = "File";
            this.toolStripButtonFile.Click += new System.EventHandler(this.toolStripButtonFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButtonConnecting
            // 
            this.toolStripButtonConnecting.AutoSize = false;
            this.toolStripButtonConnecting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonConnecting.Image = global::TruPulseManager.Properties.Resources.connecting;
            this.toolStripButtonConnecting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonConnecting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonConnecting.Name = "toolStripButtonConnecting";
            this.toolStripButtonConnecting.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonConnecting.Text = "Connecting";
            this.toolStripButtonConnecting.Click += new System.EventHandler(this.toolStripButtonSerialPort_Click);
            // 
            // toolStripButtonBatteryBar
            // 
            this.toolStripButtonBatteryBar.AutoSize = false;
            this.toolStripButtonBatteryBar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBatteryBar.Image = global::TruPulseManager.Properties.Resources.battery;
            this.toolStripButtonBatteryBar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonBatteryBar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBatteryBar.Name = "toolStripButtonBatteryBar";
            this.toolStripButtonBatteryBar.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonBatteryBar.Text = "Battery Bar";
            this.toolStripButtonBatteryBar.Click += new System.EventHandler(this.toolStripButtonBatteryBar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButtonZoomIn
            // 
            this.toolStripButtonZoomIn.AutoSize = false;
            this.toolStripButtonZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomIn.Image = global::TruPulseManager.Properties.Resources.zoomin;
            this.toolStripButtonZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomIn.Name = "toolStripButtonZoomIn";
            this.toolStripButtonZoomIn.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonZoomIn.Text = "Zoom In";
            this.toolStripButtonZoomIn.Click += new System.EventHandler(this.toolStripButtonZoomIn_Click);
            // 
            // toolStripButtonZoomOut
            // 
            this.toolStripButtonZoomOut.AutoSize = false;
            this.toolStripButtonZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomOut.Image = global::TruPulseManager.Properties.Resources.zoomout;
            this.toolStripButtonZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomOut.Name = "toolStripButtonZoomOut";
            this.toolStripButtonZoomOut.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonZoomOut.Text = "Zoom Out";
            this.toolStripButtonZoomOut.Click += new System.EventHandler(this.toolStripButtonZoomOut_Click);
            // 
            // toolStripButtonZoomAll
            // 
            this.toolStripButtonZoomAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonZoomAll.Image = global::TruPulseManager.Properties.Resources.zoomall;
            this.toolStripButtonZoomAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonZoomAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonZoomAll.Name = "toolStripButtonZoomAll";
            this.toolStripButtonZoomAll.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonZoomAll.Text = "Zoom All";
            this.toolStripButtonZoomAll.Click += new System.EventHandler(this.toolStripButtonZoomAll_Click);
            // 
            // toolStripButtonPan
            // 
            this.toolStripButtonPan.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripButtonPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPan.Image = global::TruPulseManager.Properties.Resources.pan;
            this.toolStripButtonPan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPan.Name = "toolStripButtonPan";
            this.toolStripButtonPan.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonPan.Text = "Pan";
            this.toolStripButtonPan.Click += new System.EventHandler(this.toolStripButtonPan_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButtonStation
            // 
            this.toolStripButtonStation.AutoSize = false;
            this.toolStripButtonStation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStation.Image = global::TruPulseManager.Properties.Resources.stationsetup;
            this.toolStripButtonStation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStation.Name = "toolStripButtonStation";
            this.toolStripButtonStation.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonStation.Text = "Station Setup";
            this.toolStripButtonStation.Click += new System.EventHandler(this.toolStripButtonStation_Click);
            // 
            // toolStripButtonMeasure
            // 
            this.toolStripButtonMeasure.AutoSize = false;
            this.toolStripButtonMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMeasure.Image = global::TruPulseManager.Properties.Resources.measure;
            this.toolStripButtonMeasure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMeasure.Name = "toolStripButtonMeasure";
            this.toolStripButtonMeasure.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonMeasure.Text = "Survey";
            this.toolStripButtonMeasure.Click += new System.EventHandler(this.toolStripButtonMeasure_Click);
            // 
            // toolStripButtonCrossSection
            // 
            this.toolStripButtonCrossSection.AutoSize = false;
            this.toolStripButtonCrossSection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCrossSection.Image = global::TruPulseManager.Properties.Resources.crosssection;
            this.toolStripButtonCrossSection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonCrossSection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCrossSection.Name = "toolStripButtonCrossSection";
            this.toolStripButtonCrossSection.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonCrossSection.Text = "Cross Section";
            this.toolStripButtonCrossSection.Click += new System.EventHandler(this.toolStripButtonCrossSection_Click);
            // 
            // toolStripCompass
            // 
            this.toolStripCompass.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCompass.Image = global::TruPulseManager.Properties.Resources.compass;
            this.toolStripCompass.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripCompass.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCompass.Name = "toolStripCompass";
            this.toolStripCompass.Size = new System.Drawing.Size(49, 49);
            this.toolStripCompass.Text = "Compass";
            this.toolStripCompass.Click += new System.EventHandler(this.toolStripCompass_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.AutoSize = false;
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = global::TruPulseManager.Properties.Resources.exit;
            this.toolStripButtonExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(49, 49);
            this.toolStripButtonExit.Text = "Exit";
            this.toolStripButtonExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // fastStorePanel
            // 
            this.fastStorePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fastStorePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fastStorePanel.Code = null;
            this.fastStorePanel.DrawingArea = null;
            this.fastStorePanel.Location = new System.Drawing.Point(519, 7);
            this.fastStorePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fastStorePanel.MarkHeight = 0;
            this.fastStorePanel.Name = "fastStorePanel";
            this.fastStorePanel.SerialPort = null;
            this.fastStorePanel.Size = new System.Drawing.Size(250, 250);
            this.fastStorePanel.TabIndex = 2;
            this.fastStorePanel.TruPulse = null;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 424);
            this.Controls.Add(this.toolStripContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocket Surveyor v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DrawingArea drawingArea;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonConnecting;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomIn;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomOut;
        private System.Windows.Forms.ToolStripButton toolStripButtonPan;
        private System.Windows.Forms.ToolStripButton toolStripButtonStation;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonBatteryBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonMeasure;
        private System.Windows.Forms.ToolStripButton toolStripButtonCrossSection;
        private System.Windows.Forms.ToolStripButton toolStripButtonFile;
        private System.Windows.Forms.ToolStripButton toolStripCompass;
        private System.Windows.Forms.ListBox lBSections;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private ZedGraph.ZedGraphControl zedGraphControl;
        private System.Windows.Forms.ToolStripButton toolStripButtonZoomAll;
        private System.Windows.Forms.ToolStripStatusLabel tSLCoordinates;
        private System.Windows.Forms.StatusStrip statusStrip;
        private FastStore fastStore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private FastStore fastStorePanel;

    }
}

