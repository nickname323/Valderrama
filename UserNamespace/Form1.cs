using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserNamespace
{
    public partial class Form1 : Form
    {
        Administrator currentAdmin = new Administrator("Ewan", "admin123", "password123");

        public Form1()
        {
            InitializeComponent();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (currentAdmin.verifyLogin(txtUsername.Text, txtPassword.Text))
            {

                grpAdminPanel.Enabled = true;
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewAdminName.Text))
            {
                currentAdmin.updatePassword(txtNewPassword.Text);
                txtNewPassword.Clear();
            }

        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNewAdminName.Text))
            {
                currentAdmin.updateAdminName(txtNewAdminName.Text);
                txtNewAdminName.Clear();
            }
        }
    }
            
    
}





