using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Program
    {
        static void Main1()
        {
            Console.WriteLine("Way 1");
            DeriverdClass od = new DeriverdClass();
            od.Insert();
            od.Update();
            od.Delete();
            od.Display();

            Console.WriteLine("Way 2");
            IDBFunction oi;
            oi = od;
            oi.Insert();
            oi.Update();
            oi.Delete();

            Console.WriteLine("Way 3");
            ((IDBFunction)od).Insert();
            ((IDBFunction)od).Update();
            ((IDBFunction)od).Delete();
           

            Console.WriteLine("==========================================================");

            Console.WriteLine("Way 1");
            DeriverdClass2 od2 = new DeriverdClass2();
            od2.Insert();
            od2.Update();
            od2.Delete();
            od2.Show();

            Console.WriteLine("Way 2");
            IDBFunction oi2;
            oi2 = od2;
            oi2.Insert();
            oi2.Update();
            oi2.Delete();

            Console.WriteLine("Way 3");
            ((IDBFunction)od2).Insert();
            ((IDBFunction)od2).Update();
            ((IDBFunction)od2).Delete();
            
            
            Console.ReadLine();

        }

        static void Main2()
        {
            DeriverdClass od1 = new DeriverdClass();
            DeriverdClass2 od2 = new DeriverdClass2();
            InsertMethod(od1);
            InsertMethod(od2);

            Console.ReadLine();
        }

        static void InsertMethod(IDBFunction oi)
        {
            oi.Insert();
        }

        static void Main3()
        {
            Console.WriteLine("Way 1 for explicitly");
            DeriverdClass3 od3 = new DeriverdClass3();
            od3.Insert();
            od3.Update();
            od3.Delete();
            od3.Display();

            Console.WriteLine("Way 2 for implicitly");
            IFileFunction oif;
            oif = od3;
            oif.Open();
            oif.Close();
            oif.Delete();

            Console.WriteLine("Way 3 for implicitly");
            ((IFileFunction)od3).Open();
            ((IFileFunction)od3).Close();
            ((IFileFunction)od3).Delete();


            Console.WriteLine("==========================================================");

            Console.WriteLine("Way 1 for explicitly");
            DeriverdClass4 od4 = new DeriverdClass4();
            od4.Insert();
            od4.Update();
            od4.Delete();
            od4.Show();

            Console.WriteLine("Way 2 for implicitly");
            IFileFunction oif2;
            oif2 = od4;
            oif2.Open();
            oif2.Close();
            oif2.Delete();
             
            Console.WriteLine("Way 3 for implicitly");
            ((IFileFunction)od4).Open();
            ((IFileFunction)od4).Close();
            ((IFileFunction)od4).Delete();


            Console.ReadLine();

        }

    }

    public interface IDBFunction
    {
        void Insert();
        void Update();
        void Delete();

    }

    public class DeriverdClass : IDBFunction
    {
        public void Insert()
        {
            Console.WriteLine("DerivedClass IDBF.Insert()");
        }

        public void Update()
        {
            Console.WriteLine("DerivedClass IDBF.Update()");
        }
        public void Delete()
        {
            Console.WriteLine("DerivedClass IDBF.Delete()");
        }

        public void Display()
        {
            Console.WriteLine("DerivedClass Display()");
        }
       
    }

    public class DeriverdClass2 : IDBFunction
    {
        public void Insert()
        {
            Console.WriteLine("DerivedClass2 IDBF.Insert()");
        }

        public void Update()
        {
            Console.WriteLine("DerivedClass2 IDBF.Update()");
        }
        public void Delete()
        {
            Console.WriteLine("DerivedClass2 IDBF.Delete()");
        }

        public void Show()
        {
            Console.WriteLine("DerivedClass2 Display()");
        }

    }

    public interface IFileFunction
    {
        void Open();
        void Close();
        void Delete();

    }

    public class DeriverdClass3 : IDBFunction, IFileFunction
    {
        public void Insert()
        {
            Console.WriteLine("DerivedClass3 IDBF.Insert()");
        }

        public void Update()
        {
            Console.WriteLine("DerivedClass3 IDBF.Update()");
        }
        public void Delete()
        {
            Console.WriteLine("DerivedClass3 IDBF.Delete()");

        }

        void IFileFunction.Open()
        {
            Console.WriteLine("DerivedClass3 IFile.Open()");
        }

        void IFileFunction.Close()
        {
            Console.WriteLine("DerivedClass3 IFile.Close()");
        }
        void IFileFunction.Delete()
        {
            Console.WriteLine("DerivedClass3 IFile.Delete()");
        }

        public void Display()
        {
            Console.WriteLine("DerivedClass3 Display()");
        }
    }

    public class DeriverdClass4 : IDBFunction, IFileFunction
    {
        public void Insert()
        {
            Console.WriteLine("DerivedClass4 IDBF.Insert()");
        }

        public void Update()
        {
            Console.WriteLine("DerivedClass4 IDBF.Update()");
        }
        public void Delete()
        {
            Console.WriteLine("DerivedClass4 IDBF.Delete()");
        }
        void IFileFunction.Open()
        {
            Console.WriteLine("DerivedClass4 IFile.Open()");
        }

        void IFileFunction.Close()
        {
            Console.WriteLine("DerivedClass4 IFile.Close()");
        }
        void IFileFunction.Delete()
        {
            Console.WriteLine("DerivedClass4 IFile.Delete()");
        }

        public void Show()
        {
            Console.WriteLine("DerivedClass4 Display()");
        }

    }
}
