using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForWebService
{
    class Program
    {
        static void Main1()
        {
            localhost.WebService1 obj = new localhost.WebService1();
            Console.WriteLine(obj.HelloWorld());
            Console.WriteLine(obj.Add(7, 5));
            Console.ReadLine();
        }

        //Asynch Method
        static void Main2()
        {
            localhost.WebService1 obj2 = new localhost.WebService1();
            Console.WriteLine("Before");

            //Console.WriteLine(obj2.LogRunnigMethod());
            obj2.LogRunnigMethodCompleted += Obj2_LogRunnigMethodCompleted;
            obj2.LogRunnigMethodAsync();

            Console.WriteLine("After");
            Console.ReadLine();
        }

        //Deligate
        static void Main()
        {
            localhost.WebService1 obj3 = new localhost.WebService1();
            Console.WriteLine("Before");

            //Console.WriteLine(obj2.LogRunnigMethod());
            //obj2.LogRunnigMethodCompleted += Obj2_LogRunnigMethodCompleted;
            //obj2.LogRunnigMethodAsync();
            Func<string> objDel = obj3.LogRunnigMethod;
            objDel.BeginInvoke(delegate (IAsyncResult ar)
            {
                Console.WriteLine(objDel.EndInvoke(ar));
            }, null);

            Console.WriteLine("After");
            Console.ReadLine();
        }


        private static void Obj2_LogRunnigMethodCompleted(object sender, localhost.LogRunnigMethodCompletedEventArgs e)
        {
            Console.WriteLine(e.Result);
        }
    }
}
