using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class MoveAllNegativeElements
    {
        public static void Call()
        {
            int[] array = new int[] { -2, 3, -5, 2,-1, 0, 10 ,-4,15,11,-3,9};

            var result = MoveNegElements(array);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            

        }

        private static int[] MoveNegElements(int[] originalArray)
        {
            int length = originalArray.Length - 1;
            int i = 0;
            int j = length;


            while (i <= j)
            {
                if (originalArray[j] < 0 && originalArray[i] >= 0)
                {
                    var temp = originalArray[j];
                    originalArray[j] = originalArray[i];
                    originalArray[i] = temp;
                    i++;
                    j--;
                    continue;
                }
                if (originalArray[j] >= 0)
                {
                    j--;
                    continue;
                }
                if (originalArray[i] < 0)
                {
                    i++;
                    continue;
                }
                if (originalArray[i] >= 0 && originalArray[j] >= 0)
                {
                    j--;
                    continue;
                }
            }

            return originalArray;
        }
    }
}
