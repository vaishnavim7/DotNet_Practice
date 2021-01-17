using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main()
        {
            ArrayList obj = new ArrayList();
            //obj.Add();
            //obj.Remove();
            //obj.RemoveAt();
            //obj.Count();

            obj.Add(10);
            obj.Add("mana");
            obj.Add(7.2);
            obj.Add(true);

            foreach(object o in obj)
            {
                Console.WriteLine(o);
            }

            obj.Remove("mana");
            obj.RemoveAt(0);

            Console.WriteLine(obj.Count);

            //obj.Capacity = 100;
            //Console.WriteLine( obj.Capacity);

            //objArrayList.TrimToSize()

            //obj.Clear
            //bool isThere = obj.Contains(10);
            //obj.CopyTo(arr)
            //obj.Insert(0, "aa");
            // obj.InsertRange
            //obj.RemoveRange
            //object[] arr = obj.ToArray();


            //obj.AddRange(obj2);

            //objArrayList.BinarySearch
            //objArrayList.IndexOf
            //objArrayList.LastIndexOf
            Console.ReadLine();
        }
    }

    
}
