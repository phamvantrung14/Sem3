
using RESTWCF_LINQ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTWCF_LINQ
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public List<EmployeeService> getAll()
        {
            try
            {
                 return (from employee in data.Students select employee).ToList();
            }
            catch { return null; }
        }
    }
}
