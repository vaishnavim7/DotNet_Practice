using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionDemo
{
    class Program2
    {
        static void Main2()
        {
            Console.WriteLine("==================SortedList==================");
            //in order
            SortedList<int, string> objSList = new SortedList<int, string>();
            objSList.Add(1, "abc");
            objSList.Add(2, "pqr");
            objSList.Add(3, "xyz");

            objSList[4] = "hello";
            objSList[5] = "hi";

            foreach (KeyValuePair<int, string> kv in objSList)
            {
                Console.WriteLine(kv.Key);
                Console.WriteLine(kv.Value);
            }

            objSList.Remove(3);
            objSList.Remove(4);

            foreach (KeyValuePair<int, string> kv in objSList)
            {
                Console.WriteLine(kv.Key);
                Console.WriteLine(kv.Value);
            }
            Console.ReadLine();
        }
    }
}
