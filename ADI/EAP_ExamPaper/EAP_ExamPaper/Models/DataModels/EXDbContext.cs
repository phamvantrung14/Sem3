using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EAP_ExamPaper.Models.DataModels
{
    public class EXDbContext:DbContext
    {
        public EXDbContext():base("name=EAPExamPaper")
        { }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}