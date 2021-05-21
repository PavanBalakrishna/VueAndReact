using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class TPL
    {
        public void RunTask()
        {
            Task t = new Task(new Action(()=>
            {
                Console.WriteLine("Hello");
            }));

            TaskFactory fac = new TaskFactory();
            
        }
    }
}
