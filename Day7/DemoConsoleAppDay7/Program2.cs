using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program2
    {
        static void Main2()
        {
            //try with multiple catch blocks
            Class2 obj = new Class2();
            try
            {
                obj = null;
                Console.WriteLine("Enter the value");
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred");
            }

            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            Console.ReadLine();
        }

    }

    public class Class2
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                p1 = value;
            }
        }
    }
}
