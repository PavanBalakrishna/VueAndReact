using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class CommonElementsThree
    {
       internal static void Call()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] b = new int[] { 1,3};
            int[] c = new int[] { 1,3, 4, 5 };
            var reuslt = CommonMethod(a,b,c);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] CommonMethod(int[] arrayA, int[] arrayB, int[] arrayC)
        {
            //Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            HashSet<int> hs1 = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
            HashSet<int> hs3 = new HashSet<int>();

            for (int i = 0; i < arrayA.Length; i++)
            {
                if (!hs1.Contains(arrayA[i]))
                {
                    hs1.Add(arrayA[i]);
                }
               
            }

            for (int j = 0; j < arrayB.Length; j++)
            {
                if (hs1.Contains(arrayB[j]))
                {
                    hs2.Add(arrayB[j]);
                }
            }


            for (int k = 0; k < arrayC.Length; k++)
            {
                if (hs2.Contains(arrayC[k]))
                {
                    hs3.Add(arrayC[k]);
                }
            }

            return hs3.ToArray();



        }
    }
}
