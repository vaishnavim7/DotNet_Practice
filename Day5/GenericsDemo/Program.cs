using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Program
    {
        static void Main()
        {
            //IntegerStack i = new IntegerStack(3);
            //i.Push(7);
            //i.Push(2);
            //i.Push(9);
            //Console.WriteLine(i.Pop());
            //Console.WriteLine(i.Pop());
            //Console.WriteLine(i.Pop());
            //Console.WriteLine(i.Pop());

            //StringStack s = new StringStack(3);
            //s.Push("riva");
            //s.Push("shiva");
            //s.Push("ziva");
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());
            //Console.WriteLine(s.Pop());

            MyStack<int> t = new MyStack<int>(3);
            t.Push(10);
            t.Push(20);
            t.Push(30);
            Console.WriteLine(t.Pop());
            Console.WriteLine(t.Pop());
            Console.WriteLine(t.Pop());


            Console.ReadLine();

        }
    }

    class IntegerStack
    {
        int[] arr;
        public IntegerStack(int size)
        {
            arr = new int[size];
        }

        int top = -1;
        public void Push(int i)
        {
            if(top == (arr.Length - 1))
            {
                throw new Exception("Stack full");
                arr[++top] = i;
            }
        }

        public int Pop()
        {
            if(top == -1)
            {
                throw new Exception("Stack empty");
            }
            return arr[top--];
        }
    }

    class StringStack
    {
        string[] arr;
        public StringStack(int size)
        {
            arr = new string[size];
        }

        int top = -1;
        public void Push(string i)
        {
            if (top == (arr.Length - 1))
            {
                throw new Exception("Stack Full");
                arr[++top] = i;
            }
        }

        public string Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack Empty");
            }
            return arr[top--];
        }
    }

    class MyStack<T>
    {
        T[] arr;
        public MyStack(int size)
        {
            arr = new T[size];
        }

        int top = -1;
        public void Push(T i)
        {
            if (top == (arr.Length - 1))
            {
                throw new Exception("Stack Full");
            }
            arr[++top] = i;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack Empty");
            }
            return arr[top--];
        }
    }

    //where T : class  - T must be a reference type
    //where T : struct - T must be a value type
    //where T : ClassName - T must be either ClassName or a derived class
    //where T : InterfaceName - T must be a class that implements InterfaceName
    //where T : new() - T must have a no parameter constructor

    //constraints can be combined. new() must appear at the end if new() is used
    //where T : ClassName, InterfaceName
    //where T : ClassName, InterfaceName, new()
    class MyStack2<T>
        //where T : class
        //where T : struct
    {
        T[] arr;
        public MyStack2(int size)
        {
            arr = new T[size];
        }

        int top = -1;
        public void Push(T i)
        {
            if (top == (arr.Length - 1))
            {
                throw new Exception("Stack Full");
            }
            arr[++top] = i;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack Empty");
            }
            return arr[top--];
        }
    }

    //class MyOperators<T>
    //{
    //    public static void Swap(ref T i, ref T j)
    //    {
    //        T temp;
    //        temp = i;
    //        i = j;
    //        j = temp;
    //    }
    //}

    //class IntOperators
    //{
    //    public static void Swap(ref int i, ref int j)
    //    {
    //        int temp;
    //        temp = i;
    //        i = j;
    //        j = temp;
    //    }
    //}

    //class ShortOperators
    //{
    //    public static void Swap(ref short i, ref short j)
    //    {
    //        short temp;
    //        temp = i;
    //        i = j;
    //        j = temp;

    //    }
    //}
}
