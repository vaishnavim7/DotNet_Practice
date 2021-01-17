using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxingDemo
{
    class Program
    {
        /*
        SHOULD BE AVOIDED
        * Boxing :
        int i = 100;
        obj o;
        o = i; //BOXING
        - Storing a value type into a referance typeis called BOXING a value type.
        - The value type on the stack is copied to the heap and reference to that is created. 
        
        * Unboxing
        int j;
        j = (int)o; //UNBOXING
        - Getting the value from a boxed reference type is called UNBOXING. 
        - The Boxed reference type is copied from the heap to the stack.
        */
        static void Main()
        {
            int i = 7;
            object o;
            o = i; //BOXING
            Console.WriteLine("Object o : "+o);

            int j;
            j = (int)o; //UNBOXING
            Console.WriteLine("int j : "+j);
            Console.ReadLine();
        }
    }
}
