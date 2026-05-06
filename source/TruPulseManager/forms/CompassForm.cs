using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace TruPulseManager
{
    public partial class CompassForm : Form
    {
        #region Public Member Properties

        public SerialPort SerialPort { get; set; }
        public Interpreter TruPulse { get; set; }
        public double Azimuth { get; set; }

        #endregion

        private bool measure = false;

        public CompassForm()
        {
            InitializeComponent();
        }

        private void Compass_Load(object sender, EventArgs e)
        {
            TruPulse.TruPulseReceived += new Interpreter.TruPulseReceivedEventHandler(TruPulse_TruPulseReceived);
        }

        private void btnMeasure_Click(object sender, EventArgs e)
        {
            if (!measure)
            {
                SendCommand("$TM,1");
                SendCommand("$GO");
                measure = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (measure)
            {
                SendCommand("$ST");
                SendCommand("$TM,0");
                measure = false;
            }
        }

        //TruPulse Send a Message to PC
        private void TruPulse_TruPulseReceived(string sentence)
        {

        }

        private bool SendCommand(string command)
        {
            if (SerialPort != null)
            {
                if (SerialPort.IsOpen)
                {
                    try
                    {
                        SerialPort.WriteLine(command + "\r\n");;
                        return (true);
                    }
                    catch
                    {
                        //WriteCommand("Message is not send!");
                        return (false);
                    }
                }
                else
                {
                    //WriteCommand("Port is not opened!");
                    return (false);
                }
            }
            else
            {
                return (false);
            }
        }
    }
}
