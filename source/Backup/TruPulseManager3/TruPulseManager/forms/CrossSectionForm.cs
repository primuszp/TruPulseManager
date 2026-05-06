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
            Project.CrossSection = new CrossSection();
            Project.CrossSection.Section = Convert.ToDouble(tBSection.Text);
            Project.CrossSection.Indices.Clear();

            Project.Profile = Project.Section.Add;
            this.Close();
        }

        private void CrossSectionForm_Load(object sender, EventArgs e)
        {
            foreach (CrossSection item in Project.CrossSections)
            {
                lBoxCrossSection.Items.Add(item.Section.ToString("00+00.00"));                
            }

            if (Project.CrossSections.Count == 0)
            {
                tBSection.Text = "0";
            }
            else
            {
                tBSection.Text = Convert.ToString(Project.CrossSection.Section + Project.SectionDelta);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int index = lBoxCrossSection.SelectedIndex;

            if (index >= 0)
            {
                Project.CrossSections.RemoveAt(index);
                lBoxCrossSection.Items.RemoveAt(index);
                lBoxCrossSection.Refresh();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int index = lBoxCrossSection.SelectedIndex;

            if (index >= 0)
            {
                Project.Profile = Project.Section.Insert;
                Project.CrossSection = Project.CrossSections[index];
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Project.Profile = Project.Section.None;
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