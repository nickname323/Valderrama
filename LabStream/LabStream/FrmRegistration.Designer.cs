namespace LabStream
{
    partial class FrmRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            txtFirstName = new TextBox();
            txtMI = new TextBox();
            txtContactNo = new TextBox();
            cbProgram = new ComboBox();
            cbGender = new ComboBox();
            dtpBirthday = new DateTimePicker();
            btnRegister = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(127, 25);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(100, 60);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(200, 23);
            txtStudentNo.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(100, 109);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(100, 159);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(60, 23);
            txtAge.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(401, 106);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(165, 23);
            txtFirstName.TabIndex = 4;
            // 
            // txtMI
            // 
            txtMI.Location = new Point(622, 110);
            txtMI.Name = "txtMI";
            txtMI.Size = new Size(45, 23);
            txtMI.TabIndex = 5;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(401, 204);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(165, 23);
            txtContactNo.TabIndex = 6;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS Information Techology", "BS Tourism Management", "BS Compute Science" });
            cbProgram.Location = new Point(401, 61);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(222, 23);
            cbProgram.TabIndex = 7;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Female", "Male" });
            cbGender.Location = new Point(401, 155);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            dtpBirthday.Location = new Point(100, 207);
            dtpBirthday.Name = "dtpBirthday";
            dtpBirthday.Size = new Size(200, 23);
            dtpBirthday.TabIndex = 9;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(279, 236);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(121, 42);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(322, 63);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 11;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(4, 60);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 12;
            label3.Text = "Student No.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 13;
            label4.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(310, 109);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 14;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(577, 109);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 15;
            label6.Text = "M.I.:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(52, 158);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 16;
            label7.Text = "Age:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(317, 158);
            label8.Name = "label8";
            label8.Size = new Size(67, 20);
            label8.TabIndex = 17;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 207);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 18;
            label9.Text = "Birthday:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(304, 207);
            label10.Name = "label10";
            label10.Size = new Size(97, 20);
            label10.TabIndex = 19;
            label10.Text = "Contact No.:";
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 284);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(dtpBirthday);
            Controls.Add(cbGender);
            Controls.Add(cbProgram);
            Controls.Add(txtContactNo);
            Controls.Add(txtMI);
            Controls.Add(txtFirstName);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtAge;
        private TextBox txtFirstName;
        private TextBox txtMI;
        private TextBox txtContactNo;
        private ComboBox cbProgram;
        private ComboBox cbGender;
        private DateTimePicker dtpBirthday;
        private Button btnRegister;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}