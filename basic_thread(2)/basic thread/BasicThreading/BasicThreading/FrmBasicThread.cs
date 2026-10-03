using System;
using System.Threading;
using System.Windows.Forms;


namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread1);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            lblStatus.Text = "-End of Thread-";
            Console.WriteLine("-End of Thread-");
        }
    }
}