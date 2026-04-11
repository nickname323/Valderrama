using System;
using System.Collections; // Required for ArrayList
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace StudentRegApp
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= 31; i++)
            {
                cmbDay.Items.Add(i.ToString());
            }

            
            string[] months = {
                "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            };
            foreach (string month in months)
            {
                cmbDay.Items.Add(month);
            }

            
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cmbYear.Items.Add(i.ToString());
            }

            
            ArrayList programs = new ArrayList();
            programs.Add("Bachelor of Science in Computer Science");
            programs.Add("Bachelor of Science in Information Technology");
            programs.Add("Bachelor of Science in Information Systems");
            programs.Add("Bachelor of Science in Computer Engineering");
            cmbProgram.Items.Clear();
            foreach (string program in programs)
            {
                cmbProgram.Items.Add(program);
            }
        }

        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrEmpty(txtFirstName.Text) ||
                    string.IsNullOrEmpty(txtLastName.Text) ||
                   
                    cmbProgram.SelectedIndex == -1 ||
                    (!rbMale.Checked && !rbFemale.Checked))
                {
                    MessageBox.Show("Please complete all fields.");
                    return;
                }
                string fullName = $"{txtFirstName.Text} {txtMiddleName.Text} {txtLastName.Text}";
                string gender = rbMale.Checked ? "Male" : "Female";
                string program = cmbProgram.Text;

                DisplayStudentInfo(fullName, gender, program);
                DisplayStudentInfo(fullName, program);
                DisplayStudentInfo(fullName);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid input.");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    picStudent.ImageLocation = openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to load image.");
                }
            }
        }
        public void DisplayStudentInfo(string name, string gender, string program)
        {
            MessageBox.Show($"Student Name: {name}\nGender: {gender}\nProgram: {program}");
        }
        public void DisplayStudentInfo(string name, string program)
        {
            MessageBox.Show($"Student Name: {name}\nProgram: {program}");
        }
        public void DisplayStudentInfo(string name)
        {
            MessageBox.Show($"Student Name: {name}");
        }

        private void Vald(object sender, EventArgs e)
        {

        }
    }
}
