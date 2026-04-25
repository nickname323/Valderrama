using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EmployeeNamespace;

namespace EmployeeApplication
{
    public partial class frmEmployeeDatabase : Form
    {
        List<Employee> employees = new List<Employee>();

        public frmEmployeeDatabase()
        {
            InitializeComponent();

            
            dgvEmployees.ColumnCount = 4;
            dgvEmployees.Columns[0].Name = "ID";
            dgvEmployees.Columns[1].Name = "First Name";
            dgvEmployees.Columns[2].Name = "Last Name";
            dgvEmployees.Columns[3].Name = "Position";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (txtId.Text == "" || txtFirstName.Text == "" ||
                txtLastName.Text == "" || txtPosition.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);

            
            foreach (var emp in employees)
            {
                if (emp.Id == id)
                {
                    MessageBox.Show("Employee ID already exists!");
                    return;
                }
            }

            
            Employee newEmployee = new Employee(
                id,
                txtFirstName.Text,
                txtLastName.Text,
                txtPosition.Text
            );

            employees.Add(newEmployee);

            
            dgvEmployees.Rows.Add(
                newEmployee.Id,
                newEmployee.FirstName,
                newEmployee.LastName,
                newEmployee.Position
            );

            
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPosition.Clear();
        }
    }
}