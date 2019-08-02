namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameConvensionCustomer : DbMigration
    {
        public override void Up()
        {
            // Add this line
            RenameColumn("dbo.Customers", "name", "Name");
        }
        
        public override void Down()
        {
            // Add this line
            RenameColumn("dbo.Customers", "name", "Name");
        }
    }
}
