using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class Rent
    {
        [Key]
        public String PropertyNo { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String Ptype { get; set; }
        public String Rooms { get; set; }
        public String RefOwnernumber { get; set; }
        [ForeignKey("RefOwnernumber")]
        public String RefStaffNo { get; set; }
        [ForeignKey("RefstaffNo")]
        public String RefBranchNo { get; set; }
        [ForeignKey("RefBranchNo")]
        public String Rent1 { get; set; }



    }
}