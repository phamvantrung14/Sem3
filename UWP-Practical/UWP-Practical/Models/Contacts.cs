using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Practical.Models
{
    public class Contacts
    {
       [PrimaryKey]
        public string Phone { get; set; }
        public string Name { get; set; }

    }
}
