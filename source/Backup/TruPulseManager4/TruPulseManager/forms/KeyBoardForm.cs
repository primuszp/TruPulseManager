using System;
using System.Drawing;
using System.Windows.Forms;

namespace TruPulseManager
{
    public partial class KeyBoardForm : Form
    {
        private Point mousePoint = new Point();

        #region Public Properties

        public string CodeText { get; set; }
        
        public bool Numeric { get; set; }

        #endregion

        public KeyBoardForm()
        {
            InitializeComponent();
        }

        private void KeyBoardForm_Load(object sender, EventArgs e)
        {
            textBox.Text = CodeText;
            CheckNumeric();
        }

        #region KeyBoard Handlers

        private void btnDot_Click(object sender, EventArgs e)
        {
            textBox.AppendText(",");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.AppendText("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.AppendText("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.AppendText("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.AppendText("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.AppendText("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.AppendText("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.AppendText("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.AppendText("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.AppendText("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.AppendText("9");
        }

        private void btnA_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("A");
        }

        private void btnB_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("B");
        }

        private void btnC_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("C");
        }

        private void btnD_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("D");
        }

        private void btnE_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("E");
        }

        private void btnF_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("F");
        }

        private void btnG_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("G");
        }

        private void btnH_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("H");
        }

        private void btnI_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("I");
        }

        private void btnJ_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("J");
        }

        private void btnL_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("L");
        }

        private void btnK_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("K");
        }

        private void btnM_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("M");
        }

        private void btnN_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("N");
        }

        private void btnO_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("O");
        }

        private void btnP_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("P");
        }

        private void btnQ_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("Q");
        }

        private void btnR_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("R");
        }

        private void btnS_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("S");
        }

        private void btnT_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("T");
        }

        private void btnU_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("U");
        }

        private void btnV_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("V");
        }

        private void btnW_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("W");
        }

        private void btnX_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("X");
        }

        private void btnY_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("Y");
        }

        private void btnZ_Click(object sender, System.EventArgs e)
        {
            textBox.AppendText("Z");
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            textBox.Clear();
        }

        #endregion

        private void textBox_MouseClick(object sender, MouseEventArgs e)
        {
            mousePoint = e.Location;
        }

        private void CheckNumeric()
        {
            if (Numeric)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnE.Enabled = false;
                btnF.Enabled = false;
                btnG.Enabled = false;
                btnH.Enabled = false;
                btnI.Enabled = false;
                btnJ.Enabled = false;
                btnK.Enabled = false;
                btnL.Enabled = false;
                btnM.Enabled = false;
                btnN.Enabled = false;
                btnO.Enabled = false;
                btnP.Enabled = false;
                btnQ.Enabled = false;
                btnR.Enabled = false;
                btnS.Enabled = false;
                btnT.Enabled = false;
                btnU.Enabled = false;
                btnV.Enabled = false;
                btnW.Enabled = false;
                btnX.Enabled = false;
                btnY.Enabled = false;
                btnZ.Enabled = false;
                grpKeyBoard.Text = "Numeric";
            }
            else
            {
                btnA.Enabled = true;
                btnB.Enabled = true;
                btnC.Enabled = true;
                btnD.Enabled = true;
                btnE.Enabled = true;
                btnF.Enabled = true;
                btnG.Enabled = true;
                btnH.Enabled = true;
                btnI.Enabled = true;
                btnJ.Enabled = true;
                btnK.Enabled = true;
                btnL.Enabled = true;
                btnM.Enabled = true;
                btnN.Enabled = true;
                btnO.Enabled = true;
                btnP.Enabled = true;
                btnQ.Enabled = true;
                btnR.Enabled = true;
                btnS.Enabled = true;
                btnT.Enabled = true;
                btnU.Enabled = true;
                btnV.Enabled = true;
                btnW.Enabled = true;
                btnX.Enabled = true;
                btnY.Enabled = true;
                btnZ.Enabled = true;
                grpKeyBoard.Text = "Text";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CodeText = textBox.Text;
            this.Close();
        }
    }
}
