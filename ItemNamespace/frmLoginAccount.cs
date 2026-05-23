using System;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        Cashier cashier;

        public frmLoginAccount()
        {
            InitializeComponent();

            cashier = new Cashier(
                "Neilshawn Rafael",
                "IT department",
                "cashier101",
                "12345"
            );
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (cashier.validateLogin(username, password))
            {
                MessageBox.Show(
                    "Welcome " +
                    cashier.getFullName() +
                    " of " +
                    cashier.getDepartment()
                );

                frmPurchaseDiscountedItem frm =
                    new frmPurchaseDiscountedItem();

                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show(
                    "Invalid username or password"
                );
            }
        }
    }
}