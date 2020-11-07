using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestConsumerAs2.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public string Email { get; set; }
    }
}