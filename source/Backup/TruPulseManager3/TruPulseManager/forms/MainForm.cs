using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using ZedGraph;
using System.Runtime.Serialization.Formatters.Binary;

namespace TruPulseManager
{
    public partial class MainForm : Form
    {
        public enum Section { Add, Insert, Checked, None };
        public enum Mode { Fast, Slow };

        public static Project Project = new Project();
        public static Mode MeasureMode = Mode.Slow;

        #region Private Member Variables

        private Interpreter truPulse = new Interpreter();
        private string[] truPulseString;
        private string instring;

        LineItem myCurve = null;
        GraphPane myPane = null;

        public SerialPort SerialPort
        {
            get
            {
                return serialPort;
            }
            set
            {
                serialPort = value;
            }
        }
        public Interpreter TruPulse
        {
            get
            {
                return truPulse;
            }
            set
            {
                truPulse = value;
            }
        }

        #endregion

        #region Static Forms

        public static FileOpenSaveForm FileOpenSaveForm = new FileOpenSaveForm();
        public static SerialPortForm SerialForm = new SerialPortForm();
        public static BatteryBarForm BatteryForm = new BatteryBarForm();
        public static MeasureForm MeasureForm = new MeasureForm();
        public static StationSetupForm StationForm = new StationSetupForm();
        public static CompassForm CompassForm = new CompassForm();
        public static CrossSectionForm CrossSectionForm = new CrossSectionForm();

        #endregion

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
            TruPulse.HVReceived += new Interpreter.HVReceivedEventHandler(TruPulse_HVReceived);
            TruPulse.TruPulseReceived += new Interpreter.TruPulseReceivedEventHandler(TruPulse_TruPulseReceived);
        }

        #endregion

        public static void InitalizeProject()
        {
            Project.Clear();
            Project.Name = "Project";
            Project.Path = "Project.trp";
            Project.Station = new Station();
            Project.CrossSection = new CrossSection();
            Project.MarkHeight = 1700;
            Project.SectionDelta = 25;
            Project.StartPointID = 2000;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitalizeProject();
            StationForm.DrawingArea = drawingArea;
            fastStorePanel.DrawingArea = drawingArea;
            fastStorePanel.SerialPort = SerialPort;
            fastStorePanel.TruPulse = TruPulse;

            //MeasuredPoint myPoint;
            //        for (int i = 0; i < 10; i++)
            //        {
            //            myPoint = new MeasuredPoint();
            //            myPoint.ID = 100 + i;
            //            myPoint.Code = "AP";
            //            myPoint.Coordinates.X = i * 2;
            //            myPoint.Coordinates.Y = i;
            //            myPoint.Coordinates.Z = i;
            //            Project.MeasurePoints.Add(myPoint);
            //            Project.CrossSection.Indices.Add(100 + i);
            //        }
            //        Project.CrossSections.Add(new CrossSection(Project.CrossSection));

            //    drawingArea.ZoomAll();
        }

