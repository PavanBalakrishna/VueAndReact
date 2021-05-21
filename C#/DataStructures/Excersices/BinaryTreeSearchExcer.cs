using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class BinaryTreeSearchExcer
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2, 12,44,66,100,2000,4000,1000000};
            var reuslt = EmptyMethod(a,22,0, a.Length -1);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            Console.WriteLine(reuslt);
        }

        static int EmptyMethod(int[] originalArray,int searchkey , int start , int end)
        {
            int midindex = start + end / 2;

            if (start >= end)
            {
                return -1;
            }
            if (originalArray[midindex] == searchkey)
            {
                return midindex;
            }
            else if(searchkey < originalArray[midindex])
            {
                return EmptyMethod(originalArray, searchkey, start, midindex - 1);
            }
            else
            {
                return EmptyMethod(originalArray, searchkey, midindex + 1, end);
            }
        }
    }
}
