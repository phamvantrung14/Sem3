using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    public class FRDbContext:DbContext
    {
        public FRDbContext() : base("name=WebApiAss2") { 
            //tu dong update database khi khoi tao
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FRDbContext, Migrations.Configuration>("WebApiAss2"));
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<TypeBlog> TypeBlogs { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
    }
}