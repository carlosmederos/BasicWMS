namespace BasicWMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Codigo", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Products", "Nombre", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Products", "CantidadDisponible", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "CantidadMinima", c => c.Int());
            AddColumn("dbo.Products", "Descripcion", c => c.String());
            AddColumn("dbo.Products", "Disponible", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "CategoriaId", c => c.Int(nullable: false));
            AddForeignKey("dbo.Products", "CategoriaId", "dbo.Category", "Id", cascadeDelete: true);
            CreateIndex("dbo.Products", "CategoriaId");
            DropColumn("dbo.Products", "Name");
            DropColumn("dbo.Products", "PartNumber");
            DropColumn("dbo.Products", "Label");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "StartingInventory");
            DropColumn("dbo.Products", "InventoryReceived");
            DropColumn("dbo.Products", "Inventory Shipped");
            DropColumn("dbo.Products", "Inventory on Hand");
            DropColumn("dbo.Products", "Minimum Required");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Minimum Required", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Inventory on Hand", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Inventory Shipped", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "InventoryReceived", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "StartingInventory", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "Description", c => c.String(maxLength: 100));
            AddColumn("dbo.Products", "Label", c => c.String());
            AddColumn("dbo.Products", "PartNumber", c => c.String());
            AddColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            DropIndex("dbo.Products", new[] { "CategoriaId" });
            DropForeignKey("dbo.Products", "CategoriaId", "dbo.Category");
            DropColumn("dbo.Products", "CategoriaId");
            DropColumn("dbo.Products", "Disponible");
            DropColumn("dbo.Products", "Descripcion");
            DropColumn("dbo.Products", "CantidadMinima");
            DropColumn("dbo.Products", "CantidadDisponible");
            DropColumn("dbo.Products", "Nombre");
            DropColumn("dbo.Products", "Codigo");
            DropTable("dbo.Category");
        }
    }
}
