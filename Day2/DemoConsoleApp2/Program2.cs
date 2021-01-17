using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApp2
{
    class Program2
    {
        //for the 1st class
        //static void Main1()
        //{
        //    DemoClass1 d1 = new DemoClass1();
        //    d1.Pro1 = 7;
        //    d1.Pro1 = 100;
        //    Console.WriteLine("Using Property "+d1.Pro1);
        //    Console.ReadLine();
        //}

        //for the 2nd class
        //static void Main2()
        //{
        //    DemoClass2 d2 = new DemoClass2();
        //    d2.Pro2 = null;
        //    d2.Pro2 = "vaishnavi";
        //    Console.WriteLine("Using Property " + d2.Pro2);
        //    Console.ReadLine();
        //}

        //for the 3rd class
        //static void Main3()
        //{
        //    DemoClass3 d3 = new DemoClass3();
        //    Console.WriteLine("Using ReadOnly Property " + d3.Pro3);
        //    Console.ReadLine();
        //}

        //for the 4th class
        //static void Main4()
        //{
        //    DemoClass4 d4 = new DemoClass4();
        //    d4.Pro4 = 72;
        //    Console.WriteLine("Using Property without validation " + d4.Pro4);
        //    Console.ReadLine();
        //}

        //for the 5th class auto Property
        //static void Main()
        //{
        //    DemoClass5 d5 = new DemoClass5();
        //    d5.Pro5 = 7297;
        //    Console.WriteLine("Using Auto Property " + d5.Pro5);
        //    Console.ReadLine();
        //}

        //for all classes
        static void Main()
        {
            DemoClass1 d1 = new DemoClass1();
            d1.Pro1 = 7;
            d1.Pro1 = 100;
            Console.WriteLine("Using Property " + d1.Pro1);


            DemoClass2 d2 = new DemoClass2();
            d2.Pro2 = null;
            d2.Pro2 = "vaishnavi";
            Console.WriteLine("Using Property " + d2.Pro2);

            DemoClass3 d3 = new DemoClass3();
            Console.WriteLine("Using ReadOnly Property " + d3.Pro3);

            DemoClass4 d4 = new DemoClass4();
            d4.Pro4 = 72;
            Console.WriteLine("Using Property without validation " + d4.Pro4);

            DemoClass5 d5 = new DemoClass5();
            d5.Pro5 = 7297;
            Console.WriteLine("Using Auto Property " + d5.Pro5);


            Console.ReadLine();
        }
}

    public class DemoClass1 
    {
        private int num;
        //Property
        public int Pro1
        {
            set 
            { 
                if(value < 100)
                {
                    num = value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            get
            {
                return num;
            }

        }
    }

    //Sequence is not matter
    public class DemoClass2
    {
        private string name;
        //Property
        public string Pro2
        {
            get
            {
                return name;
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }

    //ReadOnly Property
    public class DemoClass3
    {
        private int n3 = 7;
        //Property
        public int Pro3
        {
            get 
            {
                return n3;
            }
        }
    }

    //Property Without Validation
    public class DemoClass4
    {
        private int n4;
        //Property
        public int Pro4
        {
            set
            {
                n4 = value;
            }
            get
            {
                return n4;
            }
        }
    }

    //auto property
    public class DemoClass5
    {
        //Property
        public int Pro5
        {
            set;
            get;
        }
    }
}
