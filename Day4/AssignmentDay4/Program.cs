using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter how many employees you want to add");
            int size = Convert.ToInt32(Console.ReadLine());
            Employee[] A = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Employee Number");
                int EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                String Name = (Console.ReadLine());
                Console.WriteLine("Enter Employee Salary");
                decimal Sal = Convert.ToDecimal(Console.ReadLine());


                Employee E = new Employee(EmpNo, Name, Sal);
                A[i] = E;

            }
            Console.WriteLine("Details of Employees***************");
            for (int i = 0; i < A.Length; i++)
            {

                A[i].show();
            }
            Console.WriteLine("Maximum Salary*************");
            decimal high = A[0].Sal;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Sal > high)
                {
                    high = A[i].Sal;
                }
            }

            Console.WriteLine("Maximum Salary =" + high);
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].Sal == high)
                {
                    A[i].show();

                }
            }


            Console.Write("Enter employee number to search details of Employee:");
            int Find = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i].EmpNo == Find)
                {
                    A[i].show();
                }
                else
                {
                    Console.WriteLine("Invalid Employee number.");
                }
            }

            Console.ReadLine();
        }


    }
    class Employee
    {
        public int EmpNo;
        public string Name;
        public decimal Sal;

        public Employee(int EmpNo, string Name, decimal Sal)
        {
            this.EmpNo = EmpNo;
            this.Name = Name;
            this.Sal = Sal;
        }

        public void show()
        {
            // Console.WriteLine( "Show method");
            Console.WriteLine("Employee No:" + EmpNo);
            Console.WriteLine("Employee Name:" + Name);
            Console.WriteLine("Employee Salary:" + Sal);

            Console.WriteLine("*********************************************************");
        }


    }

}
