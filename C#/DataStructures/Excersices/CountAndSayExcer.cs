using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class CountAndSayExcer
    {
        internal static void Call()
        {

            
            var reuslt = CountAndSayCall("1", 5);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            Console.WriteLine(reuslt);
        }

        static string CountAndSayCall(string expression , int n)
        {
            for (int i = 1; i < n; i++)
            {
                expression = CountAndSay(expression);
            }

            return expression;
        }

        private static string CountAndSay(string expression)
        {
            StringBuilder s = new StringBuilder();
            var characters = expression.ToCharArray();
            int length = characters.Length;
            int ctr = 0;

            while (ctr < length)
            {
                int simulcount = 1;

                while (ctr + 1 < expression.Length && characters[ctr] == characters[ctr+1])
                {
                    simulcount++;
                    ctr++;

                }
                s.Append(simulcount.ToString() + characters[ctr]);
                    ctr++;
            }

            return s.ToString();
        }
    }
}
