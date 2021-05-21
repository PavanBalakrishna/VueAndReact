using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    class MyClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }
    }

    struct MyStruct
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }

    class CallerClass
    {
        void CallStruct()
        {
            MyStruct s = new MyStruct();
            
            
        }
    }
}
