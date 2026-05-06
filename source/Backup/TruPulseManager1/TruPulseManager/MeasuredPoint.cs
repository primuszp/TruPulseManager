using System;
using System.Windows.Forms;
using System.Drawing;

namespace TruPulseManager
{
    public class MeasuredPoint : IComparable
    {
        #region Private Member Variables

        private int screenX;
        private int screenY;
        private int mouseX;
        private int mouseY;

        private MouseButtons mouseButton = MouseButtons.None;
        private bool selected = false;
        private bool hover = false;

        private float width = 1.0f;
        private Color normalColor = Color.Black;
        private Color selectColor = Color.Green;

        #endregion

        #region Public Properties

        public Vector Coordinates { get; set; }
        public HVMessage MeasuredValues { get; set; }

        public int ID { get; set; }
        public int StationID { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
        public double MarkHeight { get; set; }
        public DateTime TimeStamp { get; set; }

        public static DrawingArea DrawingArea { get; set; }
        public Color Color { get; set; }

        #endregion 

        public MeasuredPoint()
        {
            Coordinates = new Vector();
            TimeStamp = DateTime.UtcNow;

            DrawingArea.MouseMove += new MouseEventHandler(this.MouseMove);
            DrawingArea.MouseDown += new MouseEventHandler(this.MouseDown);
            DrawingArea.MouseUp += new MouseEventHandler(this.MouseUp);

            Color = normalColor;
        }

        public MeasuredPoint(Vector coordinates, int id, string code, double markheight)
        {
            this.Coordinates = coordinates;
            this.ID = id;
            this.Code = code;
            this.MarkHeight = markheight;

            TimeStamp = DateTime.UtcNow;

            DrawingArea.MouseMove += new MouseEventHandler(this.MouseMove);
            DrawingArea.MouseDown += new MouseEventHandler(this.MouseDown);
            DrawingArea.MouseUp += new MouseEventHandler(this.MouseUp);

            Color = normalColor;
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

        private void ShowStationDialog()
        {
            MainForm.StationForm.MeasuredPoint = this;
            MainForm.StationForm.PointSetup = true;
            MainForm.StationForm.ShowDialog();
        }

        private int GetScreenX(double X, double ScreenX, double Zoom)
        {
            return ((int)(0.5 + (X - ScreenX) * Zoom));
        }

        private int GetScreenY(double Y, double ScreenY, double Zoom)
        {
            return ((int)(0.5 + (ScreenY - Y) * Zoom));
        }

        private double GetModellX(int MouseScreenX, double ScreenX, double Zoom)
        {
            return (ScreenX + MouseScreenX / Zoom);
        }

        private double GetModellY(int MouseScreenY, double ScreenY, double Zoom)
        {
            return (ScreenY - MouseScreenY / Zoom);
        }

        public void Draw(Graphics controlDC)
        {
            Pen penPoint = new Pen(Color, width);

            int sX = GetScreenX(Coordinates.X, DrawingArea.ScreenX, DrawingArea.Zoom);
            int sY = GetScreenY(Coordinates.Y, DrawingArea.ScreenY, DrawingArea.Zoom);

            if (selected)
            {
                controlDC.FillEllipse(Brushes.Red, sX, sY, 8, 8);
                controlDC.DrawEllipse(penPoint, sX, sY, 8, 8);
            }
            else
            {
                controlDC.FillEllipse(Brushes.Gray, sX, sY, 8, 8);
                controlDC.DrawEllipse(penPoint, sX, sY, 8, 8);
            }

            if (DrawingArea.Zoom > 5.0)
            {
                controlDC.DrawString(Code, new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.Black, sX + 8, sY - 8);
                controlDC.DrawString(ID.ToString(), new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.Black, sX + 8, sY + 4);
            }

            penPoint.Dispose();
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            mouseButton = MouseButtons.None;
        }

        private void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Middle)
            {
                if ((e.Button == MouseButtons.Left) && (selected == false) && (hover == true))
                {
                    selected = true;
                    ShowStationDialog();
                }
                else
                    if ((e.Button == MouseButtons.Left) && (selected == true) && (hover == true))
                    {
                        selected = false;
                        DrawingArea.ReDraw();
                    }
                    else
                    {
                        selected = false;
                        DrawingArea.ReDraw();
                    }
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;

            screenX = GetScreenX(Coordinates.X, DrawingArea.ScreenX, DrawingArea.Zoom);
            screenY = GetScreenY(Coordinates.Y, DrawingArea.ScreenY, DrawingArea.Zoom);


            if ((Math.Abs((screenX - (mouseX)) * DrawingArea.Zoom) < 8 * DrawingArea.Zoom) && (Math.Abs((screenY - (mouseY)) * DrawingArea.Zoom) < 8 * DrawingArea.Zoom))
            {
                hover = true;
            }
            else
            {
                hover = false;
            }
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
                //Az obj nem Vector típus, kivétel dobással jelezzük
                throw new ArgumentException("Csak MeasuredPoint típus hasonlítható össze!");
            }
        }
        #endregion
    }
}