using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    class Speech
    {
        internal static void Call()
        {
            for (int i = 0; i <= 4; i++)
            {
                var reuslt = CountNSay("1");
            }
            

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            //Console.WriteLine(reuslt);
        }

        static string CountNSay(string curr)
        {
            string result = "";
            int i = 0;
            while (i <= curr.Length)
            {

                int count = 0;
                while (i < curr.Length - 1 && curr[i] == curr[i+1])
                {
                    count++;
                    i++;
                }
                result += count + curr[i];
                i++;
            }

            return result;
        }

    }
}
