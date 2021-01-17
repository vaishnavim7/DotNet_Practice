using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    /*
     * To Delegates means to assigning some some to someone to do.
     * In Delegates we are asking someone to call a function.
     * Indirectly call the function.
     * no Pointers.
     * It allow to call a function indirectly.
     * delegates is a class and using this class we call a function.
     * Object --> Delegate --> MultiCastDelegate --> MyDelegate 
     */

    /*
     * Steps
     * step 1 : create a delegate class having the same signature as the function to call
     * step 2 : create a delegate object passing the function name as a parameter.
     * step 3 : call the func via the delegate object
     * 
     */

    //step 1
    public delegate int Delgt3(int a, int b);


    class Program4
    {
        //way 1
        static void Main1()
        {
            Program4 p = new Program4();
            //p.Add2();
            //p.Sub2();
            
            //Step 2
            Console.WriteLine("MultiCastDelegate");
            Delgt3 obj1 = new Delgt3(Add);
            Console.WriteLine(obj1(20, 10));
            Console.WriteLine();
            obj1 += new Delgt3(Sub);
            Console.WriteLine(obj1(20, 10));
            Console.WriteLine();
            obj1 += new Delgt3(Add);
            Console.WriteLine(obj1(30, 20));
            Console.WriteLine();
            obj1 -= new Delgt3(Add);
            Console.WriteLine(obj1(40, 30));

            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("MultiCastDelegate");
            Delgt3 obj2 = new Delgt3(p.Add2);
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += new Delgt3(p.Sub2);
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += new Delgt3(p.Add2);
            Console.WriteLine(obj2(40, 30));
            Console.WriteLine();
            obj2 -= new Delgt3(p.Add2);
            Console.WriteLine(obj2(50, 40));


            Console.ReadLine();
        }

        //way 2
        static void Main2()
        {
            Program4 p = new Program4();
            //p.Add2();
            //p.Sub2();

            //Step 2
            Console.WriteLine("MultiCastDelegate");
            Delgt3 obj1 = Add;
            Console.WriteLine(obj1(20, 10));
            Console.WriteLine();
            obj1 += Sub;
            Console.WriteLine(obj1(20, 10));
            Console.WriteLine();
            obj1 += Add;
            Console.WriteLine(obj1(40, 30));
            Console.WriteLine();
            obj1 -= Add;
            Console.WriteLine(obj1(50, 40));

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MultiCastDelegate");
            Delgt3 obj2 = p.Add2;
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += p.Sub2;
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += p.Add2;
            Console.WriteLine(obj2(40, 30));
            Console.WriteLine();
            obj2 -= p.Add2;
            Console.WriteLine(obj2(50, 40));


            Console.ReadLine();
        }

        //way 3
        static void Main3()
        {
            //Delgt3 obj = new Delgt3(Class2.Add);
            Delgt3 obj = Class2.Add;
            Console.WriteLine(obj(7, 2));
            obj += Class2.Sub;
            Console.WriteLine(obj(7, 2));
            obj = Class2.Add;
            Console.WriteLine(obj(9, 7));
            obj += Class2.Add;
            Console.WriteLine(obj(9, 7));
            obj -= Class2.Add;

            Console.WriteLine();
            Console.WriteLine();

            Class2 p = new Class2();
            Delgt3 obj2 = p.Add2;
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += p.Sub2;
            Console.WriteLine(obj2(20, 10));
            Console.WriteLine();
            obj2 += p.Add2;
            Console.WriteLine(obj2(40, 30));
            Console.WriteLine();
            obj2 -= p.Add2;
            Console.WriteLine(obj2(50, 40));
            Console.ReadLine();

        }

        static void Main()
        {
            Console.WriteLine(PassMethodToCallAsAParameter(Add, 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(Sub, 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(Multi, 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(Div, 20, 10));

            Console.WriteLine();

            Console.WriteLine(PassMethodToCallAsAParameter(new Delgt3(Add), 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(new Delgt3(Sub), 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(new Delgt3(Multi), 20, 10));
            Console.WriteLine(PassMethodToCallAsAParameter(new Delgt3(Div), 20, 10));

            Console.ReadLine();
        }

        static int Add(int i, int j)
        {
            Console.WriteLine("Addintion");
            return i + j;
        }

        static int Sub(int i, int j)
        {
            Console.WriteLine("Subtraction");
            return i - j;
        }

        static int Multi(int i, int j)
        {
            Console.WriteLine("Multiplication");
            return i * j;
        }

        static int Div(int i, int j)
        {
            Console.WriteLine("Division");
            return i / j;
        }

        public int Add2(int i, int j)
        {
            Console.WriteLine("Addintion2");
            return i + j;
        }
        public int Sub2(int i, int j)
        {
            Console.WriteLine("Subtraction2");
            return i - j;
        }

        static int PassMethodToCallAsAParameter(Delgt3 objAdd, int a, int b)//objDelAdd = Add, a = 20, b = 10
        {
            return objAdd(a, b);
        }

    }

    public class Class2
    {
        public static int Add(int i, int j)
        {
            Console.WriteLine("Class2 Addintion");
            return i + j;
        }

        public static int Sub(int i, int j)
        {
            Console.WriteLine("Class2 Subtraction");
            return i - j;
        }

        public int Add2(int i, int j)
        {
            Console.WriteLine("Class2 Addintion2");
            return i + j;
        }

        public int Sub2(int i, int j)
        {
            Console.WriteLine("Class2 Subtraction2");
            return i - j;
        }
    }

}
