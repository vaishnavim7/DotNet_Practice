using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionDemo
{
    class Program
    {
        static void Main1()
        {
            List<int> objList = new List<int>();
            objList.Add(10);
            objList.Add(20);
            objList.Add(30);
            Console.WriteLine("Afrte Push");
            foreach (int i in objList)
            {
                Console.WriteLine(i);
            }

            objList.RemoveAt(1);
            objList.RemoveAt(1);
            Console.WriteLine("Afrte Pop");
            foreach (int i in objList)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
