using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace TruPulseManager
{
    public partial class BatteryBarForm : Form
    {
        #region Public Member Properties

        public SerialPort SerialPort { get; set; }

        #endregion

        public BatteryBarForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Refreshes the form's controls with the current power status.
        /// </summary>
        private void RefreshStatus()
        {
            PowerStatus power = SystemInformation.PowerStatus;

            // Show the main power status
            switch (power.PowerLineStatus)
            {
                case PowerLineStatus.Online:
                    MainsPower.Checked = true;
                    break;

                case PowerLineStatus.Offline:
                    MainsPower.Checked = false;
                    break;

                case PowerLineStatus.Unknown:
                    MainsPower.CheckState = CheckState.Indeterminate;
                    break;
            }

            // Power level
            int powerPercent = (int)(power.BatteryLifePercent * 100);
            if (powerPercent <= 100)
                DeviceIndicator.Value = powerPercent;
            else
                DeviceIndicator.Value = 0;

            // Battery Remaining
            int secondsRemaining = power.BatteryLifeRemaining;
            if (secondsRemaining >= 0)
            {
                lbChargeValue.Text = string.Format("{0} min", secondsRemaining / 60);
            }
            else
            {
                lbChargeValue.Text = "?";
            }

            // Battery Status
            lbStatusValue.Text = power.BatteryChargeStatus.ToString();
        }

        /// <summary>
        /// Refresh the power status immediately on loading.
        /// </summary>
        private void BatteryBarForm_Load(object sender, EventArgs e)
        {
            RefreshStatus();
            RefreshTimer.Enabled = true;
        }

        /// <summary>
        /// Refresh the power status periodically.
        /// </summary>
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {
            RefreshStatus();
        }
    }
}
