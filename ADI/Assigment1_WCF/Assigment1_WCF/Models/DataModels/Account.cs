using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Assigment1_WCF.Models.DataModels
{
    [DataContract]
    public class Account
    {
        [Key]
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string AccountName { get; set; }
        [DataMember]
        public int CodePin { get; set; }
        [DataMember]
        public float Money { get; set; }
        [DataMember]
        public int CMND { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
       
        public ICollection<Deal> Deals { get; set; }
    }
}