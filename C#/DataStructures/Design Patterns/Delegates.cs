using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Design_Patterns
{
    
    static class Delegates
    {
        private delegate int NumbersDelegate(ref int a,ref int b);

        public static void Call()
        {
            NumbersDelegate del1 = new NumbersDelegate(AddNumbers);
            NumbersDelegate del2 = new NumbersDelegate(SubNumbers);
            NumbersDelegate del3 = new NumbersDelegate(MultiplyNumbers);
            NumbersDelegate del4 = new NumbersDelegate(DivideNumbers);

            NumbersDelegate chainDel = del1 + del3;
            int a = 2;
            int b = 3;

            Console.WriteLine(chainDel(ref a, ref b));
        }

        public static int AddNumbers(ref int a, ref int b)
        {
            a++;
            b++;
            return a + b;
        }

        public static int SubNumbers(ref int a, ref int b)
        {
            return a - b;
        }
        public static int MultiplyNumbers(ref int a, ref int b)
        {
            a++;
            b++;
            return a * b;
        }

        public static int DivideNumbers(ref int a, ref int b)
        {
            return a / b;
        }
    }
}
