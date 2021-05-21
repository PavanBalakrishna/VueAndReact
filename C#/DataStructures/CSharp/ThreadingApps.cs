using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures.CSharp
{
    class ThreadingApps
    {
        static string par = "bbb";
        public static void CallThreads()
        {
            Console.WriteLine("start");
            Thread t1 = new Thread(LongRunningTask);
            Thread t2 = new Thread(LongRunningTaskTwo);

            t1.Start(par);
            t2.Start(par);


            Console.WriteLine("End");
        }

        public static void LongRunningTask(object aaa)
        {
            Console.WriteLine(par);
            //Thread.Sleep(5000);
            par = "ccc";
            

            //return a;
        }

        public static void LongRunningTaskTwo(object aaa)
        {
            Thread.Sleep(5000);
            Console.WriteLine(par);

            //return a;
        }
    }
}
