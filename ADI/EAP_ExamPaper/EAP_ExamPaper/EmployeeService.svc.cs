using EAP_ExamPaper.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EAP_ExamPaper
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        EXDbContext db;
        public EmployeeService()
        {
            db = new EXDbContext();
        }
        public void AddEmployee(Employee e)
        {
            db.Employees.Add(e);
            db.SaveChanges();
        }

        public IEnumerable<Employee> GetEmployeeList()
        {
            var data = db.Employees.ToList();
            return data;
        }

        public IEnumerable<Employee> SerchEmployee(string key)
        {
            var data = db.Employees.Where(x => x.Department == key).ToList();
            return data;
        }
    }
}
