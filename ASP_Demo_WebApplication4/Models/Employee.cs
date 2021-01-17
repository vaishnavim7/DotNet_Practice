using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Demo_WebApplication4.Models
{
    public class Employee
    {
        public int empId { set; get; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please Enter the Field")]


        public string name { set; get; }
        public decimal basic { set; get; }
        public int deptId { set; get; }

    }
}