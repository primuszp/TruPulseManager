using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TruPulseManager
{
    public partial class PointForm : Form
    {
        #region Private Member Variables

        private HVMessage hvMessage = null;
        private MeasuredPoint measuredPoint = new MeasuredPoint();
        private KeyBoardForm keyboard = new KeyBoardForm();

        #endregion

        #region Public Properties

        public DrawingArea DrawingArea { get; set; }

        #endregion

        public PointForm()
        {
            InitializeComponent();
        }

        public PointForm(HVMessage hvMessage)
        {
            InitializeComponent();

            this.hvMessage = hvMessage;

            tBSlopeDistance.Text = hvMessage.SlopeDistance.ToString();
            tBHorizontalDistance.Text = hvMessage.HorizontalDistance.ToString();
            tBAltitudeAngle.Text = hvMessage.Inclination.ToString();
            tBAzimuth.Text = hvMessage.Azimuth.ToString();

            if (hvMessage.HighQualityTarget)
            {
                tBQualityTarget.Text = "High";
            }
            else
            {
                tBQualityTarget.Text = "Low";
            }
        }

        private void PointForm_Load(object sender, EventArgs e)
        {
            int index = Project.MeasurePoints.Count-1;

            nUpDownHeight.Value = Convert.ToDecimal(Project.MarkHeight);

            if (index == 0)
            {
                nUpDownID.Value = Project.StartPointID;
                Project.StartPointID++;
            }
            else
            {
                nUpDownID.Value = Convert.ToDecimal(Project.StartPointID);
                Project.StartPointID++;
            }
            CalcCoordinates();
        }

        private void nUpDownHeight_ValueChanged(object sender, EventArgs e)
        {
            CalcCoordinates();
        }

        private void CalcCoordinates()
        {
            measuredPoint.MeasuredValues = hvMessage;
            measuredPoint.MarkHeight = Convert.ToDouble(nUpDownHeight.Value) / 1000.0;
            measuredPoint.ID = Convert.ToInt32(nUpDownID.Value);
            measuredPoint.Code = tBCode.Text;
            measuredPoint.StationID = Convert.ToInt32(Project.Station.ID);
            measuredPoint.CalcCoordinates(Project.Station);

            SetTabPageCoordinates(measuredPoint);
        }

        private void SetTabPageCoordinates(MeasuredPoint measuredPoint)
        {
            lbEasting.Text = Math.Round(measuredPoint.Coordinates.X, 3).ToString("0.000");
            lbNorthing.Text = Math.Round(measuredPoint.Coordinates.Y, 3).ToString("0.000");
            lbElevation.Text = Math.Round(measuredPoint.Coordinates.Z, 3).ToString("0.000");
        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            CalcCoordinates();
            Project.MeasurePoints.Add(measuredPoint);
            Project.MarkHeight = Convert.ToDouble(nUpDownHeight.Value);

            DrawingArea.ReDraw();

            if (Project.Profile == Project.Section.Add || Project.Profile == Project.Section.Insert)
            {
                Project.CrossSection.Indices.Add(measuredPoint.ID);
            }

            this.Close();
        }

        private void tBCode_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBCode.Text;
            keyboard.ShowDialog();
            tBCode.Text = keyboard.CodeText;
        }

        private void nUpDownID_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBCode.Text;
            keyboard.ShowDialog();

            try
            {
                nUpDownID.Value = Convert.ToDecimal(keyboard.CodeText);
            }
            catch (FormatException)
            {
                MessageBox.Show(this, "Invalid Number Format!\nPlease type in a real number.", "TruPulseManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nUpDownHeight_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBCode.Text;
            keyboard.ShowDialog();

            try
            {
                nUpDownHeight.Value = Convert.ToDecimal(keyboard.CodeText);
            }
            catch(FormatException)
            {
                MessageBox.Show(this, "Invalid Number Format!\nPlease type in a real number.", "TruPulseManager", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
