using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class SelectionSort
    {
        internal static void Call()
        {
            int[] a = new int[] { 1,9,22, 2, 4, 5,3 };
            var reuslt = SelectionSortMethod(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] SelectionSortMethod(int[] originalArray)
        {
            
            for (int i = 0; i < originalArray.Length; i++)
            {
                //Set current value to index value
                int minIndex = i;

                for (int j = i+1; j < originalArray.Length; j++)
                {
                    //If value is lower than current value then set 
                    if (originalArray[j] < originalArray[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = originalArray[minIndex];
                originalArray[minIndex] = originalArray[i];
                originalArray[i] = temp;

            }

            return originalArray;
        }
    }
}
