using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Web_Application.Models
{
    public class Department
    {
        public int ID { get; set; }
        [StringLength(50,MinimumLength =6)]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }

    }
}