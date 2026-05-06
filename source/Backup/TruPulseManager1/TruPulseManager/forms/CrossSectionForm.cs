using System;
using System.Windows.Forms;

namespace TruPulseManager
{
    public partial class CrossSectionForm : Form
    {
        private KeyBoardForm keyboard = new KeyBoardForm();

        public CrossSectionForm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            MainForm.CrossSection = new CrossSection();
            MainForm.CrossSection.Section = Convert.ToDouble(tBSection.Text);
            MainForm.CrossSection.Indices.Clear();

            MainForm.Profile = MainForm.Section.Add;
            this.Close();
        }

        private void CrossSectionForm_Load(object sender, EventArgs e)
        {
            foreach (CrossSection item in MainForm.CrossSections)
            {
                lBoxCrossSection.Items.Add(item.Section.ToString("00+00.00"));                
            }

            if (MainForm.CrossSections.Count == 0)
            {
                tBSection.Text = "0";
            }
            else
            {
                tBSection.Text = Convert.ToString(MainForm.CrossSection.Section + MainForm.SectionDelta);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lBoxCrossSection.SelectedIndex;

            if (index >= 0)
            {
                MainForm.CrossSections.RemoveAt(index);
                lBoxCrossSection.Items.RemoveAt(index);
                lBoxCrossSection.Refresh();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int index = lBoxCrossSection.SelectedIndex;

            if (index >= 0)
            {
                MainForm.Profile = MainForm.Section.Insert;
                MainForm.CrossSection = MainForm.CrossSections[index];
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Profile = MainForm.Section.None;
        }

        private void CrossSectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lBoxCrossSection.Items.Clear();
            btnInsert.Enabled = false;
            this.Close();
        }

        private void tBSection_Click(object sender, EventArgs e)
        {
            keyboard.CodeText = tBSection.Text;
            keyboard.ShowDialog();
            tBSection.Text = keyboard.CodeText;
        }

        private void lBoxCrossSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lBoxCrossSection.SelectedIndex;

            if (index >= 0)
            {
                btnInsert.Enabled = true;
            }
            else
            {
                btnInsert.Enabled = false;
            }
        }
    }
}