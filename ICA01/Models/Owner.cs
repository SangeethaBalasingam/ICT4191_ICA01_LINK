using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    [Table("Owner_tbl")]
    public class Owner
    {
        [Key]
        public String OwnerNo { get; set; }
        [Display(Name ="FirstName")]
        public String Fname { get; set; }
        [Display(Name = "LastName")]
        public String Lname { get; set; }
        public String Address { get; set; }
        public int telPhoneNumber { get; set; }
        public List<Rent> Rents { get; set; }

    }
}