using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposableDemo
{
    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();

            obj.Display();

            obj.Dispose();

            obj.Display();

            Console.ReadLine();
        }

        static void Main2()
        {
            using (Class1 obj2 = new Class1())
            {
                obj2.Display();
            }
            Console.ReadLine();

        }
    }

    public class Class1 : IDisposable
    {
        public void Display()
        {
            CheckForDisposed();

            Console.WriteLine("Display()");
        }
        private void CheckForDisposed()
        {
            if (isDisposed)
                throw new ObjectDisposedException("Class1");
        }
        private bool isDisposed = false;
        public void Dispose()
        {
            Console.WriteLine("dispose called. free resources here");
            isDisposed = true;
        }

    }
}
