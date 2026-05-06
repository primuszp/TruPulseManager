using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TruPulseManager
{
    public partial class StationSetupForm : Form
    {
        public MeasuredPoint MeasuredPoint { get; set; }
        public bool PointSetup { get; set; }
        public DrawingArea DrawingArea { get; set; }
        
        private KeyBoardForm keyboard = new KeyBoardForm();

        public StationSetupForm()
        {
            InitializeComponent();
            PointSetup = false;
        }

        public StationSetupForm(MeasuredPoint measuredPoint)
        {
            InitializeComponent();

            this.MeasuredPoint = measuredPoint; 
            
            PointSetup = true;
        }

        private void StationSetupForm_Load(object sender, EventArgs e)
        {
            if (PointSetup)
            {
                nUpDownID.Value = Convert.ToDecimal(MeasuredPoint.ID);
                tBCode.Text = MeasuredPoint.Code;
                tBEasting.Text = MeasuredPoint.Coordinates.X.ToString("0.000");
                tBNorthing.Text = MeasuredPoint.Coordinates.Y.ToString("0.000");
                tBElevation.Text = MeasuredPoint.Coordinates.Z.ToString("0.000");
                //nUpDownHeight.Value = Convert.ToDecimal(MeasuredPoint.MarkHeight * 1000.0);
            }
            else
            {
                nUpDownID.Value = Convert.ToDecimal(Project.Station.ID);
                tBCode.Text = Project.Station.Code;
                tBEasting.Text = Project.Station.Coordinates.X.ToString("0.000");
                tBNorthing.Text = Project.Station.Coordinates.Y.ToString("0.000");
                tBElevation.Text = Project.Station.Coordinates.Z.ToString("0.000");
                nUpDownHeight.Value = Convert.ToDecimal(Project.Station.Height * 1000.0);
            }
        }

        private bool CheckID(int id)
        {
            foreach (MeasuredPoint item in Project.MeasurePoints)
            {
                if (id == item.ID)
                {
                    MessageBox.Show(this, "The ID exists already!\nPlease type in a other ID.", "TruPulseManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return (false);
                }
            }
            return (true);
        }

        private void buttonStation_Click(object sender, System.EventArgs e)
        {
            Station station = new Station();

            try
            {
                station.ID = Convert.ToInt32(nUpDownID.Value);
                station.Code = tBCode.Text;
                station.Coordinates.X = Convert.ToDouble(tBEasting.Text);
                station.Coordinates.Y = Convert.ToDouble(tBNorthing.Text);
                station.Coordinates.Z = Convert.ToDouble(tBElevation.Text);
                station.Height = Convert.ToDouble(nUpDownHeight.Value) / 1000.0;
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid Number Format!\nPlease type in a real number.", "TruPulseManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Project.StationSetup = false;
            }

            if (!PointSetup && CheckID(station.ID))
            {
                Project.Station.ID = station.ID;
                Project.Station.Code = station.Code;
                Project.Station.Coordinates.X = station.Coordinates.X;
                Project.Station.Coordinates.Y = station.Coordinates.Y;
                Project.Station.Coordinates.Z = station.Coordinates.Z;
                Project.Station.Height = station.Height;
                Project.StationPoints.Add(station);

                MeasuredPoint measuredPoint = new MeasuredPoint(station.Coordinates, station.ID, station.Code, station.Height);
                Project.MeasurePoints.Add(measuredPoint);

                PointSetup = false;
                this.Close();
            }

            if (PointSetup)
            {
                Project.Station.ID = station.ID;
                Project.Station.Code = station.Code;
                Project.Station.Coordinates.X = station.Coordinates.X;
                Project.Station.Coordinates.Y = station.Coordinates.Y;
                Project.Station.Coordinates.Z = station.Coordinates.Z;
                Project.Station.Height = station.Height;
                Project.StationPoints.Add(station);

                PointSetup = false;
                this.Close();
            }
            DrawingArea.ReDraw();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            PointSetup = false;
            this.Close();
        }

        private void tBCode_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(tBCode, false);
        }

        private void tBNorthing_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(tBNorthing, true);
        }

        private void tBEasting_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(tBEasting, true);
        }

        private void tBElevation_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(tBElevation, true);
        }

        private void ShowKeyBoard(TextBox textBox, bool numeric)
        {
            keyboard.Numeric = numeric;
            keyboard.CodeText = textBox.Text;
            keyboard.ShowDialog();
            textBox.Text = keyboard.CodeText;
        }
    }
}
