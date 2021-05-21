using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    class KthLargestAndSmallest
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2, 4,3, 5,6 };
            var reuslt = KthLargestAndSmallestMethod(a,3);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] KthLargestAndSmallestMethod(int[] originalArray, int kthIndex)
        {
            var sortedArray = Sort(originalArray);

            int minValue = sortedArray[kthIndex-1];
            int maxValue = sortedArray[sortedArray.Length - kthIndex];

            int[] minmaxarray = new int[2];
            minmaxarray[0] = minValue;
            minmaxarray[1] = maxValue;

            return minmaxarray;
        }

        static int[] Sort(int[] originalArray)
        {
            

            for (int i = 0; i < originalArray.Length; i++)
            {
                int minIndex = i;
                for (int k = i; k < originalArray.Length; k++)
                {
                    if (originalArray[k] < originalArray[minIndex])
                    {
                        minIndex = k;
                    }
                    

                }
                var swwap = originalArray[i];
                originalArray[i] = originalArray[minIndex];
                originalArray[minIndex] = swwap;

            }

            return originalArray;
        }
    }
}
