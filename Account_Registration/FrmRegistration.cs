using System;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            long studentNo;
            long age;
            long contactNo;

            if (string.IsNullOrWhiteSpace(txtStudentNo.Text))
            {
                MessageBox.Show("Please enter your Student Number.",
                    "Invalid Input");
                txtStudentNo.Focus();
                return;
            }

            if (!long.TryParse(txtStudentNo.Text, out studentNo))
            {
                MessageBox.Show("Student Number must contain numbers only.",
                    "Invalid Input");
                txtStudentNo.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(cbProgram.Text))
            {
                MessageBox.Show("Please select a Program.",
                    "Invalid Input");
                cbProgram.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please enter your Last Name.",
                    "Invalid Input");
                txtLastName.Focus();
                return;
            }

            if (!IsNameValid(txtLastName.Text))
            {
                MessageBox.Show("Last Name must contain letters and spaces only.",
                    "Invalid Input");
                txtLastName.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("Please enter your First Name.",
                    "Invalid Input");
                txtFirstName.Focus();
                return;
            }

            if (!IsNameValid(txtFirstName.Text))
            {
                MessageBox.Show("First Name must contain letters and spaces only.",
                    "Invalid Input");
                txtFirstName.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtMiddleName.Text))
            {
                MessageBox.Show("Please enter your Middle Name.",
                    "Invalid Input");
                txtMiddleName.Focus();
                return;
            }

            if (!IsNameValid(txtMiddleName.Text))
            {
                MessageBox.Show("Middle Name must contain letters and spaces only.",
                    "Invalid Input");
                txtMiddleName.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtAge.Text))
            {
                MessageBox.Show("Please enter your Age.",
                    "Invalid Input");
                txtAge.Focus();
                return;
            }

            if (!long.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Age must contain numbers only.",
                    "Invalid Input");
                txtAge.Focus();
                return;
            }

            if (age <= 0)
            {
                MessageBox.Show("Please enter a valid Age.",
                    "Invalid Input");
                txtAge.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                MessageBox.Show("Please enter your Contact Number.",
                    "Invalid Input");
                txtContactNo.Focus();
                return;
            }

            if (!long.TryParse(txtContactNo.Text, out contactNo))
            {
                MessageBox.Show("Contact Number must contain numbers only.",
                    "Invalid Input");
                txtContactNo.Focus();
                return;
            }

            if (txtContactNo.Text.Length != 11)
            {
                MessageBox.Show("Contact Number must contain exactly 11 numbers.",
                    "Invalid Input");
                txtContactNo.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please enter your Address.",
                    "Invalid Input");
                txtAddress.Focus();
                return;
            }

            
            StudentInfoClass.StudentNo = studentNo;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.LastName = txtLastName.Text;
            StudentInfoClass.FirstName = txtFirstName.Text;
            StudentInfoClass.MiddleName = txtMiddleName.Text;
            StudentInfoClass.Age = age;
            StudentInfoClass.ContactNo = contactNo;
            StudentInfoClass.Address = txtAddress.Text;

            
            FrmConfirm frmConfirm = new FrmConfirm();

            
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
                txtStudentNo.Clear();
                cbProgram.SelectedIndex = -1;
                txtLastName.Clear();
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtAge.Clear();
                txtContactNo.Clear();
                txtAddress.Clear();
            }
        }

        private bool IsNameValid(string name)
        {
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }

            return true;
        }
    }
}
    
