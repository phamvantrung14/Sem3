using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManagerProduct.Models.Entity
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string ProName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

    }
}