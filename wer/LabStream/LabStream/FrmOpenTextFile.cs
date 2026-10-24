using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmOpenTextFile : Form
    {
        public FrmOpenTextFile()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmLab1 frmLab1 = new FrmLab1();
            frmLab1.Show();
            this.Close();
        }

        private void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog1.FileName;
            lvShowText.Items.Clear();

            try
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string getText;
                    while ((getText = streamReader.ReadLine()) != null)
                        lvShowText.Items.Add(new ListViewItem(getText));
                }

                if (lvShowText.Items.Count == 0)
                    MessageBox.Show("The selected file is empty.", "No Content",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to open this file.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The selected file could not be found.", "File Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (IOException ex)
            {
                MessageBox.Show("The file could not be read: " + ex.Message, "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
