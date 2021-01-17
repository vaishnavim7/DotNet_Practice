using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAppDay6
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("==================HashTable==================");
            //not in order
            Hashtable obj = new Hashtable();
            obj.Add(1, "abc");
            obj.Add(2, "pqr");
            obj.Add(3, "xyz");

            obj[4] = "hello";
            obj[5] = "hi";


            //obj.Remove(2);
            //obj.Clear();
            //obj.Contains(2);
            //obj.ContainsKey(2);
            //obj.CopyTo();
            //Console.WriteLine("Count : "+obj.Count);
            //Console.WriteLine("GetType : "+obj.GetType());
            //Console.WriteLine("GetHashCode : " + obj.GetHashCode());
            

            foreach (DictionaryEntry d in obj)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }

            
            Console.WriteLine("==================SortedList==================");
            //in order
            SortedList obj2 = new SortedList();
            obj2.Add(1, "abc");
            obj2.Add(2, "pqr");
            obj2.Add(3, "xyz");

            obj2[4] = "hello";
            obj2[5] = "hi";

            //obj2.Remove(3);
            //obj2.Clear();
            //obj2.Contains(2);
            //obj2.ContainsKey(2);
            //obj2.CopyTo();
            //Console.WriteLine("Count : " + obj2.Count);
            //Console.WriteLine("GetByIndex : " + obj2.GetByIndex(0));
            //Console.WriteLine("GetHashCode : " + obj2.GetHashCode());
            //Console.WriteLine("GetKey : " + obj2.GetKey(3));

            //Console.WriteLine("GetKeyList : " + obj2.GetKeyList());
            //ArrayList objKey = (ArrayList)obj2.GetKeyList();
            //Console.WriteLine("GetKeyList : " +objKey);
            
            foreach (DictionaryEntry d in obj2)
            {
                Console.WriteLine(d.Key);
                Console.WriteLine(d.Value);
            }

            Console.ReadLine();
        }
    }
}
