using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;
        
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void frmRegistration_Load(object sender, EventArgs e)
        {
            datePickerBirthday.MaxDate = DateTime.Today;
            string[] ListOfProgram = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"
            };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(ListOfProgram[i].ToString());
            }

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        public long StudentNumber(string studNum)
        {
            if (studNum == null)
                throw new ArgumentNullException("studNum");

            if (Regex.IsMatch(studNum, @"^[0-9]+$"))
            {
                try
                {
                    _StudentNo = long.Parse(studNum);
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
            else
            {
                throw new FormatException("Student Number must contain numbers only.");
            }

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Contact == null)
                throw new ArgumentNullException("Contact");

            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                try
                {
                    _ContactNo = long.Parse(Contact);
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
            else
            {
                throw new FormatException("Contact Number must contain 10 or 11 digits.");
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (LastName == null || FirstName == null || MiddleInitial == null)
                throw new ArgumentNullException("Name");

            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") &&
                Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") &&
                Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }
            else
            {
                throw new FormatException("Name must contain letters only.");
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (age == null)
                throw new ArgumentNullException("age");

            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                try
                {
                    _Age = Int32.Parse(age);
                }
                catch (OverflowException)
                {
                    throw;
                }
            }
            else
            {
                throw new FormatException("Age must contain numbers only.");
            }

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbPrograms.SelectedIndex < 0 || cbGender.SelectedIndex < 0)
                    throw new IndexOutOfRangeException("Please select a Program and Gender.");

                _FullName = FullName(
                    txtLastName.Text,
                    txtFirstName.Text,
                    txtMiddleInitial.Text);

                _StudentNo = StudentNumber(txtStudentNo.Text);
                _ContactNo = ContactNo(txtContactNo.Text);
                _Age = Age(txtAge.Text);

                StudentInformationClass.SetFullName = _FullName;
                StudentInformationClass.SetStudentNo = _StudentNo;
                StudentInformationClass.SetProgram = cbPrograms.Text;
                StudentInformationClass.SetGender = cbGender.Text;
                StudentInformationClass.SetContactNo = _ContactNo;
                StudentInformationClass.SetAge = _Age;
                StudentInformationClass.SetBirthday = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirm frm = new frmConfirm();
                frm.ShowDialog();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Null Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Overflow Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
