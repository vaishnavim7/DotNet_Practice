using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonMethodAndLambdas
{
    class Program
    {
        static void Main1()
        {
            //void return Type Delegate
            //Action always call for methods who have Void retutn type
            Action del = Display;
            del();

            Action<int> del2 = Display2;
            del2(7);

            //Func Delegate
            Func<int, int, int> del3 = Add;
            Console.WriteLine(del3(7, 2));

            Func<string, short, int> del4 = DoSomething;
            Console.WriteLine(del4("", 0));

            Func<int, bool> del5 = IsEven;
            Console.WriteLine(del5(10));

            //Predicate Delegate
            Predicate<int> del6 = IsEven;
            Console.WriteLine(del6(7));

            Console.ReadLine();
        }

        static void Main2()
        {
            int i = 0;
            Action obj = delegate 
            { 
                Console.WriteLine("Anonymus Method called"); 
            };
            obj();
            
            Action obj2 = delegate()
            {
                Console.WriteLine("Display() with Anonymus Meyhod");
                i++;
                ++i;
            };
            obj2();
            Console.WriteLine(i);

            Func<int, int, int> obj3 = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(obj3(7, 2));

            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Display()");
        }

        static void Display2(int num)
        {
            Console.WriteLine("Display() with param : "+num);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int DoSomething(string a, short b)
        {
            return 1;
        }

        static bool IsEven(int a)
        {
            return a % 2 == 0;
        }


    }
}
