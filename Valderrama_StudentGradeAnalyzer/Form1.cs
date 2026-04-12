using System;
using System.Windows.Forms;

namespace Valderrama_StudentGradeAnalyzer
{
    public partial class Form1 : Form
    {
        
        public struct StudentData
        {
            public string StudentNumber;
            public string StudentName;
            public double PrelimGrade;
            public double MidtermGrade;
            public double FinalGrade;
            public double Average;
            public string Remarks;
        }

        public Form1()
        {
            InitializeComponent();
        }

        
        private double ComputeAverage(double prelim, double midterm, double final)
        {
            return (prelim + midterm + final) / 3.0;
        }

        
        private double ComputeAverage(double grade1, double grade2)
        {
            return (grade1 + grade2) / 2.0;
        }

        
        public static string DetermineRemarks(double average)
        {
            if (average >= 75)
                return "Passed";
            else
                return "Failed";
        }

        
        private void DisplayOutput(StudentData student)
        {
            listBoxOutput.Items.Clear();
            listBoxOutput.Items.Add($"Student Number: {student.StudentNumber}");
            listBoxOutput.Items.Add($"Student Name: {student.StudentName}");
            listBoxOutput.Items.Add($"Prelim: {student.PrelimGrade}");
            listBoxOutput.Items.Add($"Midterm: {student.MidtermGrade}");
            listBoxOutput.Items.Add($"Final: {student.FinalGrade}");
            listBoxOutput.Items.Add($"Average: {student.Average:F2}");
            listBoxOutput.Items.Add($"Remarks: {student.Remarks}");
        }

        
        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                StudentData student = new StudentData();

                
                student.StudentNumber = txtStudentNumber.Text;
                student.StudentName = txtStudentName.Text;
                student.PrelimGrade = Convert.ToDouble(txtPrelim.Text);
                student.MidtermGrade = Convert.ToDouble(txtMidterm.Text);
                student.FinalGrade = Convert.ToDouble(txtFinal.Text);

                
                student.Average = ComputeAverage(student.PrelimGrade, student.MidtermGrade, student.FinalGrade);

                
                student.Remarks = DetermineRemarks(student.Average);

                
                DisplayOutput(student);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric grades for Prelim, Midterm, and Final.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void btnClear_Click(object sender, EventArgs e)
        {
            
            txtStudentNumber.Clear();
            txtStudentName.Clear();
            txtPrelim.Clear();
            txtMidterm.Clear();
            txtFinal.Clear();

            
            listBoxOutput.Items.Clear();

            
            txtStudentNumber.Focus();
        }
    }
}