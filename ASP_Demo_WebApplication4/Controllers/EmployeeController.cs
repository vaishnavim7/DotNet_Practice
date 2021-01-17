using ASP_Demo_WebApplication4.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_Demo_WebApplication4.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
           
            //objEmpList.Add(new Employee { empId = 102, name = "V", basic = 45000, deptId = 10 });
            //objEmpList.Add(new Employee { empId = 103, name = "M", basic = 40000, deptId = 11 });

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee";

            SqlDataReader dr = cmd.ExecuteReader();

            List<Employee> objEmpList = new List<Employee>();
            while (dr.Read())
            {
                objEmpList.Add(new Employee
                {
                    empId = dr.GetInt32(0),
                    name = dr.GetString(1),
                    basic = dr.GetDecimal(2),
                    deptId = dr.GetInt32(3)
                }
                );
            }
            cn.Close();

            return View(objEmpList);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int empId)
        {
            Employee objEmp = new Employee();
            //objEmp.empId = 101;
            //objEmp.name = "R";
            //objEmp.basic = 15000;
            //objEmp.deptId = 10;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where empId="+empId;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objEmp.empId = dr.GetInt32(0);
                objEmp.name = dr.GetString(1);
                objEmp.basic = dr.GetDecimal(2);
                objEmp.deptId = dr.GetInt32(3);
            }
            cn.Close();

            return View(objEmp);
        }

        // GET: Employee/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        //public ActionResult Create(FormCollection collection)
        public ActionResult Create(Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into employee values(@empId, @name, @basic, @deptId)";

            cmd.Parameters.AddWithValue("@empId", objEmp.empId);
            cmd.Parameters.AddWithValue("@name", objEmp.name);
            cmd.Parameters.AddWithValue("@basic", objEmp.basic);
            cmd.Parameters.AddWithValue("@deptId", objEmp.deptId);

            try
            {
                // TODO: Add insert logic here
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            //cn.Close();
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int empId)
        {
            Employee objEmp = new Employee();
            //objEmp.empId = 101;
            //objEmp.name = "R";
            //objEmp.basic = 15000;
            //objEmp.deptId = 10;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where empId=" + empId;

            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                objEmp.empId = dr.GetInt32(0);
                objEmp.name = dr.GetString(1);
                objEmp.basic = dr.GetDecimal(2);
                objEmp.empId = dr.GetInt32(3);
            }

            cn.Close();
            return View(objEmp);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        //public ActionResult Edit(int empId, FormCollection collection)
        public ActionResult Edit(int empId, Employee objEmp)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Employee set name=@name, basic=@basic, deptId=@deptId where empId=" + empId;

            cmd.Parameters.AddWithValue("@name", objEmp.name);
            cmd.Parameters.AddWithValue("@basic", objEmp.basic);
            cmd.Parameters.AddWithValue("@deptId", objEmp.deptId);

            try
            {
                // TODO: Add update logic here
                cmd.ExecuteNonQuery();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int empId)
        {
            Employee objEmp = new Employee();
            //objEmp.empId = 101;
            //objEmp.name = "R";
            //objEmp.basic = 15000;
            //objEmp.deptId = 10;

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Employee where empId=" + empId;

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                objEmp.empId = dr.GetInt32(0);
                objEmp.name = dr.GetString(1);
                objEmp.basic = dr.GetDecimal(2);
                objEmp.empId = dr.GetInt32(3);
            }
            cn.Close();
            return View(objEmp);
        }

        // POST: Employee/Delete/5
        [HttpPost]
        //public ActionResult Delete(int empId, FormCollection collection)
        public ActionResult Delete(int empId, Employee objEmp)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(localdb)\MsSqlLocalDb;Initial Catalog=DemoDatabase_DotNet;Integrated Security=True";
            cn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete * from Employee where empId=" + empId;

            cmd.Parameters.AddWithValue("@empId", objEmp.empId);
            
            try
            {
                // TODO: Add delete logic here
                cmd.ExecuteNonQuery();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            //cn.Close();
        }
    }
}
