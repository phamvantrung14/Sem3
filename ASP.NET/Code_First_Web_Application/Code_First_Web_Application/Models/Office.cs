using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Code_First_Web_Application.Models
{
    public class Office
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public virtual ICollection<Instructor> Instructors { get; set; }
    }
}