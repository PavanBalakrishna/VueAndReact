using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Excersices
{
    class IsPrimeExcer
    {
        internal static void Call()
        {
            
            var reuslt = EmptyMethod2(91);

            //for (int i = 0; i < reuslt.Length; i++)
            //{
            //    Console.WriteLine(reuslt[i]);
            //}

            Console.WriteLine(reuslt);
        }

        static bool EmptyMethod(int number)
        {
            

            if (number == 0 || number == 1)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            for (int i = 3; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        static bool EmptyMethod2(int number)
        {


            if (number == 0 || number == 1)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            var half = Math.Floor(Math.Sqrt(number));

            for (int i = 3; i < half; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
    }
}
