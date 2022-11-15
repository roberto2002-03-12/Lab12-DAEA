namespace CodeFirstDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_3_entitys : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.InvoiceDetails",
                c => new
                    {
                        InvoiceDetailId = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.InvoiceDetailId);
            
            CreateTable(
                "dbo.Sellers",
                c => new
                    {
                        SellerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.SellerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sellers");
            DropTable("dbo.InvoiceDetails");
            DropTable("dbo.Customers");
        }
    }
}
