using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Code_First_Web_Application.Models
{
    public enum Grade
    {
        A,B,C,D
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
      
        public Grade? Grade { get; set; }

        //mapping đến các bảng chính
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}