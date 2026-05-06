using System.Drawing;
using System.Windows.Forms;

namespace TB.Instruments
{
    public class SlidingScale : Panel
    {
        public Color NeedleColor { get; set; } = Color.Firebrick;
        public double Value { get; set; }
    }
}
