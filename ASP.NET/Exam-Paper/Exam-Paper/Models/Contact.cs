using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Exam_Paper.Models
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        public string ContactName { get; set; }
        public string ContactNumber { get; set; }
        public string GroupName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime BirthDay { get; set; }
    }
}