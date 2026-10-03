namespace BasicThreading
{
    partial class FrmBasicThread
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
            btnRun = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(72, 116);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(129, 50);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(27, 59);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(225, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "-Before starting thread-";
            // 
            // FrmBasicThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 268);
            Controls.Add(lblStatus);
            Controls.Add(btnRun);
            Name = "FrmBasicThread";
            Text = "BasicThread";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Label lblStatus;
    }
}
