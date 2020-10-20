using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    [Table("Staff_tbl")]
    public class Staff
    {
        [Key]
        public String StaffNo { get; set; }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String Position { get; set; }
        public DateTime DOB { get; set; }
        public int salary { get; set; }
        public String Branchref { get; set; }
        [ForeignKey("Branchref")]
        public virtual Branch Branch { get; set; }
        public List<Rent> Rents { get; set; }
    }
}