using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;


namespace DataStructures.SearchingAndSorting
{
    class KthElementFromLinkedList
    {
        internal static void Call()
        {
            List<int> ts = new System.Collections.Generic.List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            LinkedList<int> vs = new LinkedList<int>(ts);
            
            
            
            var reuslt = EmptyMethod(vs, 3);

          
            Console.WriteLine(reuslt);
        }
        static int EmptyMethod(LinkedList<int> originalList, int kthElement)
        {
            int result = 0;

            LinkedListNode<int> p1 = originalList.First;
            LinkedListNode<int> p2 = originalList.First;

            for (int i = 0; i < kthElement -1 ; i++)
            {
                p2 = p2.Next;
            }

            while (p2.Next != null)
            {
                p1 = p1.Next;
                p2 = p2.Next;
            }


            return p1.Value;

        }

        //    static int EmptyMethod(LinkedList<int> originalList, int kthElement)
        //{
        //    int result = 0;
            //int firstELement = 0;
            //int secondELement = 0;

            //for (int i = originalList.Count; i >= kthElement; i--)
            //{
                
            //    secondELement = i;
            //}
            //firstELement = secondELement - 1;

            //int ctr = originalList.Count;
            //LinkedListNode<int> element = originalList.Last;
            //while (ctr > (originalList.Count - kthElement + 1))
            //{
            //    element = element.Previous;
            //    ctr--;
            //}

            //originalList.Remove(element.Next);
            


        //    return element.Value;
        //}
    }
}
