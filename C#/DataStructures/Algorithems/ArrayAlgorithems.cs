using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Algorithems
{
    static class ArrayAlgorithems
    {
        public static bool IsPallindrome(int[] array)
        {
            bool isPallindrome = true;
            for (int i = 0; i <= array.Length-1; i++)
            {

                int indexLastElement = (array.Length - 1 - i);
                if (i >= indexLastElement)
                {
                    break;
                }

                if (array[i] != array[indexLastElement])
                {
                    isPallindrome = false;
                    break;
                }
            }

            return isPallindrome;
        }

        


        public static string ReverseString(string mystring)
        {
            char[] charArray = mystring.ToCharArray();
            int i = 0;
            int lastIndex = charArray.Length - 1 - i;
            while (i < lastIndex) {

                lastIndex= charArray.Length - 1 - i;
                char temp = charArray[i];
                charArray[i] = charArray[lastIndex];
                charArray[charArray.Length - 1 - i] = temp;
                i++;

            }

            return new String(charArray);
        }


        //static int RemoveDuplicates(int[] orgArray)
        //{
        //    //int[] temp = new int[orgArray.Length];
        //    int j = 0;

        //    for (int i = 0; i < orgArray.Length -1; i++)
        //    {
        //        if (orgArray[i] != orgArray[i+1])
        //        {
        //            orgArray[j++] = orgArray[i];
        //        }
        //    }

        //    orgArray[j++] = orgArray[orgArray.Length - 1];

        //    return j;
        //}

        static string CountAndSayCall(int n)
        {
            string expression = "1";
            for (int i = 0; i <= n; i++)
            {
                expression = CountAndSay(expression);
            }

            return expression;
        }

        static string CountAndSay(string expression)
        {
            string newExpression = "";
            char[] charArray = expression.ToCharArray();
            int lengthOfArray = charArray.Length;

            int mainCtr = 0;
            while (mainCtr < lengthOfArray)
            {
                int simulCtr = 1;

                while (mainCtr < lengthOfArray - 1 && charArray[mainCtr] == charArray[mainCtr + 1])
                {
                    simulCtr++;
                    mainCtr++;
                }

                newExpression += simulCtr.ToString() + charArray[mainCtr];
                mainCtr++;
            }

            return newExpression;
        }


        static int GetNthElementFromEnd(LinkedList<int> ls, int index)
        {
            LinkedListNode<int> p1 = ls.First;
            LinkedListNode<int> p2 = ls.First;

            for (int i = 1; i < index; i++)
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

        public static List<Tuple<int, int, int>> GetSumZero(int[] array)
        {
            Array.Sort(array);
            List<Tuple<int,int,int>> list = new List<Tuple<int, int, int>>();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    for (int k = j + 1; k < array.Length; k++)
                    {
                        if (array[i] + array[j] + array[k] == 0)
                        {
                            Tuple<int, int, int> t = new Tuple<int, int, int>(array[i], array[j], array[k]);
                            //if(!list.Contains(t))
                                list.Add(t);
                        }
                    }
                }
            }




            return list;
        }
    }
}
