using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndValueTypeDemo
{
    class Program
    {
        static void Main1()
        {
            Class2 ob1 = new Class2();
            Class2 ob2 = new Class2();
            ob1.i = 100;
            ob2.i = 200;
            ob1 = ob2;

            ob2.i = 300;
            Console.WriteLine("Object 1 "+ob1.i);
            Console.WriteLine("Object 2 "+ob2.i);
            Console.ReadLine();

        }

        static void Main2()
        {
            int ob1, ob2;
            ob1 = 100;
            ob2 = 200;
            ob1 = ob2;

            ob2 = 300;
            Console.WriteLine("Object 1 " + ob1);
            Console.WriteLine("Object 2 " + ob2);
            Console.ReadLine();
        }

        static void Main3()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("In the main method : Before Swaping a : " + a+" b : "+b);
            Swap(a, b);
            Console.WriteLine("In the main method : After Swaping a : " + a + " b : " + b);

            Console.ReadLine();
        }
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In the swap method : After Swaping a : " + a + " b : " + b);
        }

        static void Main4()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("In the main method : Before Swaping a : " + a + " b : " + b);
            SwapR(ref a, ref b);
            Console.WriteLine("In the main method : After Swaping a : " + a + " b : " + b);
            Console.ReadLine();
        }
        static void SwapR(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("In the swap method : After Swaping a : " + a + " b : " + b);
        }

        static void Main5()
        {
            int i;
            int j;
            Init(out i, out j);
            Console.WriteLine("i : " + i + " j : " + j);
            Console.ReadLine();

        }

        static void Init(out int i, out int j)
        {
            //the initial value is discarded
            // Console.WriteLine(i);
            i = 100;
            j = 200;
            //out variables MUST be initialized in the function
        }

        static void Main()
        {
            Class2 o = new Class2();
            o.i = 100;
            //DoSomething1(o);
            //DoSomething2(o);
            DoSomething3(ref o);

            Console.WriteLine(o.i);
            Console.ReadLine();

        }
        static void DoSomething1(Class2 obj)
        {
            obj.i = 200;
        }

        static void DoSomething2(Class2 obj)
        {
            obj = new Class2();
            obj.i = 200;
        }

        static void DoSomething3(ref Class2 obj)
        {
            obj = new Class2();
            obj.i = 200;
        }

        static void DataTypes()
        {
            byte b1;
            sbyte b2;
            char ch;
            short sh1;
            ushort sh2;
            int i1; //System.Int32 //4
            uint i2;//System.UInt32 //4
            long l1;
            ulong l2;
            float f;
            double d;
            decimal d2;
            bool b;

            string s;
            object o;


        }
    }

    public class Class2
    {
        public int i;
    }
}
