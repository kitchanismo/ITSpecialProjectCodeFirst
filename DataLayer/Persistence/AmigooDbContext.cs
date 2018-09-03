

namespace DataLayer.Persistence
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using DataLayer.Core.Model;
    using System.Linq;

    public class AmigooDbContext : DbContext
    {
        public AmigooDbContext()
            : base("name=AmigooDbContext")
        {
            Database.SetInitializer<AmigooDbContext>(new DataSeeder());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasRequired(o => o.OrderPayment)
                .WithRequiredPrincipal(o => o.Order);
             
        }

        public virtual DbSet<AccountLog> AccountLogs { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ConsumableLog> ConsumableLogs { get; set; }
        public virtual DbSet<ConsumableOrder> ConsumableOrders { get; set; }
        public virtual DbSet<Consumable> Consumables { get; set; }
        public virtual DbSet<ConsumableStock> ConsumableStocks { get; set; }
        public virtual DbSet<CosumableOrderDetail> CosumableOrderDetails { get; set; }
        public virtual DbSet<DiscountLog> DiscountLogs { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderPayment> OrderPayments { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SupplierLog> SupplierLogs { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<AccountAccess> AccountAccesses { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<MenuLog> MenuLogs { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
    }
}
