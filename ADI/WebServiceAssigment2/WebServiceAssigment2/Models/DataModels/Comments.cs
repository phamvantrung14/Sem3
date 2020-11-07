using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WebServiceAssigment2.Models.DataModels
{
    [DataContract]
    public class Comments
    {
        [Key]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public int Rate { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public int ParentId { get; set; }
        [DataMember]
        public int CustomerID { get; set; }
        [DataMember]
        public int BlogID { get; set; }
        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
        [ForeignKey("BlogID")]
        public Blog Blog { get; set; }
    }
}