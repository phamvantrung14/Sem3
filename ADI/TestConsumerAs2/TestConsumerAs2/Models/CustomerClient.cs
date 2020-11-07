using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestConsumerAs2.CustomerServiceReference;

namespace TestConsumerAs2.Models
{
    public class CustomerClient
    {
        CustomerServiceClient client = new CustomerServiceClient();

        public List<Customer> GetAllCustomer()
        {
            var list = client.GetCustomerList();
            var cs = new List<Customer>();
            list.ForEach(u => cs.Add(new Customer() 
            { 
                Email = u.Email,
                ID = u.ID,
                Created = u.Created,
                CustomerName = u.CustomerName,
                Password = u.Password,
                Status = u.Status,
            }));

            return cs;
        }
        public Customer CheckEmail(string email)
        {
            var data = client.GetCustomerCheck(email);
            Customer c = new Customer();
            c.Created = data.Created;
            c.CustomerName = data.CustomerName;
            c.Email = data.Email;
            c.Password = data.Password;
            c.ID = data.ID;
            c.Status = data.Status;

            return c;
        }

        public void StoreCustomer(Customer c)
        {
            var cs = new CustomerServiceReference.Customer()
            {
                ID = c.ID,
                CustomerName = c.CustomerName,
                Created = c.Created,
                Email = c.Email,
                Status = c.Status,
                Password = c.Password
            };
            client.AddCustomer(cs);

        }
    }
}