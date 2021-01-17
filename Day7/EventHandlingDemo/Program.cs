using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo
{
    class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += objClass1_InvalidP1;

            obj.P1 = 111;
            Console.ReadLine();
        }

        static void objClass1_InvalidP1()
        {
            Console.WriteLine("Invalid P1 Event");
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
                    InvalidP1();
                    
                }
            }
        }
    }
}
