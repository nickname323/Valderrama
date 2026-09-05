using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private StudentInfoClass.DelegateText DelProgram;
        private StudentInfoClass.DelegateText DelLastName;
        private StudentInfoClass.DelegateText DelFirstName;
        private StudentInfoClass.DelegateText DelMiddleName;
        private StudentInfoClass.DelegateText DelAddress;

        private StudentInfoClass.DelegateNumber DelStudentNo;
        private StudentInfoClass.DelegateNumber DelAge;
        private StudentInfoClass.DelegateNumber DelContactNo;

        private bool isConfirmed = false;

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram =
                new StudentInfoClass.DelegateText(
                    StudentInfoClass.GetProgram);

            DelLastName =
                new StudentInfoClass.DelegateText(
                    StudentInfoClass.GetLastName);

            DelFirstName =
                new StudentInfoClass.DelegateText(
                    StudentInfoClass.GetFirstName);

            DelMiddleName =
                new StudentInfoClass.DelegateText(
                    StudentInfoClass.GetMiddleName);

            DelAddress =
                new StudentInfoClass.DelegateText(
                    StudentInfoClass.GetAddress);

            DelStudentNo =
                new StudentInfoClass.DelegateNumber(
                    StudentInfoClass.GetStudentNo);

            DelAge =
                new StudentInfoClass.DelegateNumber(
                    StudentInfoClass.GetAge);

            DelContactNo =
                new StudentInfoClass.DelegateNumber(
                    StudentInfoClass.GetContactNo);
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            lblStudentNo.Text =
                DelStudentNo(StudentInfoClass.StudentNo).ToString();

            lblProgram.Text =
                DelProgram(StudentInfoClass.Program);

            lblLastName.Text =
                DelLastName(StudentInfoClass.LastName);

            lblFirstName.Text =
                DelFirstName(StudentInfoClass.FirstName);

            lblMiddleName.Text =
                DelMiddleName(StudentInfoClass.MiddleName);

            lblAge.Text =
                DelAge(StudentInfoClass.Age).ToString();

            lblContactNo.Text =
                DelContactNo(StudentInfoClass.ContactNo).ToString();

            lblAddress.Text =
                DelAddress(StudentInfoClass.Address);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Registration successful!",
                "Account Registration",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            isConfirmed = true;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void FrmConfirm_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (isConfirmed)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }
    }
}