using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class ChekinSegment
    {
       internal static void Call()
        {
            int[] a = new int[] { 1, 2, 3,4, 5,2,7,9 ,2};
            var reuslt = EmptyMethod(a,3,2);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            Console.WriteLine(reuslt);
        }

        static bool EmptyMethod(int[] originalArray,int segment, int findvalue)
        {
            bool containsKey = true;
            
            //for (int i = 0; i < originalArray.Length; i++)
            int i = 0;
            while(i< originalArray.Length)
            {
                int[] segmentArray = new int[segment];
                int j = 0;
                while (j < segment && i < originalArray.Length)
                {
                    segmentArray[j] = originalArray[i];
                    j++;
                    i++;
                }

                if (!segmentArray.Contains(findvalue))
                {
                    containsKey = false;
                    break;
                }

            }
            return containsKey;


        }
    }
}
