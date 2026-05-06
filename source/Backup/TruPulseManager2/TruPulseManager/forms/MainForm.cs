using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using ZedGraph;

namespace TruPulseManager
{
    public partial class MainForm : Form
    {
        public enum Section { Add, Insert, Checked, None };

        #region Private Member Variables

        private static Interpreter truPulse = new Interpreter();
        private static List<MeasuredPoint> measuredPoints = new List<MeasuredPoint>();

        private static Station station = new Station();
        private static List<Station> stationPoints = new List<Station>();

        private static CrossSection crossSection = new CrossSection();
        private static List<CrossSection> crossSections = new List<CrossSection>();

        private static bool stationSetup = false;
        private static bool crossSectionChecked = false;

        private string[] truPulseString;
        private string instring;

        private static double sectionDelta = 25;
        private static int startPointID = 2000;
        private static double markHeight = 1700;

        public static bool FOGAD = false;

        LineItem myCurve = null;
        GraphPane myPane = null;

        #endregion

        #region Public Properties

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

        public static Interpreter TruPulse
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

        public static CrossSection CrossSection
        {
            get
            {
                return crossSection;
            }
            set
            {
                crossSection = value;
            }
        }

        public static List<MeasuredPoint> MeasuredPoints
        {
            get
            {
                return measuredPoints;
            }
            set
            {
                measuredPoints = value;
            }
        }

        public static List<Station> StationPoints
        {
            get
            {
                return stationPoints;
            }
            set
            {
                stationPoints = value;
            }
        }

        public static Station Station
        {
            get
            {
                return station;
            }
            set
            {
                station = value;
            }
        }

        public static bool StationSetup
        {
            get
            {
                return stationSetup;
            }
            set
            {
                stationSetup = value;
            }
        }

        public static bool CrossSectionChecked
        {
            get
            {
                return crossSectionChecked;
            }
            set
            {
                crossSectionChecked = value;
            }
        }

        public static List<CrossSection> CrossSections
        {
            get
            {
                return crossSections;
            }
            set
            {
                crossSections = value;
            }
        }

        public static double SectionDelta
        {
            get
            {
                return sectionDelta;
            }
            set
            {
                sectionDelta = value;
            }
        }

        public static int StartPointID
        {
            get
            {
                return startPointID;
            }
            set
            {
                startPointID = value;
            }
        }

        public static double MarkHeight
        {
            get
            {
                return markHeight;
            }
            set
            {
                markHeight = value;
            }
        }

        public static Section Profile { get; set; }

        #endregion

        #region Static Forms

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            drawingArea.Initialize();
            MeasuredPoint myPoint;

            if (openFileDialog != null)
            {
                openFileDialog.ShowDialog();

                if (openFileDialog.FileName != "")
                {

                    string filename = openFileDialog.FileName;

                    StreamReader myFile = File.OpenText(filename);

                    string buffer = null;
                    string[] split = null;

                    while ((buffer = myFile.ReadLine()) != null)
                    {
                        split = buffer.Split(new Char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                        myPoint = new MeasuredPoint();
                        myPoint.ID = Convert.ToInt32(split[0]);
                        myPoint.Coordinates.X = Convert.ToDouble(split[1]);
                        myPoint.Coordinates.Y = Convert.ToDouble(split[2]);
                        myPoint.Coordinates.Z = Convert.ToDouble(split[3]);
                        myPoint.Code = split[4];
                        MeasuredPoints.Add(myPoint);
                    }

                    myFile.Close();
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        myPoint = new MeasuredPoint();
                        myPoint.ID = 100 + i;
                        myPoint.Code = "AP";
                        myPoint.Coordinates.X = i * 2;
                        myPoint.Coordinates.Y = i;
                        myPoint.Coordinates.Z = i;
                        MeasuredPoints.Add(myPoint);
                        CrossSection.Indices.Add(100 + i);
                    }


                    CrossSections.Add(new CrossSection(CrossSection));
                }
                drawingArea.ZoomAll();
            }
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
            if (FOGAD)
            {
                FOGAD = false;
                PointForm pointform = new PointForm(hv);
                pointform.ShowDialog();
            }

        }

