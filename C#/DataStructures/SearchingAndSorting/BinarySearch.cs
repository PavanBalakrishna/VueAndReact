using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    public static class BinarySearch
    {

        public static  bool BinarySearchIterative(int[] array, int searchElement){
            
            if (array == null )
            {
                return false;
            }

            int min = array[0];
            int max = array[array.Length - 1];

            while (min < max)
            {
                int mid = (min + max) / 2;

                if (searchElement == array[mid])
                {
                    return true;

                }else if (searchElement < array[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return false;
        }

        public static bool BinarySearchRecursive(int[] array , int searchText , int startIndex , int endindex)
        {
            if (array==null || array.Length == 0 )
            {
                return false;
            }

            //Looped through full array
            if (startIndex > endindex)
            {
                return false;
            }

            int mid = (startIndex + endindex) / 2;

            if (array[mid] == searchText)
            {
                return true;
            }
            else if (array[mid] < searchText)
            {
                return BinarySearchRecursive(array, searchText, mid + 1, endindex);
            }
            else
            {
               return BinarySearchRecursive(array, searchText, startIndex, mid);
            }
        }
    }


  
}
