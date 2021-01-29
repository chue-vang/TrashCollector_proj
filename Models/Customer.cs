using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address { get; set; }
        public string Zipcode { get; set; }
        public string Pickup_Day { get; set; }
        public DateTime Extra_Pickup { get; set; }
        public DateTime Start_Suspend_Date { get; set; }
        public DateTime End_Suspend_Date { get; set; }
        public int Charges_Owe { get; set; }
        public bool Confirm_Pickup { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentitiyUser { get; set; }
    }
}
