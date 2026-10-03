using System;
using System.Threading;

namespace ThreadPrio   
{
    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int LoopCount = 0; LoopCount < 3; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(500); 
            }
        }

        public static void Thread2()
        {
            for (int LoopCount = 0; LoopCount < 6; LoopCount++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + LoopCount);
                Thread.Sleep(1500); 
            }
        }
    }
}