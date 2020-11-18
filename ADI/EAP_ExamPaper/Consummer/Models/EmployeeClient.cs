using Consummer.EmployeeServiceReference;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consummer.Models
{
    public class EmployeeClient
    {
        EmployeeServiceClient client = new EmployeeServiceClient();
        public List<Employee> GetAllEmployee()
        {
            var list = client.GetEmployeeList();
            var emp = new List<Employee>();
            list.ForEach(e => emp.Add(new Employee() {
                ID = e.ID,
                Department = e.Department,
                EmployeeName = e.EmployeeName,
                Salary = e.Salary,
            }));
            return emp;
               
        }
        public List<Employee> GetEmployeeByKey(string key)
        {
            var list = client.SerchEmployee(key);
            var emp = new List<Employee>();
            list.ForEach(e => emp.Add(new Employee()
            {
                ID = e.ID,
                Department = e.Department,
                EmployeeName = e.EmployeeName,
                Salary = e.Salary,
            }));
            return emp;
        }
        public void AddEmp(Employee emp)
        {
            var cm = new EmployeeServiceReference.Employee()
            {
                Department = emp.Department,
                EmployeeName = emp.EmployeeName,
                Salary = emp.Salary,
                ID = emp.ID
            };
            client.AddEmployee(cm);
        }
    }
}