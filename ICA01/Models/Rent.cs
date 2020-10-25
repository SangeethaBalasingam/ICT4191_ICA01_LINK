using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    [Table("Rent_tbl")]
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Ptype { get; set; }
        public String Rooms { get; set; }
        [Display(Name ="Owner")]
        public String RefOwnernumber { get; set; }
        [ForeignKey("RefOwnernumber")]
        public virtual Owner Owners { get; set; }
        [Display(Name = "Staff")]
        public String RefStaffNo { get; set; }
        [ForeignKey("RefStaffNo ")]
        public virtual Staff Staffs { get; set; }
        [Display(Name = "Branch")]
        public String RefBranchNo { get; set; }
        [ForeignKey("RefBranchNo")]
        public virtual Branch Branchs { get; set; }
        public String Rent1 { get; set; }
        public virtual Rent Rents { get; set; }





    }
}