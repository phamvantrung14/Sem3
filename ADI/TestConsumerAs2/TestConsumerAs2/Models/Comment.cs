using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestConsumerAs2.Models
{
    public class Comment
    {
       
        public int ID { get; set; }
      
        public DateTime Created { get; set; }
      
        public int Rate { get; set; }
        
        public string Content { get; set; }
        
        public int ParentId { get; set; }
        
        public int CustomerID { get; set; }
       
        public int BlogID { get; set; }
        [ForeignKey("CustomerID")]
       /* public Customer Customer { get; set; }
        [ForeignKey("BlogID")]*/
        public Blog Blog { get; set; }
    }
}