using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TruPulseManager
{
    public partial class DrawingArea : UserControl
    {
        private Graphics controlDC;
        private Image controlBitmap;

        private double zoom = 1.0;
        private double screenX = 0;
        private double screenY = 0;
        private double screenDownX = 0.0;
        private double screenDownY = 0.0;

        public double mouseX = 0.0;
        public double mouseY = 0.0;
        private double mouseDownX = 0.0;
        private double mouseDownY = 0.0;

        private int mouseScreenX = 0;
        private int mouseScreenY = 0;
        private int mouseScreenDownX = 0;
        private int mouseScreenDownY = 0;

        private MouseButtons mouseButton = MouseButtons.None;

        private bool pickPan;
        private double scale;

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

        public DrawingArea()
        {
            InitializeComponent();
        }

        private void DrawingArea_Resize(object sender, EventArgs e)
        {
            Initialize();
        }

        public void Initialize()
        {
            if (controlBitmap != null)
            {
                controlBitmap.Dispose();
            }
            controlBitmap = new Bitmap(this.Width, this.Height, this.CreateGraphics());
            controlDC = Graphics.FromImage(controlBitmap);
            controlDC.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            ReDraw();
        }

        private void RefreshControl()
        {
            Graphics windowDC = this.CreateGraphics();
            windowDC.DrawImage(controlBitmap, 0, 0);
            windowDC.Dispose();
        }

        public void ReDraw()
        {
            controlDC.Clear(BackColor);

            foreach (MeasuredPoint item in MainForm.MeasuredPoints)
            {
                Draw(item);
            }

            DrawScale();
            controlDC.DrawImage(controlBitmap, 0, 0);
            RefreshControl();
        }

        private void DrawScale()
        {
            Pen myPen = new Pen(Brushes.Black);
            StringFormat mFormat = new StringFormat();

            mFormat.Alignment = StringAlignment.Center;
            mFormat.LineAlignment = StringAlignment.Center;

            //100 px hány cm
            scale = (100 / Zoom) * 100; ;

            controlDC.DrawLine(myPen, 10, this.Size.Height - 10, 110, this.Size.Height - 10);
            controlDC.DrawLine(myPen, 10, this.Size.Height - 15, 10, this.Size.Height - 5);
            controlDC.DrawLine(myPen, 110, this.Size.Height - 15, 110, this.Size.Height - 5);

            if (scale > 100000)
            {
                controlDC.DrawString((scale / 100000).ToString("0.00") + " km", new Font(FontFamily.GenericSansSerif, 10.0f), Brushes.Black, 60, this.Size.Height - 20, mFormat);
            }
            else
                if (scale > 100)
                {
                    controlDC.DrawString((scale / 100).ToString("0.00") + " m", new Font(FontFamily.GenericSansSerif, 10.0f), Brushes.Black, 60, this.Size.Height - 20, mFormat);
                }
                else
                {
                    controlDC.DrawString(scale.ToString("0.00") + " cm", new Font(FontFamily.GenericSansSerif, 10.0f), Brushes.Black, 60, this.Size.Height - 20, mFormat);
                }

            myPen.Dispose();
            mFormat.Dispose();
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
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
                mouseX = screenX + mouseScreenX / zoom;
                mouseY = screenY - mouseScreenY / zoom;
            }
            else if (mouseButton == MouseButtons.Middle || PickPan)
            {
                screenX = screenDownX - (e.X - mouseScreenDownX) / zoom;
                screenY = screenDownY - (mouseScreenDownY - e.Y) / zoom;
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

            foreach (MeasuredPoint item in MainForm.MeasuredPoints)
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

            double ZoomX = this.ClientRectangle.Width / (maxX - minX);
            double ZoomY = this.ClientRectangle.Height / (maxY - minY);

            if (ZoomX < ZoomY)
            {
                Zoom = ZoomX * 0.9;
                ScreenX = minX - (maxX - minX) * 0.05;
                ScreenY = minY + ((maxY - minY)) - (((maxY - minY)) - (this.ClientRectangle.Height / Zoom)) / 2.0;
            }
            else
            {
                Zoom = ZoomY * 0.9;
                ScreenX = minX + ((maxX - minX) - (this.ClientRectangle.Width / Zoom)) / 2.0;
                ScreenY = minY + ((maxY - minY)) + (maxY - minY) * 0.05;
            }

            ReDraw();
        }

        #endregion

        #region Private Methods Draw Functions

        private void ShowStationDialog()
        {
            if (mouseButton == MouseButtons.Left)
            {
                foreach (MeasuredPoint item in MainForm.MeasuredPoints)
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
                controlDC.FillEllipse(Brushes.Red, sX, sY, 8, 8);
                controlDC.DrawEllipse(Pens.Black, sX, sY, 8, 8);
            }
            else
            {
                controlDC.FillEllipse(Brushes.Gray, sX, sY, 8, 8);
                controlDC.DrawEllipse(Pens.Black, sX, sY, 8, 8);
            }

            controlDC.DrawString(Point.Code, new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.Black, sX + 8, sY - 8);
            controlDC.DrawString(Point.ID.ToString(), new Font(FontFamily.GenericSansSerif, 8.0f), Brushes.Black, sX + 8, sY + 4);
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