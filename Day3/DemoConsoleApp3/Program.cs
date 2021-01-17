using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp3
{
    //Inheriatnce example
    class Program
    {
        static void Main1()
        {
            int i;
            decimal j;
            //way 1 of converting
             i = int.Parse(Console.ReadLine());
            j = decimal.Parse(Console.ReadLine());

            //way 2 of converting
            i = Convert.ToInt32(Console.ReadLine());
            j = Convert.ToDecimal(Console.ReadLine());


        }
    }
}

namespace InheritanceDemo1
{
    //Constructor in Inheritance
    public class Program
    {
        #region Main Method
        static void Main2()
        {
            BaseClass objBase = new DerivedClass();
            BaseClass objBase2 = new DerivedClass(97, 72);
            Console.ReadLine();
        }
        #endregion Main Method
    }

    #region BaseClass
    public class BaseClass
    {
        private int num1;

        public BaseClass()
        {
            Console.WriteLine("Base Class Constructor");
            num1 = 7;
            Console.WriteLine(num1);
        }
        public BaseClass(int n)
        {
            Console.WriteLine("Base Class Param Constructor");
            this.num1 = n;
            Console.WriteLine(num1);
        }
    }
    #endregion BaseClass

    #region DerivedClass
    public class DerivedClass : BaseClass
    {
        private int num2;

        public DerivedClass()
        {
            Console.WriteLine("Derived Class Constructor");
            num2 = 2;
            Console.WriteLine(num2);
        }
        public DerivedClass(int n2, int n3) :base(n2)
        {
            Console.WriteLine("Derived Class Param Constructor");
            this.num2 = n3;
            Console.WriteLine(num2);
        }
    }
    #endregion DerivedClass
}
