using System;
using System.Collections.Generic;

using System.Linq;

namespace DataStructures.OOPS
{
    static  class LINQClass
    {
        public static void TestLINQ()
        {
            
            List<LINQEmployee> employees = new List<LINQEmployee>();

            employees.Add(new LINQEmployee(1,"Pavan","B1"));
            
            employees.Add(new LINQEmployee(2, "Puneeth", "B2"));
            employees.Add(new LINQEmployee(3, "Kruthika", "K"));
            employees.Add(new LINQEmployee(4, "Balakrishna", "HN"));
            employees.Add(new LINQEmployee(5, "Mohini", "k"));

            List<LINQEmployee> employeesNew = new List<LINQEmployee>();

            employeesNew.Add(new LINQEmployee(1, "PavanNew", "B1"));
            employeesNew.Add(new LINQEmployee(5, "PuneethNew", "B2"));



            var grouped = from e in employees
                          join f in employeesNew
                          on e.LastName equals f.LastName
                          select new { first = e.FIrstName, second = f.FIrstName };
                          //orderby e.FIrstName, e.LastName
                          //select e;
                          //group f by new { e.FIrstName, f.LastName };
                            

            foreach (var emgroup in grouped)
            {
                //Console.WriteLine(emgroup.Key);

                //foreach (var gemployee in emgroup)
                //{
                //    Console.WriteLine("Firstname - {0}", gemployee.FIrstName);
                //}
                Console.WriteLine(emgroup);
                //Console.WriteLine(grouped.Count());
            }
                                          
        }
    }

    public class LINQEmployee
    {
        public LINQEmployee(int id, string fname, string lname)
        {
            this.ID = id;
            this.FIrstName = fname;
            this.LastName = lname;
            
        }
        public int ID { get; set; }
        public string FIrstName { get; set; }
        public string LastName { get; set; }

        public DateTime DOB { get; set; }
    }
}
