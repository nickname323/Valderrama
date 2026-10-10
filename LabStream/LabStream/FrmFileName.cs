using System;
using System.IO;
using System.Windows.Forms;
 
namespace LabStream
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName;
 
        public FrmFileName()
        {
            InitializeComponent();
        }
 
        private void btnOkay_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
 
            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Please enter a valid file name.", "Input Error");
                return;
            }
 
            if (fileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("File name contains invalid characters.", "Input Error");
                return;
            }
 
            SetFileName = fileName + ".txt";
            this.Close();
        }
    }
}