using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assigment1_WCF.Models.DataModels
{
    public class FRDbContext : DbContext
    {
        public FRDbContext():base("name=WebApiAssigment1")
        {
           
        }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Deal> Deals { get; set; }
    }
}