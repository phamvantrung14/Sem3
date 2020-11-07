using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestConsumerAs2.Models
{
    public class Blog
    {

      
        public int ID { get; set; }
        public string Title { get; set; }

        public string ContentShort { get; set; }
        public string Content { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Created { get; set; }
        public int Status { get; set; }
        public string Place { get; set; }
        public int views { get; set; }
        public int UserID { get; set; }
        public string Image { get; set; }
        public int TypeBlogID { get; set; }

      /*  public TypeBlog TypeBlog { get; set; }*/

        /*public User User { get; set; }*/

        /*public ICollection<Comments> Comments { get; set; }*/
    }
}