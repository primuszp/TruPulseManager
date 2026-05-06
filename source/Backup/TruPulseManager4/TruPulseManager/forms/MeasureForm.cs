using System.Windows.Forms;
using System.IO.Ports;
using System;

namespace TruPulseManager
{
    public partial class MeasureForm : Form
    {
        #region Public Member Properties

        public SerialPort SerialPort { get; set; }
        public Interpreter TruPulse { get; set; }

        #endregion

        public MeasureForm()
        {
            InitializeComponent();
        }

        private void MeasureForm_Load(object sender, System.EventArgs e)
        {
            TruPulse.TruPulseReceived += new Interpreter.TruPulseReceivedEventHandler(TruPulse_TruPulseReceived);
            InitializeControlValues();
        }

        private void InitializeControlValues()
        {
            cBMeasurementMode.SelectedIndex = 2;
            cBTargetMode.SelectedIndex = 0;
        }

        private void WriteCommand(string command)
        {
            lBCommand.Items.Add(command);
            lBCommand.SelectedIndex = lBCommand.Items.Count - 1;
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
                        WriteCommand(command);
                        return (true);
                    }
                    catch
                    {
                        WriteCommand("Message is not send!");
                        return (false);
                    }
                }
                else
                {
                    WriteCommand("Port is not opened!");
                    return (false);
                }
            }
            else
            {
                return (false);
            }
        }

        private void bNMeasure_Click(object sender, System.EventArgs e)
        {
            Project.DataReception = true;
            SendCommand("$GO");
        }

        private void cBMeasurementMode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SerialPort != null)
            {
                switch (cBMeasurementMode.SelectedIndex)
                {
                    case 0: SendCommand("$MM,0");
                        break;
                    case 1: SendCommand("$MM,1");
                        break;
                    case 2: SendCommand("$MM,2");
                        break;
                    case 3: SendCommand("$MM,3");
                        break;
                    case 4: SendCommand("$MM,4");
                        break;
                    case 5: SendCommand("$MM,5");
                        break;
                    default: WriteCommand("Unknown Measurement Mode");
                        break;
                }
            }
        }

        private void cBTargetMode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (SerialPort != null)
            {
                switch (cBTargetMode.SelectedIndex)
                {
                    case 0: SendCommand("$TM,0");
                        break;
                    case 1: SendCommand("$TM,1");
                        break;
                    case 2: SendCommand("$TM,2");
                        break;
                    case 3: SendCommand("$TM,3");
                        break;
                    case 4: SendCommand("$TM,4");
                        break;
                    default: WriteCommand("Unknown Target Mode");
                        break;
                }
            }
        }

        private void bNCancel_Click(object sender, System.EventArgs e)
        {
            SendCommand("$ST");
            this.Close();
        }

        //TruPulse Send a Message to PC
        private void TruPulse_TruPulseReceived(string sentence)
        {
            WriteCommand(sentence);
        }

        private void rBMeters_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBMeters.Checked)
            {
                SendCommand("$DU,0");
            }
        }

        private void rBYards_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBYards.Checked)
            {
                SendCommand("$DU,1");
            }
        }

        private void rBFeet_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBFeet.Checked)
            {
                SendCommand("$DU,2");
            }
        }

        private void rBDegrees_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBDegrees.Checked)
            {
                SendCommand("$AU,0");
            }
        }

        private void rBPercent_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rBPercent.Checked)
            {
                SendCommand("$AU,1");
            }
        }
    }
}
