using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;

namespace TruPulseManager
{
    public partial class SerialPortForm : Form
    {
        #region Public Member Properties

        public SerialPort SerialPort { get; set; }
        public Interpreter TruPulse { get; set; }

        #endregion

        #region Constructors

        public SerialPortForm()
        {
            InitializeComponent();
        }

        #endregion

        private void SerialPortForm_Load(object sender, EventArgs e)
        {
            InitializeControlValues();
            TruPulse.TruPulseReceived += new Interpreter.TruPulseReceivedEventHandler(TruPulse_TruPulseReceived);
        }

        private string[] GetPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            char[] valid = new char[] { 'C', 'O', 'M', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < ports.Length; i++)
            {
                string invalid = ports[i].Trim(valid);
  
                if (invalid != "")
                {
                    ports[i] = ports[i].Remove(ports[i].Length-1);
                }
            }
            return (ports);
        }

        private string GetPortNames(int selected)
        {
            return (GetPortNames()[selected]);
        }

        private void InitializeControlValues()
        {
            //Nice methods to browse all available ports:
            string[] ports = GetPortNames();

            cmbComSelect.Items.Clear();

            //Add all port names to the combo box:
            foreach (string port in ports)
            {
                cmbComSelect.Items.Add("Communications Port" + " " + "(" + port + ")");
            }

            if (cmbComSelect.Items.Count > 0)
            {
                cmbComSelect.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show(this, "There are no COM Ports detected on this computer.\nPlease install a COM Port and restart this app.", "No COM Ports Installed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            cmbParity.Items.Clear();
            cmbParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            cmbStopBits.Items.Clear();
            cmbStopBits.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            cmbParity.Text = SerialPort.Parity.ToString();
            cmbStopBits.Text = SerialPort.StopBits.ToString();
            cmbDataBits.Text = SerialPort.DataBits.ToString();
            cmbBaudRate.Text = SerialPort.BaudRate.ToString();

            if (SerialPort.IsOpen)
            {
                buttonOpenPort.Enabled = false;
                buttonClosePort.Enabled = true;
            }
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (cmbComSelect.SelectedIndex < 0) return;

            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }

            SerialPort.PortName = GetPortNames(cmbComSelect.SelectedIndex);

            // try to open the selected port:
            try
            {
                SerialPort.Open();
                buttonOpenPort.Enabled = false;
                buttonClosePort.Enabled = true;
                buttonTest.Enabled = true;
            }
            // give a message, if the port is not available:
            catch
            {
                MessageBox.Show("Serial port " + SerialPort.PortName + " cannot be opened!", "TruPulse Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonClosePort_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                SerialPort.Close();
            }

            buttonOpenPort.Enabled = true;
            buttonClosePort.Enabled = false;
            buttonTest.Enabled = false;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            if (SerialPort.IsOpen)
            {
                try
                {
                    SerialPort.Write("$ID" + "\r\n");
                }
                catch(TimeoutException)
                {
                    MessageBox.Show("This is invalid TruPulse port!", "TruPulse Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Serial port " + SerialPort.PortName + " cannot be opened!", "TruPulse Manager", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //TruPulse Send a Message to PC
        private void TruPulse_TruPulseReceived(string sentence)
        {
            if (sentence.Contains("TP360"))
            {
                MessageBox.Show("TruPulse is connected!", "TruPulse Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
