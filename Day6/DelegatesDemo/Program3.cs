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
    public delegate void Delgt2();


    class Program3
    {
        //way 1
        static void Main1()
        {
            //Display();
            //Show();

            Program3 p = new Program3();
            //p.Display2();
            //p.Show2();

            //Step 2
            Console.WriteLine("MultiCastDelegate");
            Delgt2 obj1 = new Delgt2(Display);
            obj1();
            Console.WriteLine();
            obj1 += new Delgt2(Show);
            obj1();
            Console.WriteLine();
            obj1 += new Delgt2(Display);
            obj1();
            Console.WriteLine();
            obj1 -= new Delgt2(Display);
            obj1();

            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("MultiCastDelegate");
            Delgt2 obj2 = new Delgt2(p.Display2);
            obj2();
            Console.WriteLine();
            obj2 += new Delgt2(p.Show2);
            obj2();
            Console.WriteLine();
            obj2 += new Delgt2(p.Display2);
            obj2();
            Console.WriteLine();
            obj2 -= new Delgt2(p.Display2);
            obj2();


            //Step 3
            //obj();
            //obj2();
            //obj3();
            //obj4();

            Console.ReadLine();
        }

        //way 2
        static void Main2()
        {
            //Display();
            //Show();

            Program3 p = new Program3();
            //p.Display2();
            //p.Show2();

            //Step 2
            Console.WriteLine("MultiCastDelegate");
            Delgt2 obj1 = Display;
            obj1();
            Console.WriteLine();
            obj1 += Show;
            obj1();
            Console.WriteLine();
            obj1 += Display;
            obj1();
            Console.WriteLine();
            obj1 -= Display;
            obj1();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("MultiCastDelegate");
            Delgt2 obj2 = p.Display2;
            obj2();
            Console.WriteLine();
            obj2 += p.Show2;
            obj2();
            Console.WriteLine();
            obj2 += p.Display2;
            obj2();
            Console.WriteLine();
            obj2 -= p.Display2;
            obj2();

            Console.ReadLine();
        }
        
        //way 3
        static void Main3()
        {
            Delgt2 obj = (Delgt2)Delegate.Combine(new Delgt2(Display), new Delgt2(Show), new Delgt2(Display));
            obj();
            
            Console.WriteLine();
            Console.WriteLine();

            obj = (Delgt2)Delegate.Remove(obj, new Delgt2(Display));
            obj();

            Console.WriteLine();
            Console.WriteLine();

            obj = (Delgt2)Delegate.RemoveAll(obj, new Delgt2(Display));
            obj();


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
