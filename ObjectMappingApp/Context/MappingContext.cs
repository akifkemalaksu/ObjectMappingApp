using Microsoft.EntityFrameworkCore;
using ObjectMappingApp.Entities;

namespace ObjectMappingApp.Context
{
    public class MappingContext : DbContext
    {


        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Stock> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=LAPTOP-QQR4LF3U; Database=BikeStores; Trusted_Connection=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>().HasKey(x => new
            {
                x.OrderId,
                x.ItemId
            });

            modelBuilder.Entity<Stock>().HasKey(x => new
            {
                x.StoreId,
                x.ProductId
            });
        }
    }
}
