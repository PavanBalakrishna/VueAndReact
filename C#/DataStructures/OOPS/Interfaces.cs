using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    public interface IMyinterface
    {
        int AddNumbers(int a, int b);
        int SubNumbers(int a, int b);
    }

    public interface IMyinterface2
    {
        int MulNumbers(int a, int b);
        int DivideNumbers(int a, int b);
    }

    public class Calculator : IMyinterface, IMyinterface2
    {
        public int AddNumbers(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int SubNumbers(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IMyinterface2.DivideNumbers(int a, int b)
        {
            throw new NotImplementedException();
        }

        int IMyinterface2.MulNumbers(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

    public class MainInterface
    {
        public void CallInterface()
        {
            //See different methods available when the object is created 
            IMyinterface myinterface = new Calculator();
            IMyinterface2 myinterface2 = new Calculator();
            Calculator concrete = new Calculator();
            


        }
    }
}
