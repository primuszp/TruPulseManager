using System;
using System.Drawing;

namespace TruPulseManager
{
    public class MeasuredPoint : IComparable
    {
        #region Private Member Variables

        private Color normalColor = Color.Black;
        private Color selectColor = Color.Green;

        #endregion

        #region Public Properties

        /// <summary>
        /// TruPulse Measured Values
        /// </summary>
        public HVMessage MeasuredValues { get; set; }

        /// <summary>
        /// Pointer to the Station Point
        /// </summary>
        public int StationID { get; set; }

        /// <summary>
        /// Point Coordinates (X,Y,Z)
        /// </summary>
        public Vector Coordinates { get; set; }

        /// <summary>
        /// Point ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Point Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Point Note
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// The Used Mark Height
        /// </summary>
        public double MarkHeight { get; set; }

        /// <summary>
        /// DateTime of The Measure
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// When The Point is Selected (true), anyway (false)
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// The Drawing Color
        /// </summary>
        public Color Color { get; set; }

        #endregion 

        #region Public Constructors

        public MeasuredPoint()
        {
            Coordinates = new Vector();
            TimeStamp = DateTime.UtcNow;
            Color = normalColor;
        }

        public MeasuredPoint(Vector coordinates, int id, string code, double markheight)
        {
            this.Coordinates = coordinates;
            this.ID = id;
            this.Code = code;
            this.MarkHeight = markheight;

            TimeStamp = DateTime.UtcNow;

            Color = normalColor;
        }

        #endregion

        public void ShowStationDialog()
        {
            MainForm.StationForm.MeasuredPoint = this;
            MainForm.StationForm.PointSetup = true;
            MainForm.StationForm.ShowDialog();
        }

        public void CalcCoordinates(Station station)
        {
            double hd = Math.Cos(AngleToRadian(MeasuredValues.Inclination)) * MeasuredValues.SlopeDistance;
            double ht = Math.Sin(AngleToRadian(MeasuredValues.Inclination)) * MeasuredValues.SlopeDistance;
            double dz = (station.Height + ht) - MarkHeight;

            Coordinates.X = station.Coordinates.X + hd * Math.Sin(AngleToRadian(MeasuredValues.Azimuth));
            Coordinates.Y = station.Coordinates.Y + hd * Math.Cos(AngleToRadian(MeasuredValues.Azimuth));
            Coordinates.Z = station.Coordinates.Z + dz;
        }

        private double AngleToRadian(double angle)
        {
            return ((Math.PI / 180.0) * angle);
        }

        #region IComparable Members

        public int CompareTo(MeasuredPoint other)
        {
            if (this.Coordinates.X < other.Coordinates.X)
            {
                return (-1);
            }

            if (this.Coordinates.X > other.Coordinates.X)
            {
                return (+1);
            }

            if (this.Coordinates.X == other.Coordinates.X)
            {
                if (this.Coordinates.Y < other.Coordinates.Y)
                {
                    return (-1);
                }
                if (this.Coordinates.Y > other.Coordinates.Y)
                {
                    return (+1);
                }
            }
            return (0);
        }

        public int CompareTo(Object obj)
        {
            if (obj is MeasuredPoint)
            {
                return CompareTo((MeasuredPoint)obj);
            }
            else
            {
                throw new ArgumentException("This is not MeasuredPoint Type!");
            }
        }
        #endregion
    }
}