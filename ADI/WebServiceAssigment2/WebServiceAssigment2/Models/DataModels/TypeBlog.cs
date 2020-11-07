using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    [DataContract]
    public class TypeBlog
    {
        [Key]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string TypeName { get; set; }
        [DataMember]
        public string Descriptions { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public ICollection<Blog> Blogs { get; set; }
    }
}