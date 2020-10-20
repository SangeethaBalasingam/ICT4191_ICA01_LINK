using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    [Table("Branch_tbl")]
    public class Branch
    {
        [Key]
        public String BranchNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String PostCode { get; set; }
       // public virtual ICollection<Staff> Staffs { get; set; }
       // public ICollection<Rent> Rents { get; set; }
    }
}