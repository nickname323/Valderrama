using System;
using System.Threading;
using System.Windows.Forms;


namespace ThreadPrio  
{
    public partial class frmTrackThread : Form
    {
        public frmTrackThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblThread.Text = "-Thread Starts-";

            
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread2);
            Thread threadC = new Thread(MyThreadClass.Thread1);
            Thread threadD = new Thread(MyThreadClass.Thread2);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";
            threadC.Name = "Thread C";
            threadD.Name = "Thread D";

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            Console.WriteLine("Starting threads: Thread A, Thread B, Thread C, Thread D...");
            Console.WriteLine("-Thread Starts-");

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

           
            Console.WriteLine("-End of Thread-");
            lblThread.Text = "-End of Thread-";
        }
    }
}