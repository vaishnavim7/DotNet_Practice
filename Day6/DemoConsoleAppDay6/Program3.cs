using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleAppDay6
{
    class Program3
    {
        static void Main3()
        {
            List<Employee> objEmp = new List<Employee>();
            Employee emp = new Employee();
            emp.EmpNo = 101;
            emp.EmpName = "Vaishnavi";
            emp.EmpSal = 35000;
            emp.DeptNo = 10;

            objEmp.Add(emp);

            //Object Initializer
            objEmp.Add(new Employee {EmpNo = 102, EmpName = "Manali", EmpSal = 25000, DeptNo = 10});
            objEmp.Add(new Employee { EmpNo = 103, EmpName = "Rashmi", EmpSal = 15000, DeptNo = 10 });
            objEmp.Add(new Employee(104, "Pooja"){EmpSal = 25000, DeptNo = 10});

            foreach (Employee e in objEmp)
            {
                Console.WriteLine(e.EmpName);
                Console.WriteLine(e.EmpNo);
                Console.WriteLine(e.EmpSal);
                Console.WriteLine(e.DeptNo);
            }

            

            Console.ReadLine();
        }

        static void Main2()
        {
            SortedList<int, Employee> objSList = new SortedList<int, Employee>();
            objSList.Add(1, new Employee { EmpNo = 102, EmpName = "Manali", EmpSal = 25000, DeptNo = 10 });
            objSList.Add(2, new Employee { EmpNo = 103, EmpName = "Rashmi", EmpSal = 15000, DeptNo = 10 });
            objSList.Add(3, new Employee(104, "Pooja") { EmpSal = 25000, DeptNo = 10 });

            foreach (KeyValuePair<int, Employee> e in objSList)
            {
                Console.WriteLine(e.Key);
                Console.WriteLine(e.Value.EmpName);
                Console.WriteLine(e.Value.EmpSal);
                Console.WriteLine(e.Value.DeptNo);
            }

            Console.ReadLine();
        }

        static void Main5()
        {
            //List<Employee> objEmp = new List<Employee>();
            Employees objE = new Employees();

            objE.Add(new Employee { EmpNo = 101, EmpName = "Vaishnavi", EmpSal = 35000, DeptNo = 10 });
            objE.Add(new Employee { EmpNo = 102, EmpName = "Manali", EmpSal = 25000, DeptNo = 10 });
            objE.Add(new Employee { EmpNo = 103, EmpName = "Rashmi", EmpSal = 15000, DeptNo = 10 });
            objE.Add(new Employee(104, "Pooja") { EmpSal = 25000, DeptNo = 10 });

            foreach (Employee e in objE)
            {
                Console.WriteLine(e.EmpName);
                Console.WriteLine(e.EmpNo);
                Console.WriteLine(e.EmpSal);
                Console.WriteLine(e.DeptNo);
            }

            Console.ReadLine();
        }

        static void Main()
        {
            //List<Employee> objEmp = new List<Employee>();
            Employees2 objE2 = new Employees2();

            objE2.Add(1, new Employee { EmpNo = 101, EmpName = "Vaishnavi", EmpSal = 35000, DeptNo = 10 });
            objE2.Add(2, new Employee { EmpNo = 102, EmpName = "Manali", EmpSal = 25000, DeptNo = 10 });
            objE2.Add(3, new Employee { EmpNo = 103, EmpName = "Rashmi", EmpSal = 15000, DeptNo = 10 });
            objE2.Add(4, new Employee(104, "Pooja") { EmpSal = 25000, DeptNo = 10 });

            foreach (KeyValuePair<int, Employee> e in objE2)
            {
                Console.WriteLine(e.Key);
                Console.WriteLine(e.Value.EmpNo);
                Console.WriteLine(e.Value.EmpName);
                Console.WriteLine(e.Value.EmpSal);
                Console.WriteLine(e.Value.DeptNo);
            }

            Console.ReadLine();
        }
    }

    public class Employees : List<Employee>
    {

    }

    public class Employees2 : SortedList<int, Employee>
    {

    }

    public class Employee
    {
        public int EmpNo { set; get; }

        public string EmpName { set; get; }

        public decimal EmpSal { set; get; }

        public short DeptNo { set; get; }

        public Employee(int empNo = 0, string empName = null /*decimal empSal, short deptNo*/)
        {
            this.EmpNo = empNo;
            this.EmpName = empName;
            //this.EmpSal = empSal;
            //this.DeptNo = deptNo;
        }

    }
}
