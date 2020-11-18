using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consummer.Models
{
    public class Employee
    {  
        public int ID { get; set; }      
        public string EmployeeName { get; set; }        
        public float Salary { get; set; }      
        public string Department { get; set; }
    }
}