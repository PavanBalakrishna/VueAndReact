using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Design_Patterns
{
    sealed  class SingletonTwo//: IEnumerable<int>
    {
        private static SingletonTwo instance;
        private SingletonTwo()
        {

        }

        public static SingletonTwo GetInstance()
        {
            if (instance == null)
            {
                instance = new SingletonTwo();
            }

            return instance;
        }

       
    }
}
