using System;
using System.Windows.Forms;

namespace StudentGradeApplicationn
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtName.Text == "" ||
                    txtEnglish.Text == "" ||
                    txtMath.Text == "" ||
                    txtScience.Text == "" ||
                    txtFilipino.Text == "" ||
                    txtHistory.Text == "")
                {
                    MessageBox.Show("Please complete all fields.");
                    return;
                }

                
                double eng = Convert.ToDouble(txtEnglish.Text);
                double math = Convert.ToDouble(txtMath.Text);
                double sci = Convert.ToDouble(txtScience.Text);
                double fil = Convert.ToDouble(txtFilipino.Text);
                double hist = Convert.ToDouble(txtHistory.Text);

                
                double average = (eng + math + sci + fil + hist) / 5;

               
                string remarks = average >= 75 ? "The student passed." : "The student failed.";

                
                lblResult.Text = remarks +
                    "\nThe general average of " + txtName.Text +
                    " is " + average.ToString("F2") + ".";
            }
            catch (FormatException)
            {
                MessageBox.Show("Numbers only for grades!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}