using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAPI2.Models.DataModels
{
    public class DRDbContext:DbContext
    {
        public DRDbContext():base("name=WebAPI")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DRDbContext, Migrations.Configuration>("WebAPI"));
        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}