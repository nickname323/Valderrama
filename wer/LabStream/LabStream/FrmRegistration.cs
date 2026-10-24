using System;
using System.IO;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            txtAge.ReadOnly = true;
            dtpBirthday.ValueChanged += dtpBirthday_ValueChanged;
            UpdateAge();
        }

        private void dtpBirthday_ValueChanged(object sender, EventArgs e)
        {
            UpdateAge();
        }

        private void UpdateAge()
        {
            DateTime birthday = dtpBirthday.Value.Date;
            DateTime today = DateTime.Today;
            if (birthday > today)
            {
                txtAge.Text = "";
                return;
            }
            int age = today.Year - birthday.Year;
            if (birthday > today.AddYears(-age)) age--;
            txtAge.Text = age.ToString();
        }

        private void btnStudentRecord_Click(object sender, EventArgs e)
        {
            using (FrmStudentRecord recordForm = new FrmStudentRecord(this))
            {
                recordForm.ShowDialog(this);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
            {
                MessageBox.Show("Student Number is missing.", "Input Error");
                return;
            }
            if (!long.TryParse(txtStudentNo.Text, out _))
            {
                MessageBox.Show("Student Number must be a valid numeric value.", "Data Type Error");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Last Name is missing.", "Input Error"); return;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is missing.", "Input Error"); return;
            }
            if (string.IsNullOrWhiteSpace(txtMI.Text))
            {
                MessageBox.Show("Middle Initial is missing.", "Input Error"); return;
            }
            if (string.IsNullOrWhiteSpace(cbProgram.Text))
            {
                MessageBox.Show("Program is missing.", "Input Error"); return;
            }
            if (string.IsNullOrWhiteSpace(cbGender.Text))
            {
                MessageBox.Show("Gender is missing.", "Input Error"); return;
            }
            if (dtpBirthday.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Birthday cannot be a future date.", "Input Error"); return;
            }
            UpdateAge();
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Contact Number is missing.", "Input Error"); return;
            }
            if (!long.TryParse(txtContactNo.Text, out _))
            {
                MessageBox.Show("Contact Number must be a valid numeric value.", "Data Type Error"); return;
            }

            string studentNo = txtStudentNo.Text.Trim();
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullPath = Path.Combine(docPath, studentNo + ".txt");
            string[] studentDetails = {
                "Student No.: " + studentNo,
                "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text + ", " + txtMI.Text + ".",
                "Program: " + cbProgram.Text,
                "Gender: " + cbGender.Text,
                "Age: " + txtAge.Text,
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd"),
                "Contact No.: " + txtContactNo.Text
            };
            try
            {
                using (StreamWriter outputFile = new StreamWriter(fullPath, false))
                {
                    foreach (string detail in studentDetails) outputFile.WriteLine(detail);
                }
                MessageBox.Show("Text file successfully created.", "Success");
            }
            catch (ArgumentException ex) { MessageBox.Show("Invalid path or file name: " + ex.Message, "Argument Error"); }
            catch (UnauthorizedAccessException) { MessageBox.Show("Permission denied when writing to the file.", "Access Denied"); }
            catch (DirectoryNotFoundException) { MessageBox.Show("Document path not found.", "Path Error"); }
            catch (IOException ex) { MessageBox.Show("File writing error: " + ex.Message, "File Error"); }
            catch (Exception ex) { MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error"); }
        }
    }
}
