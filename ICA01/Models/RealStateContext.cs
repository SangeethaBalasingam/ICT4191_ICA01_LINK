using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ICA01.Models
{
    public class RealStateContext:DbContext
    {
        public DbSet<Branch> Branchs { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Rent> Rents { get; set; }
        public DbSet<Owner> Owners { get; set; }

    }
}