
using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Please enter some text before proceeding.", "Input Error");
                return;
            }

            FrmFileName.SetFileName = "";
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            if (string.IsNullOrWhiteSpace(FrmFileName.SetFileName))
            {
                return;
            }

            string getInput = txtInput.Text;
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                string fullPath = Path.Combine(docPath, FrmFileName.SetFileName);

                using (StreamWriter outputFile = new StreamWriter(fullPath, false))
                {
                    outputFile.WriteLine(getInput);
                }

                MessageBox.Show("Text file successfully created.", "Success");

                FrmRegistration frmRegistration = new FrmRegistration();
                frmRegistration.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}