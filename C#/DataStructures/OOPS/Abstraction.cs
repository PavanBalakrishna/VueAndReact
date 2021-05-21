using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("Constructor BaseClass");
        }
        ~BaseClass()
        {
            Console.WriteLine("Destructor BaseClass");
        }
        public virtual void DefaultPrint(string data)
        {
            Console.WriteLine("Base print {0}", data);
        }
        
    }

    public class BaseClass2
    {
        public BaseClass2()
        {
            Console.WriteLine("Constructor BaseClass");
        }
        ~BaseClass2()
        {
            Console.WriteLine("Destructor BaseClass");
        }
        public virtual void DefaultPrint(string data)
        {
            Console.WriteLine("Base print {0}", data);
            
        }
    }

    public abstract class AbstractClass: BaseClass
    {
        public AbstractClass()
        { 
            Console.WriteLine("Constructor AbstractClass");
        }
        public abstract void SetData(string data);

        public virtual new void DefaultPrint(string data)
        {
            Console.WriteLine("Abstract DefaultPrint  print {0}", data);
        }
    }

    public class DerivedClass : AbstractClass
    {
        ~DerivedClass()
        {
            Console.WriteLine("Destruct DerivedClass");
        }

      
        public DerivedClass()
        {
            Console.WriteLine("DerivedClass Constructor");
        }
        public override void SetData(string data)
        {
            Console.WriteLine("DerivedClass SetData {0}", data);
        }

        public override void DefaultPrint(string data)
        {
            Console.WriteLine("DerivedClass DefaultPrint {0}", data);
        }
    }
}
