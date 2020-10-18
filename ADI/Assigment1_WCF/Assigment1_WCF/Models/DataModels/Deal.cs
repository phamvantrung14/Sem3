using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Assigment1_WCF.Models.DataModels
{
    [DataContract]
    public class Deal
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Account_ID { get; set; }
        [DataMember]
        public string RecipientAccount{get;set;}
        [DataMember]
        public float DealMoney { get; set; }
        [DataMember]
        public float TransactionFees { get; set; }
        [DataMember]
        public DateTime Created { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        [ForeignKey("Account_ID")]
        public Account Account { get; set; }

    }
}