using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebServiceAssigment2.Models.DataModels;

namespace WebServiceAssigment2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CustomerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CustomerService.svc or CustomerService.svc.cs at the Solution Explorer and start debugging.
    public class CustomerService : ICustomerService
    {
        FRDbContext db;
        public CustomerService()
        {
            db = new FRDbContext();
        }
        public void AddCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var data = db.Customers.Find(id);
            db.Customers.Remove(data);
            db.SaveChanges();
        }

        public Customer GetCustomerById(int id)
        {
            var data = db.Customers.Where(x => x.ID == id).First();
            return data;
        }

        public IEnumerable<Customer> GetCustomerList()
        {
            var data = db.Customers.AsEnumerable();
            return data;
        }

        public void UpdateCustomer(Customer c)
        {
            db.Entry(c).State = EntityState.Modified;
            db.SaveChanges();
        }
        public Customer GetCustomerCheck(string email)
        {
            var data = db.Customers.Where(x => x.Email == email).First();
            return data;
        }
    }
}
