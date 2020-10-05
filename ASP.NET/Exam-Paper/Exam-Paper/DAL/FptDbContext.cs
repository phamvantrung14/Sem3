using Exam_Paper.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Exam_Paper.DAL
{
    public class FptDbContext : DbContext
    {
        public FptDbContext() : base("name=newConnection") { }
        public DbSet<Contact> Contacts { get; set; }
    }
}