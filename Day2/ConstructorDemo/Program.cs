using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main()
        {
            DemoConstructor dc = new DemoConstructor();
            DemoConstructor dc2 = new DemoConstructor(72);

            Console.ReadLine();
        }
    }

    public class DemoConstructor
    {
        public DemoConstructor()
        {
            Console.WriteLine("Calling from no parameterized constructor.");
            
        }
        public DemoConstructor(int num)
        {
            Console.WriteLine("Calling from parameterized constructor "+num);
        }
    } 
}
