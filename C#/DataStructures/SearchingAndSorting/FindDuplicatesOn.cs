using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class FindDuplicatesOn
    {
        internal static void Call()
        {
            int[] a = new int[] { 1, 2,4, 3, 4, 5 };
            var reuslt = FindDuplicatesOnMethod(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        static int[] FindDuplicatesOnMethod(int[] originalArray)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();

            for (int i = 0; i < originalArray.Length; i++)
            {
                if (hm.ContainsKey(originalArray[i])!=true) 
                {
                    hm[originalArray[i]] = 0;
                }
                else
                {
                    hm[originalArray[i]]++;
                }

            }

            return hm.Where((kv) => kv.Value > 0)
                .Select((kv)=> kv.Key).ToArray();
        }
    }
}
