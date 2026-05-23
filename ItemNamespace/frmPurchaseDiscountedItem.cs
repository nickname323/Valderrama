using ItemNamespace;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CashierApplication
{
    public partial class frmPurchaseDiscountedItem : Form
    {
        DiscountedItem item;

        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            string name = txtItem.Text;

            double price = Convert.ToDouble(txtPrice.Text);

            int quantity = Convert.ToInt32(txtQuantity.Text);

            double discount = Convert.ToDouble(txtDiscount.Text);

            item = new DiscountedItem(name, price, quantity, discount);

            lblTotal.Text = item.getTotalPrice().ToString("0.00");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double payment = Convert.ToDouble(txtPayment.Text);

            item.setPayment(payment);

            lblChange.Text = item.getChange().ToString("0.00");
        }
    }
}