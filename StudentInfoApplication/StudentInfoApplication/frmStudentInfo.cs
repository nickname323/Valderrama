using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (txtStudentID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }


            StudentInfo student = new StudentInfo(
                txtStudentID.Text,
                txtFirstName.Text,
                txtLastName.Text
            );


            lstStudentID.Items.Add(student.StudentID);
            lstFirstName.Items.Add(student.FirstName);
            lstLastName.Items.Add(student.LastName);


            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
        }
    }
}
