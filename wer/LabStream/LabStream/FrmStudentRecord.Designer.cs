using System.Drawing;
using System.Windows.Forms;

namespace LabStream
{
    partial class FrmStudentRecord
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtRecord = new TextBox();
            btnRegister = new Button();
            btnFind = new Button();
            btnUpload = new Button();
            SuspendLayout();
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 32);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(98, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "View Record";
            // txtRecord
            txtRecord.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRecord.Location = new Point(13, 58);
            txtRecord.Multiline = true;
            txtRecord.Name = "txtRecord";
            txtRecord.ReadOnly = true;
            txtRecord.ScrollBars = ScrollBars.Vertical;
            txtRecord.Size = new Size(352, 143);
            txtRecord.TabIndex = 1;
            // btnRegister
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(372, 59);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(84, 26);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // btnFind
            btnFind.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFind.Location = new Point(372, 91);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(84, 26);
            btnFind.TabIndex = 3;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // btnUpload
            btnUpload.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(372, 123);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(84, 26);
            btnUpload.TabIndex = 4;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // FrmStudentRecord
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 218);
            Controls.Add(btnUpload);
            Controls.Add(btnFind);
            Controls.Add(btnRegister);
            Controls.Add(txtRecord);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStudentRecord";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmStudentRecord";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private TextBox txtRecord;
        private Button btnRegister;
        private Button btnFind;
        private Button btnUpload;
    }
}
