using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class QuickSort
    {
        static void Call()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int middle = a[a.Length / 2];
            var reuslt = QuickSortMethod(a,middle);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            //Console.WriteLine(reuslt);
        }

        static int[] QuickSortMethod(int[] originalArray, int pivot)
        {
            return null;
        }
    }
}
