using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Overload Hidding Overring
namespace InheritanceDemo3
{
    class Program3
    {
        #region Main Method
        static void Main4()
        {
            //declare a reference to the Base CLass
            Console.WriteLine("Base to Derived Obj");
            BaseClass objBase = new DerivedClass();
            objBase.Display1();
            objBase.Display2();
            objBase.Display3();
            
            Console.WriteLine("==========================================");
            //declare a reference to the Derived CLass
            Console.WriteLine("Derived to Derived Obj");
            DerivedClass objBase1 = new DerivedClass();
            objBase1.Display1();
            objBase1.Display2();
            objBase1.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("Base to SubDerived Obj");
            objBase = new SubDerivedClass();
            objBase.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("Base to SubSubDerived Obj");
            objBase = new SubSubDerivedClass();
            objBase.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("Derived to SubDerived Obj");
            objBase1 = new SubDerivedClass();
            objBase1.Display3();

            Console.WriteLine("==========================================");
            //declare a reference to the SubDerived CLass
            Console.WriteLine("SubDerived to SubDerived Obj");
            SubDerivedClass objBase2 = new SubDerivedClass();
            objBase2.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("Base to SubSubDerived Obj");
            objBase = new SubSubDerivedClass();
            objBase.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("Derived to SubDerived Obj");
            objBase1 = new SubSubDerivedClass();
            objBase1.Display3();

            Console.WriteLine("==========================================");
            Console.WriteLine("SubDerived to SubSubDerived Obj");
            objBase2 = new SubSubDerivedClass();
            objBase2.Display3();

            Console.WriteLine("==========================================");
            //declare a reference to the SubSubDerived CLass
            Console.WriteLine("SubSubDerived to SubSubDerived Obj");
            SubSubDerivedClass objBase3 = new SubSubDerivedClass();
            objBase3.Display3();
            Console.ReadLine();
        }
        #endregion MAin Method
    }

    #region BaseClass
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("Base Class Display1()");

        }
        public void Display2()
        {
            Console.WriteLine("Base Class Display2()");
        }
        //virtual method
        public virtual void Display3()
        {
            Console.WriteLine("Base Class Display3()");
        }
    }
    #endregion BaseClass

    #region DerivedClass
    public class DerivedClass : BaseClass
    {
        //overloading method in DerivedClass
        public void Display1(string str)
        {
            Console.WriteLine("DerivedClass Display1()");
        }

        //hidding method in DerivedClass with new keyword
        public new void Display2()
        {
            Console.WriteLine("DerivedClass Display2()");
        }

        //overriding method in DerivedClass with override keyword
        public override void Display3()
        {
            Console.WriteLine("DerivedClass Display3()");
        }
    }
    #endregion DerivedClass

    #region SubDerivedClass
    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("SubDerivedClass Display3()");
        }
    }
    #endregion SubDerivedClass

    #region SubSubDerivedClass
    public class SubSubDerivedClass : SubDerivedClass
    {
        //public override void Display3() will give error
        //public new void Display3() will hide
        public  void Display3() //bydefault will hide
        {
            Console.WriteLine("SubSubDerivedClass Display3()");
        }
    }
    #endregion SubSubDerivedClass
}
