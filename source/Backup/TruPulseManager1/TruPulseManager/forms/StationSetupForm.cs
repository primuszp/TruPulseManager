using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TruPulseManager
{
    public partial class StationSetupForm : Form
    {
        //public Station Station { get; set; }
        //public List<Station> Stations { get; set; }
        public MeasuredPoint MeasuredPoint { get; set; }
        //public List<MeasuredPoint> MeasuredPoints { get; set; }
        public bool PointSetup { get; set; }

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
                nUpDownID.Value = Convert.ToDecimal(MainForm.Station.ID);
                tBCode.Text = MainForm.Station.Code;
                tBEasting.Text = MainForm.Station.Coordinates.X.ToString("0.000");
                tBNorthing.Text = MainForm.Station.Coordinates.Y.ToString("0.000");
                tBElevation.Text = MainForm.Station.Coordinates.Z.ToString("0.000");
                nUpDownHeight.Value = Convert.ToDecimal(MainForm.Station.Height * 1000.0);
            }
        }

        private bool CheckID(int id)
        {
            foreach (MeasuredPoint item in MainForm.MeasuredPoints)
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
                MainForm.StationSetup = false;
            }

            if (!PointSetup && CheckID(station.ID))
            {
                MainForm.Station.ID = station.ID;
                MainForm.Station.Code = station.Code;
                MainForm.Station.Coordinates.X = station.Coordinates.X;
                MainForm.Station.Coordinates.Y = station.Coordinates.Y;
                MainForm.Station.Coordinates.Z = station.Coordinates.Z;
                MainForm.Station.Height = station.Height;
                MainForm.StationPoints.Add(station);

                MeasuredPoint measuredPoint = new MeasuredPoint(station.Coordinates, station.ID, station.Code, station.Height);
                MainForm.MeasuredPoints.Add(measuredPoint);

                PointSetup = false;
                this.Close();
            }

            if (PointSetup)
            {
                MainForm.Station.ID = station.ID;
                MainForm.Station.Code = station.Code;
                MainForm.Station.Coordinates.X = station.Coordinates.X;
                MainForm.Station.Coordinates.Y = station.Coordinates.Y;
                MainForm.Station.Coordinates.Z = station.Coordinates.Z;
                MainForm.Station.Height = station.Height;
                MainForm.StationPoints.Add(station);

                PointSetup = false;
                this.Close();
            }

            MeasuredPoint.DrawingArea.ReDraw();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            PointSetup = false;
            this.Close();
        }

        private void tBCode_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBCode.Text;
            keyboard.ShowDialog();
            tBCode.Text = keyboard.CodeText;
        }

        private void tBNorthing_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBNorthing.Text;
            keyboard.ShowDialog();
            tBNorthing.Text = keyboard.CodeText;
        }

        private void tBEasting_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBEasting.Text;
            keyboard.ShowDialog();
            tBEasting.Text = keyboard.CodeText;
        }

        private void tBElevation_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBElevation.Text;
            keyboard.ShowDialog();
            tBElevation.Text = keyboard.CodeText;
        }
    }
}
