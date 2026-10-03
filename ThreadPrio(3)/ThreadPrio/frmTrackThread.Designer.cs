namespace ThreadPrio
{
    partial class frmTrackThread
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblThread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(62, 110);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(135, 44);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread.Location = new System.Drawing.Point(46, 68);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(167, 19);
            this.lblThread.TabIndex = 1;
            this.lblThread.Text = "-Before starting thread-";
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 257);
            this.Controls.Add(this.lblThread);
            this.Controls.Add(this.btnRun);
            this.Name = "frmTrackThread";
            this.Text = "FormTrackThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRun;
        private Label lblThread;
    }
}
