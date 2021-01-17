using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlingDemo3
{
    class Program3
    {
        static void Main1()
        {
            //Class1 obj = new Class1();
            //obj.InvalidP1 += objClass1_InvalidP1;

            //obj.P1 = 111;
            //Console.ReadLine();
        }

        //static void objClass1_InvalidP1(int Value)
        //{
        //    Console.WriteLine("Invalid P1 Event");
        //    Console.WriteLine(Value);
        //}

        static void Main()
        {
            Class1 obj = new Class1();
            //Class1 obj2 = new Class1(Obj_InvalidP1);
            obj.InvalidP1 += Obj_InvalidP1;

            Console.ReadLine();
        }

        private static void Obj_InvalidP1(int Value)
        {
            //Console.WriteLine("InValid Input Event Handler");
            throw new NotImplementedException();
            
        }

        
    }

    //Delegate class
    public delegate void InvalidP1EventHandler(int Value);

    public class Class1
    {
        //Delegate Object
        //declare event
        public event InvalidP1EventHandler InvalidP1;

        public Class1()
        {

        }

        public Class1(InvalidP1EventHandler InvalidP1)
        {
            this.InvalidP1 = InvalidP1;
        }

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
                        InvalidP1(value);
                    
                }
            }
        }
    }
}
