using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Constryctor in Inheritance
namespace InheritanceDemo2
{
    class Program2
    {
        #region Main Method
        static void Main3()
        {
            BaseClass objBase = new DerivedClass();
            BaseClass objBase2 = new DerivedClass(97, 72);
            BaseClass objBase3 = new SubDerivedClass();
            BaseClass objBase4 = new SubDerivedClass(12, 23, 34);
            Console.ReadLine();
        }
        #endregion MAin Method
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
        public DerivedClass(int n2, int n3) : base(n2)
        {
            Console.WriteLine("Derived Class Param Constructor");
            this.num2 = n3;
            Console.WriteLine(num2);
        }
    }
    #endregion DerivedClass

    #region SubDerivedClass
    public class SubDerivedClass : DerivedClass
    {
        private int num4;

        public SubDerivedClass()
        {
            Console.WriteLine("SubDerived Class Constructor");
            num4 = 4;
            Console.WriteLine(num4);
        }
        public SubDerivedClass(int n4, int n5, int n6) : base(n4, n5)
        {
            Console.WriteLine("SubDerived Class Param Constructor");
            this.num4 = n5;
            Console.WriteLine(num4);
        }
    }
    #endregion DerivedClass
}
