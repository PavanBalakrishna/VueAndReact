using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class FindNthElementFromEndOfLisnkedListExcer
    {
        internal static void Call()
        {

            List<int> ts = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            LinkedList<int> vs = new LinkedList<int>(ts);

            Console.WriteLine(EmptyMethod(vs, 5));


            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            //Console.WriteLine(reuslt);
        }

        static int EmptyMethod(LinkedList<int> vs, int n)
        {
            LinkedListNode<int> p1 = vs.First;
            LinkedListNode<int> p2 = vs.First;


            for (int i = 1; i < n; i++)
            {
                p1= p1.Next;
            }

            while (p1.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }

            return p2.Value;
        }
    }
}
