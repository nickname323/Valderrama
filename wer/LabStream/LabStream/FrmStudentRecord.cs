using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmStudentRecord : Form
    {
        private readonly FrmRegistration registrationForm;

        public FrmStudentRecord(FrmRegistration owner)
        {
            InitializeComponent();
            registrationForm = owner;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = directory;
                    openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    openFileDialog.Title = "Find Student Record";
                    openFileDialog.CheckFileExists = true;
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog(this) != DialogResult.OK)
                        return;

                    txtRecord.Clear();
                    using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                        txtRecord.Text = reader.ReadToEnd();

                    if (string.IsNullOrWhiteSpace(txtRecord.Text))
                        MessageBox.Show("The selected file is empty.", "No Record Content",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FileNotFoundException)
            {
                txtRecord.Clear();
                MessageBox.Show("The text file was not found.", "Record Not Found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to read this file.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnUpload_Click(object sender, EventArgs e)
        {
            txtRecord.Clear();
            MessageBox.Show("Successfully Uploaded!", "Upload",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            registrationForm.Show();
            registrationForm.Activate();
        }
    }

    public class StudentRecordNotFoundException : Exception
    {
        public StudentRecordNotFoundException(string message) : base(message) { }
    }
}
