using System;
using System.Globalization;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        
        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {
            cmbMonth.Items.AddRange(new string[]
            {
        "January","February","March","April","May","June",
        "July","August","September","October","November","December"
            });

            for (int i = 1; i <= 31; i++)
                cmbDay.Items.Add(i.ToString());

            for (int i = DateTime.Now.Year; i >= 1950; i--)
                cmbYear.Items.Add(i.ToString());
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            txtFirstName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtFirstName.Text);
            txtFirstName.SelectionStart = txtFirstName.Text.Length;
        }

        private void txtMiddleName_TextChanged(object sender, EventArgs e)
        {
            txtMiddleName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMiddleName.Text);
            txtMiddleName.SelectionStart = txtMiddleName.Text.Length;
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            txtLastName.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtLastName.Text);
            txtLastName.SelectionStart = txtLastName.Text.Length;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" ||
                    txtMiddleName.Text == "" ||
                    txtLastName.Text == "" ||
                    cmbDay.SelectedIndex == -1 ||
                    cmbMonth.SelectedIndex == -1 ||
                    cmbYear.SelectedIndex == -1 ||
                    (!radMale.Checked && !radFemale.Checked))
                {
                    MessageBox.Show("Please complete all fields.");
                    return;
                }

                string gender = radMale.Checked ? "Male" : "Female";

                MessageBox.Show(
                    "Student Information\n\n" +
                    "First Name: " + txtFirstName.Text + "\n" +
                    "Middle Name: " + txtMiddleName.Text + "\n" +
                    "Last Name: " + txtLastName.Text + "\n" +
                    "Gender: " + gender + "\n" +
                    "Birthdate: " +
                    cmbMonth.SelectedItem + "/" +
                    cmbDay.SelectedItem + "/" +
                    cmbYear.SelectedItem
                );
            }
            catch
            {
                MessageBox.Show("Invalid input.");
            }
        }
    }
}