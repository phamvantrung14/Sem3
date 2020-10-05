using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Code_First_Web_Application.Models
{
    public class Student
    {
       
        public int ID { get; set; }
        [Required]
        [StringLength(10,ErrorMessage ="Khong duoc qua 10 ky tu")]
        public string LastName { get; set; }
        [StringLength(50,MinimumLength =6, ErrorMessage ="FistMidName can not be longer 50 characters")]
        [Column("First Name")]
        [Required]
        public string FirstMideName { get; set; }
        [DataType(DataType.Date)]
        //thay doi display o index
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}",ApplyFormatInEditMode =true)]
        [Display(Name ="Enrrolment Date")]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
        public string Address { get; set; }
    }
}