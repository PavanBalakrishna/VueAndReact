using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class FindOccuranceOfIntergerExcer
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 ,2};
            var reuslt = EmptyMethod(a, 2);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            Console.WriteLine(reuslt);
        }

        static int EmptyMethod(int[] originalArray, int x)
        {
            int occurence = 0;

            try
            {

            }
            catch (Exception)
            {

                throw;
            }

            return occurence;
        }
    }
}
