using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BasicThreading
{
    public partial class FrmBasicThread : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            AllocConsole();
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