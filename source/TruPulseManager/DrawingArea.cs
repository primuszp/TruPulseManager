using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace TruPulseManager
{
    public partial class DrawingArea : UserControl
    {
        #region Private Member Variables

        private Graphics controlDC;
        private Image controlBitmap;

        private double zoom = 1.0;
        private double screenX = 0.0;
        private double screenY = 0.0;
        private double screenDownX = 0.0;
        private double screenDownY = 0.0;

        public double mouseX = 0.0;
        public double mouseY = 0.0;
        private double mouseDownX = 0.0;
        private double mouseDownY = 0.0;

        private int mouseScreenX = 0;
        private int mouseScreenY = 0;

        private MouseButtons mouseButton = MouseButtons.None;

        private bool pickPan;
        private double scale;

        #endregion

        #region Public Properties

        public double MouseX
        {
            get { return mouseX; }
            set { mouseX = value; }
        }

        public double MouseY
        {
            get { return mouseY; }
            set { mouseY = value; }
        }

        public double ScreenX
        {
            get { return screenX; }
            set { screenX = value; }
        }

        public MouseButtons MouseButton
        {
            get { return mouseButton; }
            set { mouseButton = value; }
        }

        public int MouseScreenY
        {
            get { return mouseScreenY; }
            set { mouseScreenY = value; }
        }

        public int MouseScreenX
        {
            get { return mouseScreenX; }
            set { mouseScreenX = value; }
        }

        public double ScreenY
        {
            get { return screenY; }
            set { screenY = value; }
        }

        public double Zoom
        {
            get { return zoom; }
            set { zoom = value; }
        }

        public bool PickPan
        {
            get { return pickPan; }
            set { pickPan = value; }
        }

        #endregion

        #region Constructors

        public DrawingArea()
        {
            InitializeComponent();
        }

        #endregion

        public void Initialize()
        {
            if (controlBitmap != null)
            {
                controlBitmap.Dispose();
            }
            if (this.Width > 0 && this.Height > 0)
            {
                controlBitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
                controlDC = Graphics.FromImage(controlBitmap);

                controlDC.InterpolationMode = InterpolationMode.Low;
                controlDC.CompositingQuality = CompositingQuality.HighSpeed;
                controlDC.SmoothingMode = SmoothingMode.AntiAlias;

                ZoomAll();
            }
        }

        private void RefreshControl()
        {
            Graphics windowDC = this.CreateGraphics();
            windowDC.DrawImage(controlBitmap, 0, 0);
            windowDC.Dispose();
        }

        private void DrawingArea_Resize(object sender, EventArgs e)
        {
            Initialize();
        }

        public void ReDraw()
        {
            controlDC.Clear(BackColor);

            foreach (MeasuredPoint item in Project.MeasurePoints)
            {
                Draw(item);
            }

            DrawScale();

            controlDC.DrawImage(controlBitmap, 0, 0);

            RefreshControl();
        }

        private void DrawStation(Station Station)
        {
            if (Station != null)
            {
                int sX = GetScreenX(Station.Coordinates.X, ScreenX, Zoom);
                int sY = GetScreenY(Station.Coordinates.Y, ScreenY, Zoom);

                controlDC.FillEllipse(Brushes.Yellow, sX - 2, sY - 2, 12, 12);
                controlDC.DrawEllipse(Pens.Red, sX - 2, sY - 2, 12, 12);
                controlDC.FillEllipse(Brushes.Green, sX, sY, 8, 8);
            }
        }

        private void DrawScale()
        {
            using(StringFormat mFormat = new StringFormat())
            using (Font myFont = new Font(FontFamily.GenericSansSerif, 10.0f, FontStyle.Bold))
            {
                mFormat.Alignment = StringAlignment.Center;
                mFormat.LineAlignment = StringAlignment.Center;

                //100 px hány cm
                scale = (100 / Zoom) * 100; ;

                controlDC.FillRectangle(Brushes.White, 3, this.Size.Height - 17, 4, 14);
                controlDC.FillRectangle(Brushes.White, 103, this.Size.Height - 17, 4, 14);
                controlDC.FillRectangle(Brushes.White, 4, this.Size.Height - 12, 100, 4);

                controlDC.DrawLine(Pens.Black, 5, this.Size.Height - 10, 105, this.Size.Height - 10);
                controlDC.DrawLine(Pens.Black, 5, this.Size.Height - 15, 5, this.Size.Height - 5);
                controlDC.DrawLine(Pens.Black, 105, this.Size.Height - 15, 105, this.Size.Height - 5);

                if (scale > 100000)
                {
                    controlDC.DrawString((scale / 100000).ToString("0.00") + " km", myFont, Brushes.White, 60, this.Size.Height - 20, mFormat);
                }
                else
                    if (scale > 100)
                    {
                        controlDC.DrawString((scale / 100).ToString("0.00") + " m", myFont, Brushes.White, 60, this.Size.Height - 20, mFormat);
                    }
                    else
                    {
                        controlDC.DrawString(scale.ToString("0.00") + " cm", myFont, Brushes.White, 60, this.Size.Height - 20, mFormat);
                    }
            }
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.Low;
            e.Graphics.CompositingQuality = CompositingQuality.HighSpeed;
            e.Graphics.SmoothingMode = SmoothingMode.HighSpeed;

            if (controlBitmap != null)
            {
                RefreshControl();
            }
        }

        private void DrawingArea_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            double zoom_p = Zoom;

            if (mouseButton == MouseButtons.None)
            {
                if (e.Delta > 0)
                {
                    zoom *= 1.2;
                }
                else
                {
                    zoom /= 1.2;
                }

                screenX = mouseX - (mouseX - screenX) * (zoom_p / Zoom);
                screenY = mouseY + (screenY - mouseY) * (zoom_p / Zoom);

                ReDraw();
            }
        }

        private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseButton == MouseButtons.None)
            {
                mouseScreenX = e.X;
                mouseScreenY = e.Y;
                mouseX = screenX + e.X / zoom;
                mouseY = screenY - e.Y / zoom;
            }
            else if (mouseButton == MouseButtons.Middle || PickPan)
            {
                screenX = mouseDownX - e.X / zoom;
                screenY = mouseDownY + e.Y / zoom;
                ReDraw();
            }
        }

        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            mouseButton = e.Button;
            screenDownX = mouseX;
            screenDownY = mouseY;
            mouseDownX = mouseX;
            mouseDownY = mouseY;

            ShowStationDialog();
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            mouseButton = MouseButtons.None;
        }

        #region Public Methods Zoom Functions

        public void PickZoomIn()
        {
            double zoom_p = zoom;

            zoom *= 1.2;

            screenX = mouseX - (mouseX - screenX) * (zoom_p / zoom);
            screenY = mouseY + (screenY - mouseY) * (zoom_p / zoom);

            ReDraw();
        }

        public void PickZoomOut()
        {
            double zoom_p = zoom;

            zoom /= 1.2;

            screenX = mouseX - (mouseX - screenX) * (zoom_p / zoom);
            screenY = mouseY + (screenY - mouseY) * (zoom_p / zoom);

            ReDraw();
        }

        public void ZoomAll()
        {
            double minX = double.MaxValue;
            double maxX = double.MinValue;
            double minY = double.MaxValue;
            double maxY = double.MinValue;

            double deltaX = 1.0;
            double deltaY = 1.0;

            if (Project.MeasurePoints.Count > 1)
            {
                foreach (MeasuredPoint item in Project.MeasurePoints)
                {
                    if (minX > item.Coordinates.X)
                    {
                        minX = item.Coordinates.X;
                    }
                    if (maxX < item.Coordinates.X)
                    {
                        maxX = item.Coordinates.X;
                    }
                    if (minY > item.Coordinates.Y)
                    {
                        minY = item.Coordinates.Y;
                    }
                    if (maxY < item.Coordinates.Y)
                    {
                        maxY = item.Coordinates.Y;
                    }
                }
            }
            else if (Project.MeasurePoints.Count == 1)
            {
                minX = Project.MeasurePoints[0].Coordinates.X - 1.0;
                minY = Project.MeasurePoints[0].Coordinates.Y - 1.0;
                maxX = Project.MeasurePoints[0].Coordinates.X + 1.0;
                maxY = Project.MeasurePoints[0].Coordinates.Y + 1.0;
            }
            else
            {
                minX = -1.0;
                minY = -1.0;
                maxX = +1.0;
                maxY = +1.0;
            }

            deltaX = maxX - minX;
            deltaY = maxY - minY;

            double ZoomX = this.ClientRectangle.Width / deltaX;
            double ZoomY = this.ClientRectangle.Height / deltaY;

            if (ZoomX < ZoomY)
            {
                Zoom = ZoomX * 0.9;
                ScreenX = minX - deltaX * 0.05;
                ScreenY = minY + deltaY - (deltaY - (this.ClientRectangle.Height / Zoom)) / 2.0;
            }
            else
            {
                Zoom = ZoomY * 0.9;
                ScreenX = minX + (deltaX - (this.ClientRectangle.Width / Zoom)) / 2.0;
                ScreenY = minY + deltaY + deltaY * 0.05;
            }

            ReDraw();
        }

        #endregion

        #region Private Methods Draw Functions

        private void ShowStationDialog()
        {
            if (mouseButton == MouseButtons.Left)
            {
                foreach (MeasuredPoint item in Project.MeasurePoints)
                {
                    if (HitTest(item))
                    {
                        ReDraw();
                        if (item.Selected)
                        {
                            item.ShowStationDialog();
                        }
                        break;
                    }
                }
            }
        }

        private bool HitTest(MeasuredPoint Point)
        {
            GraphicsPath pth = new GraphicsPath();

            pth.AddEllipse(GetScreenX(Point.Coordinates.X, ScreenX, Zoom), GetScreenY(Point.Coordinates.Y, ScreenY, Zoom), 8, 8);

            if (pth.IsVisible(new Point(mouseScreenX, mouseScreenY)))
            {
                if (Point.Selected)
                {
                    Point.Selected = false;
                }
                else
                {
                    Point.Selected = true;
                }
                pth.Dispose();
                return (true);
            }
            
            pth.Dispose();
            return (false);
        }

        private void Draw(MeasuredPoint Point)
        {
            int sX = GetScreenX(Point.Coordinates.X, ScreenX, Zoom);
            int sY = GetScreenY(Point.Coordinates.Y, ScreenY, Zoom);

            if (Point.Selected)
            {
                controlDC.FillEllipse(Brushes.Red, sX-4, sY-4, 8, 8);
                controlDC.DrawEllipse(Pens.Orange, sX-4, sY-4, 8, 8);
            }
            else
            {
                controlDC.FillEllipse(Brushes.Gray, sX-4, sY-4, 8, 8);
                controlDC.DrawEllipse(Pens.Orange, sX-4, sY-4, 8, 8);
            }

            controlDC.DrawString(Point.Code, new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.White, sX + 9, sY - 8);
            controlDC.DrawString(Point.ID.ToString(), new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.White, sX + 9, sY + 4);
        }

        #endregion

        #region Private Methods GetScreenCoordinates

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

        #endregion
    }
}