using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataStructures.OOPS
{
    public class Main
    {
        public void CallEmployees()
        {
            Employees employees = new Employees();
            
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }
    }

    public class Employees : IEnumerable
    {
        private Employee[] employeeArray = new Employee[500];
       
        
        public IEnumerator GetEnumerator()
        {
            return employeeArray.GetEnumerator();
        }
    }

}
