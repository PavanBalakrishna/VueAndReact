using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class ReverseAString
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            var reuslt = ReverseAStringMethod(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        //static int[] ReverseAStringMethod(int[] originalArray)
        //{
        //    try
        //    {
        //        int startIndex = 0;
        //        int endIndex = originalArray.Length - 1;

        //        while (startIndex < endIndex)
        //        {
        //            int temp = originalArray[endIndex];
        //            originalArray[endIndex] = originalArray[startIndex];
        //            originalArray[startIndex] = temp;

        //            startIndex++;
        //            endIndex--;

        //        }
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return originalArray;
        //}

        static int[] ReverseAStringMethod(int[] originalString)
        {
            try
            {
                int start = 0;
                int end = originalString.Length - 1;

                while (start<end)
                {
                    int temp = originalString[start];
                    originalString[start] = originalString[end];
                    originalString[end] = temp;

                    start++;
                    end--;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return originalString;
        } 
    }
}
