using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SearchingAndSorting
{
    static class  CyclicRotation
    {
		public static void Call()
		{
			int[] a = new int[] { 1, 2, 3, 4, 5 };
			int[] b = new int[] { 4, 5, 1, 2, 3 };

			var resultArray = CyclicRotationMethodTwo(a);
			foreach (var item in resultArray)
			{
				Console.WriteLine(item);
			}
			

		}
        public static  int[] CyclicRotationMethod(int [] originalArray)
        {

			try
			{
				int lastElement = originalArray[originalArray.Length - 1];
				for (int i  = originalArray.Length-1; i >0; i --)
				{
					originalArray[i] = originalArray[i - 1];
				}

				originalArray[0] = lastElement;
			}
			catch (Exception)
			{

				throw;
			}
			return originalArray;
        }

		public static int[] CyclicRotationMethodTwo(int[] originalArray)
		{

			try
			{
				int lastElement = originalArray[originalArray.Length - 1];
				int lastButOneElement = originalArray[originalArray.Length - 2];
				for (int i = originalArray.Length - 1; i > 1; i--)
				{
					originalArray[i] = originalArray[i - 2];
				}

				originalArray[0] = lastButOneElement;
				originalArray[1] = lastElement;
			}
			catch (Exception)
			{

				throw;
			}
			return originalArray;
		}
	}
}
