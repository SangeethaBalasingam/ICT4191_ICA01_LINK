namespace ICA01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sample2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Owner", newName: "Owner_tbl");
            RenameTable(name: "dbo.Rent", newName: "Rent_tbl");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Rent_tbl", newName: "Rent");
            RenameTable(name: "dbo.Owner_tbl", newName: "Owner");
        }
    }
}
