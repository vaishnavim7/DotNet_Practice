using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo2
{
    class Program2
    {
        static void Main2()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += objClass1_InvalidP1;
            obj.InvalidP1 += Handler2;

            obj.P1 = 111;

            Console.WriteLine();
            obj.InvalidP1 -= objClass1_InvalidP1;
            obj.InvalidP1 -= Handler2;
            obj.P1 = 112;

            Console.ReadLine();
        }

        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid P1 Event");
        }

        static void Handler2()
        {
            Console.WriteLine("Invalid P1 Event Handler 2");
        }
    }

    //Delegate class
    public delegate void InvalidP1EventHandler();

    public class Class1
    {
        //Delegate Object
        //declare event
        public event InvalidP1EventHandler InvalidP1;


        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if(value < 100)
                {
                    p1 = value;
                }
                else
                {
                    //Console.WriteLine("Invalid Input");
                    //Event
                    //all Event is of Void Datatype
                    //call the delegate object
                    if(InvalidP1 != null)
                        InvalidP1();
                    
                }
            }
        }
    }
}
