using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueTypeDemo
{
    class Program
    {
        static void Main1()
        {
            //MyPoint p;
            //p.X = 123;
            //p.Y = 456;
            MyPoint p = new MyPoint();
            MyPoint p1 = new MyPoint(7, 2);
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);

            Console.WriteLine(p1.X);
            Console.WriteLine(p1.Y);

            Console.ReadLine();
        }

        static void Main()
        {
            //Display1(0);
            Display2(TimeOfDay.Morning);
            Console.ReadLine();
        }


        static void Display1(int t)
        {
            if(t == 0)
            {
                Console.WriteLine("Display1 Good Morning");
            }
            else if(t == 1)
            {
                Console.WriteLine("Display1 Good Afternoon");
            }
            else if (t == 2)
            {
                Console.WriteLine("Display1 Good Evening");
            }
            else if (t == 3)
            {
                Console.WriteLine("Display1 Good Night");
            }
        }

        static void Display2(TimeOfDay t)
        {
            if (t == TimeOfDay.Morning)
            {
                Console.WriteLine("Display2 Good Morning");
            }
            else if (t == TimeOfDay.Afternoon)
            {
                Console.WriteLine("Display2 Good Afternoon");
            }
            else if (t == TimeOfDay.Evening)
            {
                Console.WriteLine("Display2 Good Evening");
            }
            else if (t == TimeOfDay.Night)
            {
                Console.WriteLine("Display2 Good Night");
            }
        }
    }

    public enum TimeOfDay //: long
    {
        Morning = 100,
        Afternoon = 200,
        Evening,
        Night
    }

    public struct MyPoint
    {
        public int X, Y;
        public MyPoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
    }
}
