namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountAccesses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        ModuleId = c.Int(nullable: false),
                        Accessible = c.Boolean(nullable: false),
                        AddRecord = c.Boolean(nullable: false),
                        EditRecord = c.Boolean(nullable: false),
                        DeleteRecord = c.Boolean(nullable: false),
                        GenerateReport = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Modules", t => t.ModuleId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.ModuleId);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rfid = c.String(),
                        UserName = c.String(),
                        UserPass = c.String(),
                        UserLevel = c.Byte(nullable: false),
                        LockCode = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ProfileImage = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Flag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AccountLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rfid = c.String(),
                        AccountId = c.Int(nullable: false),
                        UserName = c.String(),
                        UserPass = c.String(),
                        LockCode = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ProfileImage = c.String(),
                        Flag = c.Boolean(nullable: false),
                        CommandType = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.AuditTrails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        Activity = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.ConsumableOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        DateOrdered = c.DateTime(nullable: false),
                        DateDelivered = c.DateTime(nullable: false),
                        OrderStatus = c.Byte(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.CosumableOrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumableOrderId = c.Int(nullable: false),
                        OrderStatus = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ConsumableOrders", t => t.ConsumableOrderId, cascadeDelete: true)
                .Index(t => t.ConsumableOrderId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        ContactNo = c.String(),
                        EmailAddress = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        Flag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Consumables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(),
                        Description = c.String(),
                        MinimumStocks = c.Short(nullable: false),
                        NearExpirationAlert = c.Short(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        Flag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.ConsumableLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumableId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Unit = c.String(),
                        Description = c.String(),
                        MinimumStocks = c.Short(nullable: false),
                        NearExpiryAlert = c.Short(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        ActionType = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consumables", t => t.ConsumableId, cascadeDelete: true)
                .Index(t => t.ConsumableId);
            
            CreateTable(
                "dbo.ConsumableStocks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ConsumableId = c.Int(nullable: false),
                        Stock = c.Short(nullable: false),
                        DepreciatedStock = c.Short(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        DateDelivered = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Consumables", t => t.ConsumableId, cascadeDelete: true)
                .Index(t => t.ConsumableId);
            
            CreateTable(
                "dbo.SupplierLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierId = c.Int(nullable: false),
                        Name = c.String(),
                        Company = c.String(),
                        ContactNo = c.String(),
                        EmailAddress = c.String(),
                        Flag = c.Boolean(nullable: false),
                        ActionType = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TableNo = c.Short(nullable: false),
                        DateOrdered = c.DateTime(nullable: false),
                        DateServed = c.DateTime(nullable: false),
                        OrderStatus = c.Byte(nullable: false),
                        AccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        OrderStatus = c.Byte(nullable: false),
                        MenuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Acronym = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Availability = c.Boolean(nullable: false),
                        MenuImage = c.String(),
                        Flag = c.Boolean(nullable: false),
                        MenuCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MenuCategories", t => t.MenuCategory_Id)
                .Index(t => t.MenuCategory_Id);
            
            CreateTable(
                "dbo.MenuCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MenuLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuId = c.Int(nullable: false),
                        Name = c.String(),
                        Acronym = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Availability = c.Boolean(nullable: false),
                        MenuImage = c.String(),
                        Flag = c.Boolean(nullable: false),
                        ActionType = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.MenuId, cascadeDelete: true)
                .Index(t => t.MenuId);
            
            CreateTable(
                "dbo.OrderPayments",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        DiscountId = c.Int(nullable: false),
                        CashReceived = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Discounts", t => t.DiscountId, cascadeDelete: true)
                .ForeignKey("dbo.Orders", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.DiscountId);
            
            CreateTable(
                "dbo.Discounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountType = c.Byte(nullable: false),
                        Flag = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DiscountLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiscountId = c.Int(nullable: false),
                        Name = c.String(),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountType = c.Byte(nullable: false),
                        Flag = c.Boolean(nullable: false),
                        ActionType = c.String(),
                        LastUpdated = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Discounts", t => t.DiscountId, cascadeDelete: true)
                .Index(t => t.DiscountId);
            
            CreateTable(
                "dbo.Modules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountAccesses", "ModuleId", "dbo.Modules");
            DropForeignKey("dbo.OrderPayments", "Id", "dbo.Orders");
            DropForeignKey("dbo.OrderPayments", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.DiscountLogs", "DiscountId", "dbo.Discounts");
            DropForeignKey("dbo.OrderDetails", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderDetails", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.MenuLogs", "MenuId", "dbo.Menus");
            DropForeignKey("dbo.Menus", "MenuCategory_Id", "dbo.MenuCategories");
            DropForeignKey("dbo.Orders", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.SupplierLogs", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Consumables", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.ConsumableStocks", "ConsumableId", "dbo.Consumables");
            DropForeignKey("dbo.ConsumableLogs", "ConsumableId", "dbo.Consumables");
            DropForeignKey("dbo.ConsumableOrders", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.CosumableOrderDetails", "ConsumableOrderId", "dbo.ConsumableOrders");
            DropForeignKey("dbo.ConsumableOrders", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.AuditTrails", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.AccountLogs", "AccountId", "dbo.Accounts");
            DropForeignKey("dbo.AccountAccesses", "AccountId", "dbo.Accounts");
            DropIndex("dbo.DiscountLogs", new[] { "DiscountId" });
            DropIndex("dbo.OrderPayments", new[] { "DiscountId" });
            DropIndex("dbo.OrderPayments", new[] { "Id" });
            DropIndex("dbo.MenuLogs", new[] { "MenuId" });
            DropIndex("dbo.Menus", new[] { "MenuCategory_Id" });
            DropIndex("dbo.OrderDetails", new[] { "MenuId" });
            DropIndex("dbo.OrderDetails", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "AccountId" });
            DropIndex("dbo.SupplierLogs", new[] { "SupplierId" });
            DropIndex("dbo.ConsumableStocks", new[] { "ConsumableId" });
            DropIndex("dbo.ConsumableLogs", new[] { "ConsumableId" });
            DropIndex("dbo.Consumables", new[] { "SupplierId" });
            DropIndex("dbo.CosumableOrderDetails", new[] { "ConsumableOrderId" });
            DropIndex("dbo.ConsumableOrders", new[] { "AccountId" });
            DropIndex("dbo.ConsumableOrders", new[] { "SupplierId" });
            DropIndex("dbo.AuditTrails", new[] { "AccountId" });
            DropIndex("dbo.AccountLogs", new[] { "AccountId" });
            DropIndex("dbo.AccountAccesses", new[] { "ModuleId" });
            DropIndex("dbo.AccountAccesses", new[] { "AccountId" });
            DropTable("dbo.Modules");
            DropTable("dbo.DiscountLogs");
            DropTable("dbo.Discounts");
            DropTable("dbo.OrderPayments");
            DropTable("dbo.MenuLogs");
            DropTable("dbo.MenuCategories");
            DropTable("dbo.Menus");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Orders");
            DropTable("dbo.SupplierLogs");
            DropTable("dbo.ConsumableStocks");
            DropTable("dbo.ConsumableLogs");
            DropTable("dbo.Consumables");
            DropTable("dbo.Suppliers");
            DropTable("dbo.CosumableOrderDetails");
            DropTable("dbo.ConsumableOrders");
            DropTable("dbo.AuditTrails");
            DropTable("dbo.AccountLogs");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountAccesses");
        }
    }
}
