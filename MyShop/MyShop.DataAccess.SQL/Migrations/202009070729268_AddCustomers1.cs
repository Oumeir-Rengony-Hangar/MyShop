namespace MyShop.DataAccess.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomers1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.Customers", "FirtsName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "FirtsName", c => c.String());
            DropColumn("dbo.Customers", "FirstName");
        }
    }
}
