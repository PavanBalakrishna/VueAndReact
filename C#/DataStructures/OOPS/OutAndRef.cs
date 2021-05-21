using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    class OutAndRef
    {
        public void CallRef(ref int refvar)
        {
            refvar = 30;
        }

        public void CallOut(out int outvar)
        {
            outvar = 40;
        }
    }

    class RefClass
    {
        public int refprop { get; set; }
        public int outprop { get; set; }

        public static void CallMethod()
        {
            int vaiable;
            OutAndRef outAndRef = new OutAndRef();

            outAndRef.CallOut(out vaiable);
            outAndRef.CallRef(ref vaiable);

        }
    }

}
