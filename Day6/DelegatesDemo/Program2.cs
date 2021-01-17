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
    public delegate void Delgt1();


    class Program2
    {
        static void Main2()
        {
            //Display();
            //Show();

            Program2 p = new Program2();
            //p.Display2();
            //p.Show2();

            //Step 2
            Console.WriteLine("Both Fun With Single Object Ref obj");
            Delgt1 obj = new Delgt1(Display);
            obj();
            obj = new Delgt1(Show);
            obj();
            Console.WriteLine("Fun With Object Ref");
            Delgt1 obj2 = new Delgt1(Show);
            obj2();
            Console.WriteLine("Both Fun With Single Object Ref obj3");
            Delgt1 obj3 = new Delgt1(p.Display2);
            obj3();
            obj3 = new Delgt1(p.Show2);
            obj3();
            Console.WriteLine("Fun With Object Ref");
            Delgt1 obj4 = new Delgt1(p.Show2);
            obj4();

            //Step 3
            //obj();
            //obj2();
            //obj3();
            //obj4();

            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine("Display() calling by DELEGATES");
        }

        static void Show()
        {
            Console.WriteLine("Show() calling by DELEGATES");
        }

        public void Display2()
        {
            Console.WriteLine("Public Display() calling by DELEGATES");
        }
        public void Show2()
        {
            Console.WriteLine("Public Show() calling by DELEGATES");
        }
    }

    

}
