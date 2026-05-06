using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace TruPulseManager
{
    public partial class FastStore : UserControl
    {
        private KeyBoardForm keyboard = new KeyBoardForm();

        #region Public Member Properties

        public DrawingArea DrawingArea { get; set; }
        public SerialPort SerialPort { get; set; }
        public Interpreter TruPulse { get; set; }
        public string Code { get; set; }
        public int MarkHeight { get; set; }

        #endregion

        public FastStore()
        {
            InitializeComponent();
        }

        public void CalcCoordinates(HVMessage hvMessage)
        {
            MeasuredPoint measuredPoint = new MeasuredPoint();

            measuredPoint.MeasuredValues = hvMessage;
            measuredPoint.MarkHeight = Convert.ToDouble(MarkHeight / 1000.0);
            measuredPoint.ID = Convert.ToInt32(Project.StartPointID);
            measuredPoint.Code = Code;
            measuredPoint.StationID = Convert.ToInt32(Project.Station.ID);
            measuredPoint.CalcCoordinates(Project.Station);

            Project.MeasurePoints.Add(measuredPoint);
            Project.StartPointID++;

            if (Project.Profile == Project.Section.Add || Project.Profile == Project.Section.Insert)
            {
                Project.CrossSection.Indices.Add(measuredPoint.ID);
            }

            MainForm.MeasureMode = MainForm.Mode.Slow;

            panel.BackColor = Color.Green;
            DrawingArea.ReDraw();
        }

        private bool SendCommand(string command)
        {
            if (SerialPort != null)
            {
                if (SerialPort.IsOpen)
                {
                    try
                    {
                        SerialPort.Write(command + "\r\n");
                        return (true);
                    }
                    catch
                    {
                        return (false);
                    }
                }
                else
                {
                    MessageBox.Show("Serial port " + SerialPort.PortName + " cannot be opened!", "TruPulse Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return (false);
                }
            }
            else
            {
                return (false);
            }
        }

        private void StartMeasure(string code, string markHeight)
        {
            panel.BackColor = Color.Red;
            MainForm.MeasureMode = MainForm.Mode.Fast;
            Project.DataReception = true;

            if (SendCommand("$GO"))
            {
                Code = code;
                MarkHeight = Convert.ToInt32(markHeight);
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            StartMeasure(btnA.Text, mhA.Text);
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            StartMeasure(btnB.Text, mhB.Text);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            StartMeasure(btnC.Text, mhC.Text);
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            StartMeasure(btnD.Text, mhD.Text);
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            StartMeasure(btnE.Text, mhE.Text);
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            StartMeasure(btnF.Text, mhF.Text);
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            StartMeasure(btnG.Text, mhG.Text);
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            StartMeasure(btnH.Text, mhH.Text);
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            StartMeasure(btnJ.Text, mhJ.Text);
        }

        private void buttonShift_Click(object sender, EventArgs e)
        {
            if (this.Height == 27)
            {
                this.panel.BackColor = Color.LightSteelBlue;
                this.btnShift.ImageIndex = 0;
                this.Height = 250;
                this.Refresh();
            }
            else
            {
                this.panel.BackColor = Color.LightSteelBlue;
                this.btnShift.ImageIndex = 1;
                this.Height = 27;
                this.Refresh();
            }

        }

        private void ShowKeyBoard(Label label)
        {
            keyboard.Numeric = true;
            keyboard.CodeText = label.Text;
            keyboard.ShowDialog();
            label.Text = keyboard.CodeText;
        }

        private void mhA_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhA);
        }

        private void mhB_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhB);
        }

        private void mhC_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhC);
        }

        private void mhD_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhD);
        }

        private void mhE_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhE);
        }

        private void mhF_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhF);
        }

        private void mhG_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhG);
        }

        private void mhH_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhH);
        }

        private void mhJ_Click(object sender, EventArgs e)
        {
            ShowKeyBoard(mhJ);
        }

    }
}
