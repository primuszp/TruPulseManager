using System;
using System.Windows.Forms;
using System.IO;

namespace TruPulseManager
{
    public partial class FileOpenSaveForm : Form
    {
        KeyBoardForm keyboard = new KeyBoardForm();

        public DrawingArea DrawingArea { get; set; }
        
        public FileOpenSaveForm()
        {
            InitializeComponent();
        }

        private void textBoxProject_Click(object sender, EventArgs e)
        {
            keyboard.ShowDialog();
            textBoxProject.Text = keyboard.CodeText;

            if (textBoxProject.Text != "")
            {
                btnNewProject.Enabled = true;
            }
            else
            {
                btnNewProject.Enabled = false;
            }
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            if (saveFileDialog != null)
            {
                saveFileDialog.FileName = textBoxProject.Text;
                saveFileDialog.Filter = "Pocket Surveyor Files|*.trp";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm.InitalizeProject();
                    Project.Name = textBoxProject.Text;
                    Project.Path = saveFileDialog.FileName;
                    MainForm.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog != null)
            {
                openFileDialog.Filter = "Pocket Surveyor Files|*.trp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm.Open(openFileDialog.FileName);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog != null)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MainForm.Save(saveFileDialog.FileName);
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DrawingArea.ZoomAll();
        }

        private void btnTXTImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog != null)
            {
                openFileDialog.Filter = "TXT File|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader myFile = File.OpenText(openFileDialog.FileName))
                    {
                        MeasuredPoint myPoint = null;
                        string buffer = null;
                        string[] split = null;

                        while ((buffer = myFile.ReadLine()) != null)
                        {
                            split = buffer.Split(new Char[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);

                            myPoint = new MeasuredPoint();
                            myPoint.ID = Convert.ToInt32(split[0]);
                            myPoint.Coordinates.X = Convert.ToDouble(split[1]);
                            myPoint.Coordinates.Y = Convert.ToDouble(split[2]);
                            myPoint.Coordinates.Z = Convert.ToDouble(split[3]);
                            myPoint.Code = split[4];
                            Project.MeasurePoints.Add(myPoint);
                        }
                    }
                }
            }
       }

        private void FileOpenSaveForm_Load(object sender, EventArgs e)
        {
            textBoxProject.Text = Project.Name;

            if (textBoxProject.Text != "")
            {
                btnNewProject.Enabled = true;
            }
            else
            {
                btnNewProject.Enabled = false;
            }
        }

        private void btnTXTExport_Click(object sender, EventArgs e)
        {
            using (StreamWriter myFile = new StreamWriter(Project.Name + ".txt"))
            {
                foreach (MeasuredPoint item in Project.MeasurePoints)
                {
                    myFile.WriteLine(item.ID + "\t" + item.Coordinates.X + "\t" + item.Coordinates.Y + "\t" + item.Coordinates.Z + "\t" + item.Code);
                }
            }

            using (StreamWriter file = new StreamWriter("stations" + ".txt"))
            {
                foreach (MeasuredPoint item in Project.MeasurePoints)
                {
                    file.WriteLine(item.ID + "\t" + item.MeasuredValues.SlopeDistance + "\t" + item.MeasuredValues.Azimuth + "\t" + item.MeasuredValues.Inclination + "\t" + item.Code);
                }
            }
        }
    }
}