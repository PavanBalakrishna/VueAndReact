using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DataStructures.Excersices
{
    class SortingExcer
    {
        internal static void Call()
        {
            int[] a = new int[] { 2,5,7,1,3,0 };
            var reuslt = BubbleSort(a);

            for (int i = 0; i < reuslt.Length; i++)
            {
                Console.WriteLine(reuslt[i]);
            }

            //Console.WriteLine(reuslt);
        }

        private static int[] SelectoinSort(int[] a)
        {
            int minindex = 0;
            for (int i = 0; i <= a.Length -1; i++)
            {
                minindex = i;
                for (int j = i; j <= a.Length - 1; j++)
                {
                    if (a[j] < a[minindex])
                    {
                        minindex = j;
                    }
                }

                int temp = a[i];
                a[i] = a[minindex];
                a[minindex] = temp;
            }

            return a;
        }

        private static int[] BubbleSort(int[] a)
        {
            bool isSwapped = true;
            
            while (isSwapped)
            {
                
                isSwapped = false;

                for (int i = 0; i < a.Length-1; i++)
                {
                    if (a[i] > a[i+1])
                    {
                        var temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        isSwapped = true;
                    }
                    
                }
          

                
            }

            return a;
        }
    }
}
