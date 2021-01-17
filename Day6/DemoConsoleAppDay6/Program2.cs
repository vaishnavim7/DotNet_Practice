using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAppDay6
{
    class Program2
    {
        static void Main2()
        {
            Console.WriteLine("==========Stack==========");
            Stack objS = new Stack();
            objS.Push(1000);
            objS.Push(2000);
            objS.Push(3000);
            Console.WriteLine("Peek : "+objS.Peek());
            Console.WriteLine("Pop : " + objS.Pop());

            Console.WriteLine("==========Queue==========");
            Queue objQ = new Queue();
            objQ.Enqueue(1001);
            objQ.Enqueue(2001);
            objQ.Enqueue(3001);
            Console.WriteLine("Peek : "+objQ.Peek());
            Console.WriteLine("Dequeue : " + objQ.Dequeue());
            Console.ReadLine();
            
        }
    }
}
