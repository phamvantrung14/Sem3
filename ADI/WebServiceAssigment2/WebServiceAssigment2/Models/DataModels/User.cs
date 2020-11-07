using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    [DataContract]
    public class User
    {
        [Key]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public string Email { get; set; }
        
        public ICollection<Blog> Blogs { get; set; }
    }
}