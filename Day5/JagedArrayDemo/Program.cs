using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagedArrayDemo
{
    class Program
    {
        static void Main()
        {
            //System.Array
            //Array itself is an abstract class
            //Jaged Array
            int[][] arr1 = new int[3][];
            arr1[0] = new int[3]; //arr1
            arr1[1] = new int[4]; //arr2
            arr1[2] = new int[2]; //arr3 
            //arr1[3] = new int[3]; //arr4
            //arr1[4] = new int[4]; //arr5

            //taking input
            for (int i = 0; i < arr1[0].Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine("Enter elements [[{0}],[{1}]]", i, j);
                    arr1[i][j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //Read Only Values
            for (int i = 0; i < arr1[0].Length; i++)
            {
                for (int j = 0; j < arr1[i].Length; j++)
                {
                    Console.WriteLine("elements [[{0}], [{1}]] is {2}", i, j, arr1[i][j]);
                }
            }

            Console.ReadLine();
        }
    }
}
