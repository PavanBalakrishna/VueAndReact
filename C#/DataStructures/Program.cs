using DataStructures.SearchingAndSorting;
using System;
using System.Collections;
using System.Collections.Generic;
using DataStructures.Datastructures;
using DataStructures.OOPS;
using System.Threading;
using System.Threading.Tasks;
using DataStructures.Algorithems;
using DataStructures.Excersices;
using DataStructures.Design_Patterns;
using DataStructures.CSharp;//using DataStructures.BitFlyer;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //MystaysLinkedList<string> mystaysLinkedList = new MystaysLinkedList<string>(new MystaysLinkedItem<string>("One"));

            //mystaysLinkedList.InsertBefore("Two", mystaysLinkedList.Head);

            //MystaysLinkedItem<string> linkedItem = mystaysLinkedList.Head;

            //while (linkedItem != null)
            //{
            //    Console.WriteLine(linkedItem.Value);
            //    linkedItem = linkedItem.Next;
            //}

            //MystaysStack<int> mystaysStack = new MystaysStack<int>();
            //for (int i = 0; i < 13; i++)
            //{
            //    mystaysStack.Push(i);
            //}


            //for (int i = 0; i < mystaysStack.Length; i++)
            //{
            //    Console.WriteLine(mystaysStack.Pop());
            //}

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "1");
            ////hashtable.Add(1, "1");
            //hashtable.Add(2, "2");

            //foreach (var key in hashtable.Keys)
            //{
            //    Console.WriteLine(hashtable[key]);
            //}

            //int[] array = new int[] { 1, 4, 6, 7, 13 ,16};

            //Console.WriteLine(BinarySearch.BinarySearchRecursive(array, 1, 0, array.Length - 1));

            //ArrayQueue<string> arrayQueue = new ArrayQueue<string>();

            //arrayQueue.Push("A");
            //arrayQueue.Push("B");
            //arrayQueue.Push("C");
            //arrayQueue.Push("D");

            //while (!arrayQueue.IsEmpty())
            //{
            //    Console.WriteLine(arrayQueue.Pop());
            //}

            //Console.Read();

            //#region abstraction

            //BaseClass a = new DerivedClass();
            //a.DefaultPrint("Pavan");


            //#endregion

            //#region Tuple
            //TupleCLass tupleCLass = new TupleCLass();
            //tupleCLass.EmployeeData = Tuple.Create(1, "pavan", 20);

            //Console.WriteLine(tupleCLass.EmployeeData.Item1);
            //Console.WriteLine(tupleCLass.EmployeeData.Item2);
            //Console.WriteLine(tupleCLass.EmployeeData.Item3);
            //#endregion

            //Calculator concrete = new Calculator();

            //Console.WriteLine(concrete);

            //MyClass myClass = new MyClass();
            //MyStruct myStruct = new MyStruct();

            //myStruct.FirstName = "Pavan Struct";

            //string myclassstring = myClass.ToString();
            //string mystructstring = myStruct.ToString();


            //Console.WriteLine(mystructstring);


            //Variable var = new Variable();
            ////var.test();
            ////Variable var1 = new Variable();
            ////var1.test();


            //// creating an instance 
            //// of class P 
            //P o = new P();

            //// creating an instance 
            //// of class P1 
            //P1 o2 = new P1();

            //// checking whether 'o1' 
            //// is of type 'P' 
            //Console.WriteLine(o is P);

            //// checking whether 'o1' is 
            //// of type Object class 
            //// (Base class for all classes) 
            //Console.WriteLine(o is Object);

            //// checking whether 'o2' 
            //// is of type 'P1' 
            //Console.WriteLine(o2 is P1);

            //// checking whether 'o2' is 
            //// of type Object class 
            //// (Base class for all classes) 
            //Console.WriteLine(o2 is Object);

            //// checking whether 'o2' 
            //// is of type 'P' 
            //// it will return true as P1 
            //// is derived from P 
            //Console.WriteLine(o2 is P);

            //// checking whether o1 
            //// is of type P2 
            //// it will return false 
            //Console.WriteLine(o is P2);

            //// checking whether o2 
            //// is of type P2 
            //// it will return false 
            //Console.WriteLine(o2 is P2);


            //OutAndRef outAndRef = new OutAndRef();

            //int outpar=2;
            //outAndRef.CallOut(out outpar);

            //int refpar=10;
            //outAndRef.CallRef(ref refpar);

            //Console.WriteLine("Out {0}", outpar);
            //Console.WriteLine("Ref {0}", refpar);

            //LINQClass.TestLINQ();

            //HashSet<int> hashSet = new HashSet<int>();

            //hashSet.Add(1);
            //hashSet.Add(2);
            //hashSet.Add(3);
            //hashSet.Add(4);
            //Console.WriteLine("Pavan");
            //Console.Read();

            //Console.WriteLine(ArrayAlgorithems.IsPallindrome(new int[] { 5, 2, 3,2,5 }));

            //Console.WriteLine(ArrayAlgorithems.ReverseString("Pavan"));
            //HashSetHashTableDictionary.CheckDataSet();
            //RefClass.CallMethod();
            //IsPrimeExcer.Call();
            //StackWIthQueues<int> s = new StackWIthQueues<int>();
            //s.push(1);
            //s.push(2);
            //s.push(3);
            //Console.WriteLine("current size: " + s.size());
            //Console.WriteLine(s.top());
            //s.pop();
            //Console.WriteLine(s.top());
            //s.pop();
            //Console.WriteLine(s.top());
            //Console.WriteLine("current size: " + s.size());
            // MoveAllNegativeElements.Call();
            //GetDuplicates.Call();
            //Console.ReadLine();

            ArrayAlgorithems.GetSumZero(new int[] { -1, 0, 1, 2, -1, -4 });
        }

    }
}
