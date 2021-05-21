using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class Empty
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            var reuslt = EmptyMethod(a);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            //Console.WriteLine(reuslt);
        }

        static int[] EmptyMethod(int[] originalArray)
        {
            return new int[3];
        }
    }
}
