namespace ICA01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branch_tbl",
                c => new
                    {
                        BranchNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                    })
                .PrimaryKey(t => t.BranchNo);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        OwnerNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Address = c.String(),
                        telPhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerNo);
            
            CreateTable(
                "dbo.Rent",
                c => new
                    {
                        PropertyNo = c.String(nullable: false, maxLength: 128),
                        Street = c.String(),
                        City = c.String(),
                        Ptype = c.String(),
                        Rooms = c.String(),
                        RefOwnernumber = c.String(maxLength: 128),
                        RefStaffNo = c.String(maxLength: 128),
                        RefBranchNo = c.String(maxLength: 128),
                        Rent1 = c.String(),
                        Rents_PropertyNo = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PropertyNo)
                .ForeignKey("dbo.Branch_tbl", t => t.RefBranchNo)
                .ForeignKey("dbo.Owner", t => t.RefOwnernumber)
                .ForeignKey("dbo.Rent", t => t.Rents_PropertyNo)
                .ForeignKey("dbo.Staff_tbl", t => t.RefStaffNo)
                .Index(t => t.RefOwnernumber)
                .Index(t => t.RefStaffNo)
                .Index(t => t.RefBranchNo)
                .Index(t => t.Rents_PropertyNo);
            
            CreateTable(
                "dbo.Staff_tbl",
                c => new
                    {
                        StaffNo = c.String(nullable: false, maxLength: 128),
                        Fname = c.String(),
                        Lname = c.String(),
                        Position = c.String(),
                        DOB = c.DateTime(nullable: false),
                        salary = c.Int(nullable: false),
                        Branchref = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StaffNo)
                .ForeignKey("dbo.Branch_tbl", t => t.Branchref)
                .Index(t => t.Branchref);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rent", "RefStaffNo", "dbo.Staff_tbl");
            DropForeignKey("dbo.Staff_tbl", "Branchref", "dbo.Branch_tbl");
            DropForeignKey("dbo.Rent", "Rents_PropertyNo", "dbo.Rent");
            DropForeignKey("dbo.Rent", "RefOwnernumber", "dbo.Owner");
            DropForeignKey("dbo.Rent", "RefBranchNo", "dbo.Branch_tbl");
            DropIndex("dbo.Staff_tbl", new[] { "Branchref" });
            DropIndex("dbo.Rent", new[] { "Rents_PropertyNo" });
            DropIndex("dbo.Rent", new[] { "RefBranchNo" });
            DropIndex("dbo.Rent", new[] { "RefStaffNo" });
            DropIndex("dbo.Rent", new[] { "RefOwnernumber" });
            DropTable("dbo.Staff_tbl");
            DropTable("dbo.Rent");
            DropTable("dbo.Owner");
            DropTable("dbo.Branch_tbl");
        }
    }
}
