using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp1
{
    class demo1
    {
        //static void Main()
        //{
        //    ShowDemo objs = new ShowDemo();
        //    objs.Show();
        //    objs.Show(7);
        //}

        //static void Main()
        //{
        //    AddDemo obja = new AddDemo();
        //    Console.WriteLine("AddNum(n1, n2, n3, n4) :"+ obja.AddNum(10, 20, 30, 40));
        //    Console.WriteLine("AddNum(n1, n2, n3) :" + obja.AddNum(10, 20, 30));
        //    Console.WriteLine("AddNum(n1, n2) :" + obja.AddNum(10, 20));
        //    Console.ReadLine();
        //}

        //static void Main()
        //{
        //    AddDemo2 objad = new AddDemo2();
        //    Console.WriteLine("AddN(n1, n2, n3, n4) :" + objad.AddN(10, 20, 30, 40));
        //    Console.WriteLine("AddN(n1, n2, n3) :" + objad.AddN(10, 20, 30));
        //    Console.WriteLine("AddN(n1, n2) :" + objad.AddN(10, 20));
        //    Console.WriteLine("AddN(n1) :" + objad.AddN(10));
        //    Console.ReadLine();
        //}

        static void Main()
        {
            DataTypeDemo objd = new DataTypeDemo();
            objd.Print();
        }
    }

    public class ShowDemo
    {
        public void Show()
        {
            Console.WriteLine("Calling From Show Method without Parameters");
            Console.ReadLine();
        }
        public void Show(int num)
        {
            Console.WriteLine("Calling From Show Method with Parameters "+num);
            Console.ReadLine();
        }
    }

    public class AddDemo
    {
        public int AddNum(int n1, int n2, int n3, int n4)
        {
            return n1 + n2 + n3 + n4;
        }
        public int AddNum(int n1, int n2, int n3)
        {
            return n1 + n2 + n3;
        }
        public int AddNum(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public class AddDemo2
    {
        public int AddN(int n1=0, int n2=0, int n3=0, int n4=0)
        {
            return n1 + n2 + n3 + n4;
        }
    }

    public class DataTypeDemo
    {
        public void Print()
        {
            Console.WriteLine("Integer :" +sizeof(int));
            Console.WriteLine("Long :" + sizeof(long));
            Console.WriteLine("Short :" + sizeof(short));
            Console.WriteLine("Byte :" + sizeof(byte));
            Console.WriteLine("Charecter :" + sizeof(char));
            Console.WriteLine("Float :" + sizeof(float));
            Console.WriteLine("Double :" + sizeof(double));
            Console.WriteLine("Boolean :" + sizeof(bool));

            Console.ReadLine();

        }
    }
}

