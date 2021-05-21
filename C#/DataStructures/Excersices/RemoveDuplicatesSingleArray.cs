using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class RemoveDuplicatesSingleArray
    {
        internal static void Call()
        {
            int[] a = new int[] { 1,2,3,3,4,5,5 };
            //var reuslt = EmptyMethod(a);
            var resu = removeDuplicates(a, a.Length);
            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            //Console.WriteLine(reuslt);
        }

        static int[] EmptyMethod(int[] originalArray)
        {
            
            int i = 0;
            while (i + 2 < originalArray.Length)
            {
                if (originalArray[i] == originalArray[i+1])
                {
                    originalArray[i + 1] = originalArray[i + 2];
                    
                    
                }

                i++;
            }

            return originalArray;
        }

        static int removeDuplicates(int[] arr, int n)
        {

            if (n == 0 || n == 1)
                return n;

            // To store index of next
            // unique element
            int j = 0;

            // Doing same as done in Method 1
            // Just maintaining another updated
            // index i.e. j
            for (int i = 0; i < n - 1; i++)
                if (arr[i] != arr[i + 1])
                    arr[j++] = arr[i];

            arr[j++] = arr[n - 1];

            return j;
        }
    }
}
