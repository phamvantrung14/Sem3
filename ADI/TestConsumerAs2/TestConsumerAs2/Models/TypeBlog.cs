using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestConsumerAs2.Models
{
    public class TypeBlog
    {
        public int ID { get; set; }

        public string TypeName { get; set; }

        public string Descriptions { get; set; }

        public int Status { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }
    }
}