        private void drawingArea_SizeChanged(object sender, EventArgs e)
        {
            drawingArea.Initialize();
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(HandleTruPulse));
        }

        private void HandleTruPulse(object sender, EventArgs e)
        {
            string buffer = serialPort.ReadExisting();

            if (buffer != null)
            {
                if (buffer.StartsWith("$"))
                {
                    instring = buffer;
                }
                else
                {
                    instring += buffer;
                }
            }

            truPulseString = instring.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string item in truPulseString)
            {
                if ((item.StartsWith("$")) && (item.EndsWith("\r")))
                {
                    TruPulse.Parse(item.Trim('\r'));
                }
            }
        }

        private void TruPulse_HVReceived(HVMessage hv)
        {
            switch (MeasureMode)
            {
                case Mode.Fast:
                    {
                        if (Project.DataReception)
                        {
                            Project.DataReception = false;
                            fastStorePanel.CalcCoordinates(hv);
                        }
                    }
                    break;
                case Mode.Slow:
                    {
                        if (Project.DataReception)
                        {
                            Project.DataReception = false;
                            PointForm pointform = new PointForm(hv);
                            pointform.DrawingArea = drawingArea;
                            pointform.ShowDialog();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void TruPulse_TruPulseReceived(string sentence)
        {
            ;
        }

        private void toolStripButtonSerialPort_Click(object sender, EventArgs e)
        {
            SerialForm.SerialPort = SerialPort;
            SerialForm.TruPulse = TruPulse;
            SerialForm.ShowDialog();
        }

        private void toolStripButtonBatteryBar_Click(object sender, EventArgs e)
        {
            BatteryForm.SerialPort = SerialPort;
            BatteryForm.ShowDialog();
        }

        private void toolStripButtonMeasure_Click(object sender, EventArgs e)
        {
            MeasureForm.SerialPort = SerialPort;
            MeasureForm.TruPulse = TruPulse;
            MeasureForm.ShowDialog();
        }

        private void toolStripButtonStation_Click(object sender, EventArgs e)
        {
            //Nem a térképen lett kijelölve egy pont
            StationForm.PointSetup = false;
            StationForm.ShowDialog();
        }

        private void toolStripCompass_Click(object sender, EventArgs e)
        {
            CompassForm.SerialPort = SerialPort;
            CompassForm.TruPulse = TruPulse;
            CompassForm.ShowDialog();
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            SerialForm.Dispose();
            BatteryForm.Dispose();
            CompassForm.Dispose();
            MeasureForm.Dispose();
            StationForm.Dispose();
            CrossSectionForm.Dispose();
            FileOpenSaveForm.Dispose();
            this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }
        }

        private void toolStripButtonZoomIn_Click(object sender, EventArgs e)
        {
            drawingArea.PickZoomIn();
        }

        private void toolStripButtonZoomOut_Click(object sender, EventArgs e)
        {
            drawingArea.PickZoomOut();
        }

        private void toolStripButtonPan_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonPan.Checked)
            {
                toolStripButtonPan.Checked = true;
                drawingArea.PickPan = true;
            }
            else
            {
                toolStripButtonPan.Checked = false;
                drawingArea.PickPan = false;
            }
        }

        private void toolStripButtonCrossSection_Click(object sender, EventArgs e)
        {
            if (!toolStripButtonCrossSection.Checked)
            {
                toolStripButtonCrossSection.Checked = true;
                Project.Profile = Project.Section.Checked;

                CrossSectionForm.ShowDialog();
            }
            else
            {
                toolStripButtonCrossSection.Checked = false;

                if (Project.Profile == Project.Section.Add)
                {
                    Project.CrossSections.Add(new CrossSection(Project.CrossSection));
                    Project.Profile = Project.Section.None;
                }
                if (Project.Profile == Project.Section.Insert)
                {
                    Project.Profile = Project.Section.None;
                }
            }
        }

        private void toolStripButtonFile_Click(object sender, EventArgs e)
        {
            FileOpenSaveForm.DrawingArea = drawingArea;
            FileOpenSaveForm.ShowDialog();
        }

        #region TabPage Cross Sections

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            foreach (CrossSection item in Project.CrossSections)
            {
                lBSections.Items.Add(item.Section.ToString("00+00.00"));
            }
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            lBSections.Items.Clear();

            if (myPane != null)
            {
                myPane.CurveList.Clear();
                myPane.GraphObjList.Clear();
            }
            if (myCurve != null) myCurve.Clear();
        }


        private void lBSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myPane != null)
            {
                myPane.CurveList.Clear();
                myPane.GraphObjList.Clear();
            }
            if (myCurve != null) myCurve.Clear();

            GetSectionPoints(lBSections.SelectedIndex);
            zedGraphControl.Refresh();
        }

        private void GetSectionPoints(int index)
        {
            double[] x = null;
            double[] y = null;

            List<PointD> points = new List<PointD>();

            myPane = zedGraphControl.GraphPane;

            if (index >= 0)
            {
                x = new double[Project.CrossSections[index].Indices.Count];
                y = new double[Project.CrossSections[index].Indices.Count];

                List<MeasuredPoint> temp = new List<MeasuredPoint>();

                for (int i = 0; i < Project.CrossSections[index].Indices.Count; i++)
                {
                    int ptr = Project.GetMeasuredPoint(Project.CrossSections[index].Indices[i]);

                    if (ptr >= 0)
                    {
                        temp.Add(Project.MeasurePoints[ptr]);
                    }
                }

                temp.Sort();

                for (int i = 0; i < temp.Count; i++)
                {
                    x[i] = temp[i].Coordinates.X;
                    y[i] = temp[i].Coordinates.Z;
                }

                temp.Clear();

                if (x.Length > 0 && y.Length > 0)
                {
                    double xMin = GetMin(x);
                    double xMax = GetMax(x);

                    double yMin = GetMin(y);
                    double yMax = GetMax(y);

                    myPane.XAxis.Scale.Max = xMax;
                    myPane.YAxis.Scale.Max = yMax;
                    myPane.XAxis.Scale.Min = xMin;
                    myPane.YAxis.Scale.Min = yMin;

                    myPane.XAxis.Scale.MajorStep = (xMax - xMin) / 10.0;
                    myPane.YAxis.Scale.MajorStep = (yMax - yMin) / 10.0;

                    myPane.XAxis.Scale.MinorStep = 2.0;
                    myPane.YAxis.Scale.MinorStep = 2.0;

                    myCurve = myPane.AddCurve(Project.CrossSections[index].Section.ToString("00+00.00"), x, y, Color.Chocolate, SymbolType.Circle);
                    myCurve.Line.Width = 6.0F;

                    myCurve.Line.Fill = new Fill(Color.FromArgb(60, 190, 50), Color.ForestGreen, Color.Green);

                    myCurve.Symbol.Fill = new Fill(Color.Orange);
                    myCurve.Symbol.Size = 8.0F;
                }
            }
        }

        private void SortCoordinates(double[] x, double[] y)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < x[i + 1])
                {
                }
            }
        }

        private double GetMax(double[] items)
        {
            double max = double.MinValue;

            for (int i = 0; i < items.Length; i++)
            {
                if (max < items[i])
                {
                    max = items[i];
                }
            }
            return (max);
        }

        private double GetMin(double[] items)
        {
            double min = double.MaxValue;

            for (int i = 0; i < items.Length; i++)
            {
                if (min > items[i])
                {
                    min = items[i];
                }
            }
            return (min);
        }

        #endregion

        private void toolStripButtonZoomAll_Click(object sender, EventArgs e)
        {
            drawingArea.ZoomAll();
        }

        public static void Save(string FileName)
        {
            Stream stream = File.Open(FileName, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();

            binary.Serialize(stream, Project);
            stream.Close();
        }

        public static void Open(string FileName)
        {
            Stream stream = File.Open(FileName, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();

            Project = (Project)binary.Deserialize(stream);
            stream.Close();
        }

        private void drawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            tSLCoordinates.Text = "X=" + drawingArea.MouseX.ToString("0.000") + " " +"Y=" + drawingArea.MouseY.ToString("0.000");
        }
    }
}
