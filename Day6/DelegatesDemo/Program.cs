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
    public delegate void Del1();

    public delegate void Del2(int num);

    class Program
    {
        static void Main1()
        {
            //Display();
            //Display(7);

            Program p = new Program();
            //p.Display3();

            //Step 2
            Del1 obj = new Del1(Display);
            Del2 obj2 = new Del2(Display2);
            Del1 obj3 = new Del1(p.Display3);

            //Step 3
            obj();
            obj2(7);
            obj3();

            Console.ReadLine();
        }

        static void Display()
        {
            Console.WriteLine("Display() calling by DELEGATES");
        }

        static void Display2(int n)
        {
            Console.WriteLine("Display(7) with param calling by DELEGATES");
        }

        public void Display3()
        {
            Console.WriteLine("Public Display() calling by DELEGATES");
        }
    }

    

}
