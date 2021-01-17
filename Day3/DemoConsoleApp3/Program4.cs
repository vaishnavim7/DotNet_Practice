using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAdstractionExample
{
    class Program4
    {
        #region Main Method
        static void Main()
        {
            //Abstract Class No Object
            DerivedClass1 obj1 = new DerivedClass1();
            obj1.Display();
            obj1.Show();

            DerivedClass2 obj2 = new DerivedClass2();
            obj2.Display();
            obj2.Show();

            Console.ReadLine();
        }
        #endregion Main Method
    }

    #region AbstractClass1
    public abstract class AbstractClass1
    {
        //Normal Function
        public void Display()
        {
            Console.WriteLine("Display From Abstract Class1");
        }
    }
    #endregion AbstractClass1

    #region DerivedClass1
    public class DerivedClass1 : AbstractClass1
    {
        public void Show()
        {
            Console.WriteLine("Show() from DerivedClass1");
        }
    }
    #endregion Class1

    #region AbstractClass2
    public abstract class AbstractClass2
    {
        //Pure Abstract Functions
        public abstract void Display();
        public abstract void Show();
    }
    #endregion AbstractClass2

    #region DerivedClass2
    public class DerivedClass2 : AbstractClass2
    {
        //Override the abstract methods
        public override void Display()
        {
            Console.WriteLine("Display() from DerivedClass2");
        }
        public override void Show()
        {
            Console.WriteLine("Show() from DerivedClass2");
        }
    }
    #endregion Class2

}
