using System;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();

            cal = new CalculatorClass();

            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            switch (cbOperator.Text)
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    break;

                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    break;

                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }

                    cal.CalculateEvent += cal.GetQuotient;
                    break;

                default:
                    MessageBox.Show("Please select an operator.");
                    return;
            }

            double total = cal.Calculate(num1, num2);

            lblDisplayTotal.Text = total.ToString();

            switch (cbOperator.Text)
            {
                case "+":
                    cal.CalculateEvent -= cal.GetSum;
                    break;

                case "-":
                    cal.CalculateEvent -= cal.GetDifference;
                    break;

                case "*":
                    cal.CalculateEvent -= cal.GetProduct;
                    break;

                case "/":
                    cal.CalculateEvent -= cal.GetQuotient;
                    break;
            }
        }
    }
}


