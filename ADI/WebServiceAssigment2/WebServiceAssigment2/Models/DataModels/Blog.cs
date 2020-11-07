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
    public class Blog
    {
        [Key]
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string ContentShort { get; set; }
        [DataMember]
        public string Content { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public int Status { get; set; }
        [DataMember]
        public string Place { get; set; }
        [DataMember]
        public int views { get; set; }
        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public string Image { get; set; }
        [DataMember]
        public int TypeBlogID { get; set; }
        
        [ForeignKey("TypeBlogID")]
        public TypeBlog TypeBlog { get; set; }
       
        [ForeignKey("UserID")]
        public User User {get;set;}
        
        /*public ICollection<Comments> Comments { get; set; }*/

    }
}