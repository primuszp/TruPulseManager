using System;
using System.Globalization;

namespace TruPulseManager
{
    public class HVMessage
    {
        #region Private Member Variables

        /// <summary>
        /// Measured Slope Distance Value (meters)
        /// </summary>
        private double sdistance;

        /// <summary>
        /// Calculated Horizontal Distance Value (meters)
        /// </summary>
        private double hdistance;

        /// <summary>
        /// Measured Azimuth Value (degrees)
        /// </summary>
        private double azimuth;

        /// <summary>
        /// Measured Inclination Value (degrees)
        /// </summary>
        private double inclination;

        /// <summary>
        /// Quality of Target (true = high, false = low)
        /// </summary>
        private bool highQualityTarget = false;

        #endregion

        public enum Mode { HD, INC, SD }

        #region Public Properties

        /// <summary>
        /// Measured Slope Distance Value (meters)
        /// </summary>
        public double SlopeDistance
        {
            get { return sdistance; }
            set { sdistance = value; }
        }

        /// <summary>
        /// Calculated Horizontal Distance Value (meters)
        /// </summary>
        public double HorizontalDistance
        {
            get { return hdistance; }
            set { hdistance = value; }
        }

        /// <summary>
        /// Measured Azimuth Value (degrees)
        /// </summary>
        public double Azimuth
        {
            get { return azimuth; }
            set { azimuth = value; }
        }

        /// <summary>
        /// Measured Inclination Value (degrees)
        /// </summary>
        public double Inclination
        {
            get { return inclination; }
            set { inclination = value; }
        }

        /// <summary>
        /// Quality of Target (true = high, false = low)
        /// </summary>
        public bool HighQualityTarget
        {
            get { return highQualityTarget; }
            set { highQualityTarget = value; }
        }

        #endregion

        /// <summary>
        /// Public Constructors
        /// </summary>
        /// <param name="sentence">TruPulse send sentence like NMEA</param>
        public HVMessage(string sentence)
        {
            try
            {
                HVInterpreter(sentence);
            }
            catch (FormatException e)
            {

            }
        }

        private void HVInterpreter(string sentence)
        {
            if (sentence.IndexOf('*') > 0)
            {
                sentence = sentence.Substring(0, sentence.IndexOf('*'));
            }

            //Split into an array of strings
            string[] split = sentence.Split(new Char[] { ',' });

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i] == "")
                {
                    split[i] = "0";
                }
            }

            //Calculated Horizontal Distance Meter
            hdistance = DistanceConvertToSI(split[2], split[3]);

            //Measured Azimuth Degree
            azimuth = double.Parse(split[4], CultureInfo.InvariantCulture);

            //Measured Inclination Degree
            inclination = double.Parse(split[6], CultureInfo.InvariantCulture);

            //Measured Slope Distance Meter
            sdistance = DistanceConvertToSI(split[8], split[9]);

            QualityTarget(sdistance);
        }

        /// <summary>
        /// Convert to measured values to SI units
        /// </summary>
        /// <param name="value">Measured Value</param>
        /// <param name="unit">Unit</param>
        /// <returns>Converted Value</returns>
        private double DistanceConvertToSI(string value, string unit)
        {
            switch (unit)
            {
                case "F": return (0.3048 * double.Parse(value, CultureInfo.InvariantCulture));
                    break;
                case "Y": return (0.9144 * double.Parse(value, CultureInfo.InvariantCulture));
                    break;
                case "M": return (1.0000 * double.Parse(value, CultureInfo.InvariantCulture));
                    break;
                default: return (0.0);
                    break;
            }
        }

        private void QualityTarget(double value)
        {
            double delta = 0.0;

            if ((Math.Abs(Math.Round(value, 1) - value)) == delta)
            {
                highQualityTarget = true;
            }
            else
            {
                highQualityTarget = false;
            }
        }
    }
}
