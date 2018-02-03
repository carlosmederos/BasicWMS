namespace BasicWMS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        PartNumber = c.String(),
                        ProductLabel = c.String(),
                        StartingInventory = c.Int(nullable: false),
                        InventoryReceived = c.Int(nullable: false),
                        InventoryShipped = c.Int(nullable: false),
                        InventoryOnHand = c.Int(nullable: false),
                        MinimumRequired = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        First = c.String(),
                        Middle = c.String(),
                        Last = c.String(),
                        NumberShipped = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Product", t => t.Product_ProductId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Purchase",
                c => new
                    {
                        PurchaseId = c.Int(nullable: false, identity: true),
                        NumberReceived = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        Supplier_SupplierId = c.Int(),
                        Product_ProductId = c.Int(),
                    })
                .PrimaryKey(t => t.PurchaseId)
                .ForeignKey("dbo.Supplier", t => t.Supplier_SupplierId)
                .ForeignKey("dbo.Product", t => t.Product_ProductId)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierId = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Purchase", new[] { "Product_ProductId" });
            DropIndex("dbo.Purchase", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.Order", new[] { "Product_ProductId" });
            DropForeignKey("dbo.Purchase", "Product_ProductId", "dbo.Product");
            DropForeignKey("dbo.Purchase", "Supplier_SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Order", "Product_ProductId", "dbo.Product");
            DropTable("dbo.Supplier");
            DropTable("dbo.Purchase");
            DropTable("dbo.Order");
            DropTable("dbo.Product");
        }
    }
}
