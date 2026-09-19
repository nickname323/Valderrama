namespace OrganizationProfile
{
    partial class frmRegistration
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label lblStudentNoText;
        private System.Windows.Forms.Label lblLastNameText;
        private System.Windows.Forms.Label lblFirstNameText;
        private System.Windows.Forms.Label lblMiddleInitialText;
        private System.Windows.Forms.Label lblAgeText;
        private System.Windows.Forms.Label lblProgramText;
        private System.Windows.Forms.Label lblGenderText;
        private System.Windows.Forms.Label lblBirthdayText;
        private System.Windows.Forms.Label lblContactNoText;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ComboBox cbPrograms;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.lblStudentNoText = new System.Windows.Forms.Label();
            this.lblLastNameText = new System.Windows.Forms.Label();
            this.lblFirstNameText = new System.Windows.Forms.Label();
            this.lblMiddleInitialText = new System.Windows.Forms.Label();
            this.lblAgeText = new System.Windows.Forms.Label();
            this.lblProgramText = new System.Windows.Forms.Label();
            this.lblGenderText = new System.Windows.Forms.Label();
            this.lblBirthdayText = new System.Windows.Forms.Label();
            this.lblContactNoText = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.cbPrograms = new System.Windows.Forms.ComboBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.Text = "Organization Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ClientSize = new System.Drawing.Size(550, 315);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblRegistration.Location = new System.Drawing.Point(15, 12);
            this.lblRegistration.Text = "Registration";

            this.lblStudentNoText.AutoSize = true;
            this.lblStudentNoText.Location = new System.Drawing.Point(18, 65);
            this.lblStudentNoText.Text = "Student No.";

            this.txtStudentNo.Location = new System.Drawing.Point(105, 62);
            this.txtStudentNo.Size = new System.Drawing.Size(130, 20);

            this.lblProgramText.AutoSize = true;
            this.lblProgramText.Location = new System.Drawing.Point(280, 65);
            this.lblProgramText.Text = "Program";

            this.cbPrograms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrograms.Location = new System.Drawing.Point(345, 62);
            this.cbPrograms.Size = new System.Drawing.Size(185, 21);

            this.lblLastNameText.AutoSize = true;
            this.lblLastNameText.Location = new System.Drawing.Point(18, 100);
            this.lblLastNameText.Text = "Last Name";

            this.txtLastName.Location = new System.Drawing.Point(105, 97);
            this.txtLastName.Size = new System.Drawing.Size(130, 20);

            this.lblFirstNameText.AutoSize = true;
            this.lblFirstNameText.Location = new System.Drawing.Point(255, 100);
            this.lblFirstNameText.Text = "First Name";

            this.txtFirstName.Location = new System.Drawing.Point(325, 97);
            this.txtFirstName.Size = new System.Drawing.Size(120, 20);

            this.lblMiddleInitialText.AutoSize = true;
            this.lblMiddleInitialText.Location = new System.Drawing.Point(455, 100);
            this.lblMiddleInitialText.Text = "M.I.";

            this.txtMiddleInitial.Location = new System.Drawing.Point(480, 97);
            this.txtMiddleInitial.Size = new System.Drawing.Size(50, 20);

            this.lblAgeText.AutoSize = true;
            this.lblAgeText.Location = new System.Drawing.Point(65, 135);
            this.lblAgeText.Text = "Age";

            this.txtAge.Location = new System.Drawing.Point(105, 132);
            this.txtAge.Size = new System.Drawing.Size(90, 20);

            this.lblGenderText.AutoSize = true;
            this.lblGenderText.Location = new System.Drawing.Point(280, 135);
            this.lblGenderText.Text = "Gender";

            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.Location = new System.Drawing.Point(345, 132);
            this.cbGender.Size = new System.Drawing.Size(110, 21);

            this.lblBirthdayText.AutoSize = true;
            this.lblBirthdayText.Location = new System.Drawing.Point(40, 180);
            this.lblBirthdayText.Text = "Birthday";

            this.datePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerBirthday.Location = new System.Drawing.Point(105, 177);
            this.datePickerBirthday.Size = new System.Drawing.Size(245, 20);

            this.lblContactNoText.AutoSize = true;
            this.lblContactNoText.Location = new System.Drawing.Point(365, 180);
            this.lblContactNoText.Text = "Contact No.";

            this.txtContactNo.Location = new System.Drawing.Point(440, 177);
            this.txtContactNo.Size = new System.Drawing.Size(90, 20);

            this.btnRegister.Location = new System.Drawing.Point(235, 235);
            this.btnRegister.Size = new System.Drawing.Size(90, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.lblStudentNoText);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblProgramText);
            this.Controls.Add(this.cbPrograms);
            this.Controls.Add(this.lblLastNameText);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstNameText);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblMiddleInitialText);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.lblAgeText);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblGenderText);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.lblBirthdayText);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.lblContactNoText);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.btnRegister);

            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
