using System;
using System.Windows.Forms;

namespace TruPulseManager
{
    public partial class SplashForm : Form
    {
        private int count = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            count++;
            switch (count)
            {
                case 5:
                    //	Ha a betöltés megtörtént a 
                    //	nyitó ablakot felszabadítjuk, és a
                    //	főablakot megjelenítjük.
                    this.Dispose(true);
                    new MainForm().Show();
                    break;
                default:
                    //	ProgressBar léptetése.
                    progressBar.PerformStep();
                    break;
            }
        }
    }
}
