namespace Account_Registration
{
    partial class FrmRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStudentNo = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtMiddleName = new TextBox();
            txtAge = new TextBox();
            txtContactNo = new TextBox();
            txtAddress = new TextBox();
            cbProgram = new ComboBox();
            btnNext = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 21);
            label1.TabIndex = 0;
            label1.Text = "Student No.:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 1;
            label2.Text = "Program:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 76);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(159, 76);
            label4.Name = "label4";
            label4.Size = new Size(89, 21);
            label4.TabIndex = 3;
            label4.Text = "First Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(293, 76);
            label5.Name = "label5";
            label5.Size = new Size(107, 21);
            label5.TabIndex = 4;
            label5.Text = "Middle Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 147);
            label6.Name = "label6";
            label6.Size = new Size(40, 21);
            label6.TabIndex = 5;
            label6.Text = "Age:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(208, 147);
            label7.Name = "label7";
            label7.Size = new Size(94, 21);
            label7.TabIndex = 6;
            label7.Text = "Contact No.:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 222);
            label8.Name = "label8";
            label8.Size = new Size(66, 21);
            label8.TabIndex = 7;
            label8.Text = "Address";
            // 
            // txtStudentNo
            // 
            txtStudentNo.Location = new Point(12, 39);
            txtStudentNo.Name = "txtStudentNo";
            txtStudentNo.Size = new Size(127, 23);
            txtStudentNo.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 110);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(127, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(159, 110);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(89, 23);
            txtFirstName.TabIndex = 10;
            // 
            // txtMiddleName
            // 
            txtMiddleName.Location = new Point(293, 110);
            txtMiddleName.Name = "txtMiddleName";
            txtMiddleName.Size = new Size(127, 23);
            txtMiddleName.TabIndex = 11;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(12, 185);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(59, 23);
            txtAge.TabIndex = 12;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(208, 185);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(127, 23);
            txtContactNo.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 246);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(480, 119);
            txtAddress.TabIndex = 14;
            // 
            // cbProgram
            // 
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "BS in Information Technology", "BS in Computer Science", "BS in Computer Engineering", "BS in Information Systems" });
            cbProgram.Location = new Point(228, 39);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(192, 23);
            cbProgram.TabIndex = 15;
            // 
            // btnNext
            // 
            btnNext.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNext.Location = new Point(345, 383);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(111, 55);
            btnNext.TabIndex = 16;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // FrmRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(504, 450);
            Controls.Add(btnNext);
            Controls.Add(cbProgram);
            Controls.Add(txtAddress);
            Controls.Add(txtContactNo);
            Controls.Add(txtAge);
            Controls.Add(txtMiddleName);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtStudentNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmRegistration";
            Text = "FrmRegistration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStudentNo;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtMiddleName;
        private TextBox txtAge;
        private TextBox txtContactNo;
        private TextBox txtAddress;
        private ComboBox cbProgram;
        private Button btnNext;
    }
}
