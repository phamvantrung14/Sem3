using ManagerProduct.Models.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ManagerProduct.Models
{
    public class GADbContext: DbContext
    {
        public GADbContext() : base("name=GroupAssgment") { }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
    