using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAccountAs1.Models
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int CodePin { get; set; }
        public float Money { get; set; }
        public int CMND { get; set; }
        public DateTime Created { get; set; }
    }
}