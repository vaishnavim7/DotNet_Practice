using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCollectionDemo
{
    class Program3
    {
        static void Main3()
        {
            Console.WriteLine("==========Stack==========");
            Stack<int> objS = new Stack<int>();
            objS.Push(1000);
            objS.Push(2000);
            objS.Push(3000);
            Console.WriteLine("Peek : " + objS.Peek());
            Console.WriteLine("Pop : " + objS.Pop());

            Console.WriteLine("==========Queue==========");
            Queue<int> objQ = new Queue<int>();
            objQ.Enqueue(1001);
            objQ.Enqueue(2001);
            objQ.Enqueue(3001);
            Console.WriteLine("Peek : " + objQ.Peek());
            Console.WriteLine("Dequeue : " + objQ.Dequeue());
            Console.ReadLine();
        }
    }
}
