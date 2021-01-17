using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypesDemo
{
    class Program
    {
        static void Main()
        {
            //int i = 0;
            //Nullable<int> i = 10; 
            int? i = 10;
            i = null;

            int j = 0;
            if (i != null)
            {
                j = (int)i;
            }
            else
            {
                j = 0;
            }   
            //Console.WriteLine(i);

            Console.WriteLine(j);

            if (i.HasValue)
            {
                j = i.Value;
            }
            else
            {
                j = 0;
            }
            //Console.WriteLine(i);

            Console.WriteLine(j);

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(10);
            j = i ?? 10;
            //Console.WriteLine(i);

            Console.WriteLine(j);

            Console.ReadLine();
        }
    }
}
