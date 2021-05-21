using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.OOPS
{
    public static class HashSetHashTableDictionary
    {
        public static void CheckDataSet()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 50);
            hashtable.Add("pavan", 90);
            hashtable.Add("pavan", 190);


            HashSet<string> hs = new HashSet<string>();

            hs.Add("Pavan");
            hs.Add("Pavan");
            hs.Add("Kruthika");
           var i =  hs.Count;

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "pavan");
            keyValuePairs.Add(3, "pavan1");
            keyValuePairs.Add(2, "kk");


            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add(1);
            arrayList.Add("pavan");


            
        }
    }
}
