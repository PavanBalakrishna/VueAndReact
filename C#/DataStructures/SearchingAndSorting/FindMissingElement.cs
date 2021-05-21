using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class FindMissingElement
	{
		public static void Call()
		{
			int[] a = new int[] { 1,2,3,5 };
			

			var missingNum = FindMissingElementMethod(a);
			
			
			Console.WriteLine(missingNum);
			
		}

		public static int FindMissingElementMethod(int[] originalArray)
		{
			var lengthOfArray = originalArray.Length + 1;
			int currentSumOfAll = ((lengthOfArray)* (lengthOfArray + 1)) / 2;

			for (int i = 0; i <= originalArray.Length -1 ; i++)
			{
				currentSumOfAll -= originalArray[i];
			}

			return currentSumOfAll;
		}


	}
}
