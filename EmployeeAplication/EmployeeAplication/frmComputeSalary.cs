using System;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeAplication
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text == "" ||
                    txtLastName.Text == "" ||
                    txtDepartment.Text == "" ||
                    txtJobTitle.Text == "" ||
                    txtRatePerHour.Text == "" ||
                    txtHoursWorked.Text == "")
                {
                    throw new Exception("Please fill in all fields.");
                }

                double ratePerHour = Convert.ToDouble(txtRatePerHour.Text);
                int hoursWorked = Convert.ToInt32(txtHoursWorked.Text);

                if (ratePerHour < 0 || hoursWorked < 0)
                {
                    throw new Exception("Rate per hour and hours worked cannot be negative.");
                }

                PartTimeEmployee employee = new PartTimeEmployee(
                    txtFirstName.Text,
                    txtLastName.Text,
                    txtDepartment.Text,
                    txtJobTitle.Text);

                employee.computeSalary(hoursWorked, ratePerHour);

                lblFirstName.Text = "First name: " + employee.FirstName;
                lblLastName.Text = "Last name: " + employee.LastName;
                lblSalary.Text = "Basic Salary: " +
                                  employee.getSalary().ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter valid numeric values for Rate Per Hour and Hours Worked.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "The number entered is too large.",
                    "Overflow Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void frmComputeSalary_Load(object sender, EventArgs e)
        {

        }
    }
}