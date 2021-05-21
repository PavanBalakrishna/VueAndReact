using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures.OOPS
{
    public static class MutexTest
    {
        private static Mutex mutex = new Mutex();

        public static void THreadProc(int var)
        {
            Console.WriteLine("Hellow {0}", var);
            Thread.Sleep(var * 1000);
            Console.WriteLine("Bye {0}", var);
        }
    }

    public class MutextNonStatic
    {
        public  void TreadProcNonStatic(int var)
        {
            Console.WriteLine("Hellow {0}", var);
            Thread.Sleep(var*1000);
            Console.WriteLine("Bye {0}", var);
        }
    }
}
