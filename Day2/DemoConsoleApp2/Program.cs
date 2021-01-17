using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp2
{
    class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            obj.SetN(7);
            obj.SetN(100);
            Console.WriteLine("Without Using Property "+obj.GetN());
            Console.ReadLine();
        }
    }

    //simple validation
    public class Class1 
    {
        public int n;

        public void SetN(int num)
        {
            if (num < 100)
            {
                n = num;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public int GetN()
        {
            return n;
        }
    }
}

