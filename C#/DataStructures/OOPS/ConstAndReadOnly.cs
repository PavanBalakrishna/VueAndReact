using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures.OOPS
{

    class ConstAndReadOnly
    {
        private readonly int readonlyprop;
        private const decimal PI = 3.14M;
        public ConstAndReadOnly(int pivalue)
        {
            //Only assign in constructor
            readonlyprop = pivalue;
        }
        
        public void AddMethod(int gg)
        {
            
            const int methodconst= 2;
            int abc = readonlyprop + methodconst;
        }
    }
}
