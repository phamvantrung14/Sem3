using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EAP_ExamPaper.Models.DataModels
{
    [DataContract]
    public class Employee
    {
        [Key]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string EmployeeName { get; set; }
        [DataMember]
        public float Salary { get; set; }
        [DataMember]
        public string Department { get; set; }
    }
}