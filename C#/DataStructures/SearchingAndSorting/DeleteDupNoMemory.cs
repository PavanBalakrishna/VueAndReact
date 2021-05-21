using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    class DeleteDupNoMemory
    {
        internal static void Call()
        {
            int[] a = new int[] { 1,1,2,2,3,2 };
            var reuslt = DeleteDupNoMemoryM(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] DeleteDupNoMemoryM(int[] originalArray)
        {
            int i=0;
            while (i<originalArray.Length-1 && originalArray[i] == originalArray[i+1])
            {
                if(originalArray[i] == originalArray[i + 1])
                {
                    ShiftArray(ref originalArray, i);
                }
                i++;
            }

            return originalArray;
        }

        private static void ShiftArray(ref int[] originalArray, int index)
        {
            for (int i = index; i < originalArray.Length-1; i++)
            {
                var temp = originalArray[i];
                originalArray[i] = originalArray[i + 1];
                originalArray[i + 1] = temp;
            }
            Array.Resize(ref originalArray, originalArray.Length - 1);


        }
    }
}
