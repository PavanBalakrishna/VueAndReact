using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    public class SealedClass
    {
        protected void GetData()
        {

        }
    }

    public class DerivedSealClass: SealedClass
    {
        public void GetDeriveddata()
        {
            base.GetData();
        }
    }

    public class MainCall
    {
        public void CallClass()
        {
            SealedClass s = new SealedClass();
            
            DerivedSealClass d = new DerivedSealClass();
            
        }
    }
}
