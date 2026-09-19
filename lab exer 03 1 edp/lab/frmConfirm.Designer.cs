namespace OrganizationProfile
{
    partial class frmConfirm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Button btnSubmit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text = "Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ClientSize = new System.Drawing.Size(370, 315);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.lblStudentNo.AutoSize = true;
            this.lblStudentNo.Location = new System.Drawing.Point(20, 35);
            this.lblStudentNo.Text = "Student No.:";

            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, 75);
            this.lblName.Text = "Name:";

            this.lblProgram.AutoSize = true;
            this.lblProgram.Location = new System.Drawing.Point(20, 115);
            this.lblProgram.Text = "Program:";

            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(20, 155);
            this.lblAge.Text = "Age:";

            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Location = new System.Drawing.Point(20, 195);
            this.lblBirthday.Text = "Birthday:";

            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 235);
            this.lblGender.Text = "Gender:";

            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(20, 275);
            this.lblContactNo.Text = "Contact No.:";

            this.btnSubmit.Location = new System.Drawing.Point(265, 245);
            this.btnSubmit.Size = new System.Drawing.Size(80, 30);
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.btnSubmit);

            this.Load += new System.EventHandler(this.frmConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
