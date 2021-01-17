using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DArrayDemo
{
    class Program
    {
        static void Main1()
        {
            //System.Array
            //Array itself is an abstract class
            //2D Array
            int[,] arr1 = new int[5, 3];

            Console.WriteLine(arr1.Length); //full lenght
            Console.WriteLine(arr1.Rank); //D
            Console.WriteLine(arr1.GetLength(0)); //1st D
            Console.WriteLine(arr1.GetLength(1)); //2nd D

            Console.WriteLine(arr1.GetUpperBound(0)); //1st D
            Console.WriteLine(arr1.GetLowerBound(0)); //1st D
            Console.WriteLine(arr1.GetUpperBound(1)); //2nd D
            Console.WriteLine(arr1.GetLowerBound(1)); //2nd D

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter marks in std {0} and subj {1}", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }

            }


            //Read Only Values
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("marks for std no {0} subj {1} is {2}", i, j, arr1[i, j]);
                }

            }

            Console.ReadLine();
        }

    }
}
