using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysDemo
{
    class Program
    {
        static void Main1()
        {
            //System.Array
            //Array itself is an abstract class
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Enter elements in no {0}", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Array.Clear(arr1, 0, 5);

            //Array.Copy(arr1, arr2, 5);

            //Array.ConstrainedCopy(arr1, 2, arr2, 4, 5);

            //Array.CreateInstance(typeof(int),0);

            //int pos1 = Array.IndexOf(arr1, 5);
            //Console.WriteLine(pos1);

            //int pos2 = Array.LastIndexOf(arr1, 5);
            //Console.WriteLine(pos2);

            //int pos3 = Array.BinarySearch(arr1, 7);
            //Console.WriteLine(pos3);

            //Array.Reverse(arr1);

            Array.Sort(arr1);

            //Read Only Values
            foreach (int x in arr1)
            {
                Console.WriteLine("Value is X {0} ", x);
            }

            //foreach (int y in arr2)
            //{
            //    Console.WriteLine("Value is Y {0} ", y);
            //}
            Console.ReadLine();
        }
    }
}
