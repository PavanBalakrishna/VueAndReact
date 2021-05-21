using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    class BubbleSort
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 9, 22, 2, 4, 5, 3 };
            var reuslt = BubbleSortMethod(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] BubbleSortMethod(int[] originalArray)
        {
            bool isSwapped = true;
            //int i = 0;
            while (isSwapped)
            {
                isSwapped = false;
                for (int i = 0; i < originalArray.Length-1; i++)
                {
                    if (originalArray[i] > originalArray[i + 1])
                    {
                        var temp = originalArray[i + 1];
                        originalArray[i + 1] = originalArray[i];
                        originalArray[i] = temp;
                        isSwapped = true;
                    }
                    
                }

            }

            return originalArray;
        }
    }
}
