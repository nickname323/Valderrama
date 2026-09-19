using System;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmConfirm : Form
    {
        public frmConfirm()
        {
            InitializeComponent();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text = "Student No.:    " + StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = "Name:              " + StudentInformationClass.SetFullName;
            lblProgram.Text = "Program:           " + StudentInformationClass.SetProgram;
            lblAge.Text = "Age:                  " + StudentInformationClass.SetAge.ToString();
            lblBirthday.Text = "Birthday:           " + StudentInformationClass.SetBirthday;
            lblGender.Text = "Gender:             " + StudentInformationClass.SetGender;
            lblContactNo.Text = "Contact No.:    " + StudentInformationClass.SetContactNo.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