        private void TruPulse_TruPulseReceived(string sentence)
        {
            ;
        }

        private void toolStripButtonSerialPort_Click(object sender, EventArgs e)
        {
            SerialForm.SerialPort = serialPort;
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
                Profile = Section.Checked;

                CrossSectionForm.ShowDialog();
            }
            else
            {
                toolStripButtonCrossSection.Checked = false;

                if (Profile == Section.Add)
                {
                    CrossSections.Add(new CrossSection(CrossSection));
                    Profile = Section.None;
                }
                if (Profile == Section.Insert)
                {
                    Profile = Section.None;
                }
            }
        }

        private void toolStripButtonFile_Click(object sender, EventArgs e)
        {
            StreamWriter myFile = File.CreateText("pontok.txt");
            StreamWriter myFile2 = File.CreateText("stations.txt");

            foreach (MeasuredPoint item in MeasuredPoints)
            {
                myFile.WriteLine(item.ID.ToString() + '\t' + item.Coordinates.X.ToString("0.000") + '\t'+ item.Coordinates.Y.ToString("0.000") + '\t'+ item.Coordinates.Z.ToString("0.000") + '\t'+ item.Code + '\t'+ item.StationID + '\t');                
            }

            foreach (Station item in StationPoints)
            {
                myFile2.WriteLine(item.ID.ToString() + '\t' + item.Coordinates.X.ToString("0.000") + '\t' + item.Coordinates.Y.ToString("0.000") + '\t' + item.Coordinates.Z.ToString("0.000") + '\t' + item.Code + '\t');
            }

            myFile.Close();
            myFile2.Close();
        }

        #region TabPage Cross Sections

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            foreach (CrossSection item in CrossSections)
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
                x = new double[CrossSections[index].Indices.Count];
                y = new double[CrossSections[index].Indices.Count];

                List<MeasuredPoint> temp = new List<MeasuredPoint>();

                for (int i = 0; i < CrossSections[index].Indices.Count; i++)
                {
                    int ptr = GetMeasuredPoint(CrossSections[index].Indices[i]);

                    if (ptr >= 0)
                    {
                        temp.Add(MeasuredPoints[ptr]);
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

                    myPane.XAxis.Scale.Max = xMax + (xMax - xMin) / 10;
                    myPane.YAxis.Scale.Max = yMax + (yMax - yMin) / 10;
                    myPane.XAxis.Scale.Min = xMin - (xMax - xMin) / 10;
                    myPane.YAxis.Scale.Min = yMin - (yMax - yMin) / 10;

                    myPane.XAxis.Scale.MajorStep = (xMax - xMin) / 10;
                    myPane.YAxis.Scale.MajorStep = (yMax - yMin) / 10;

                    myPane.XAxis.Scale.MinorStep = 2;
                    myPane.YAxis.Scale.MinorStep = 2;

                    // Use green, with circle symbols
                    myCurve = myPane.AddCurve(CrossSections[index].Section.ToString("00+00.00"), x, y, Color.ForestGreen, SymbolType.Circle);
                    myCurve.Line.Width = 4.5F;
                    // Fill the area under the curve with a white-green gradient
                    myCurve.Line.Fill = new Fill(Color.White, Color.FromArgb(60, 190, 50), 90F);
                    // Make it a smooth line
                    //myCurve.Line.IsSmooth = true;
                    //myCurve.Line.SmoothTension = 0.6F;
                    // Fill the symbols with white
                    myCurve.Symbol.Fill = new Fill(Color.White);
                    myCurve.Symbol.Size = 10;
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

        private int GetMeasuredPoint(int id)
        {
            int count = 0;

            foreach (MeasuredPoint item in MeasuredPoints)
            {
                if (id == item.ID)
                {
                    return (count);
                }
                count++;
            }
            return (-1);
        }

        #endregion

        private void toolStripButtonZoomAll_Click(object sender, EventArgs e)
        {
            drawingArea.ZoomAll();
        }
    }
}
