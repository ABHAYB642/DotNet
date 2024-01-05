using Microsoft.EntityFrameworkCore;
using IOCWebApp.Models;

namespace IOCWebApp.Contexts
{
    public class CollectionContext:DbContext{
    public DbSet<Product> Products {get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString="server=127.0.0.1;uid=root;" +  "pwd=password;database=ecommerce";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity => 
        {
          entity.HasKey(e => e.Product_Id);
          entity.Property(e => e.Product_Title).IsRequired();
          entity.Property(e => e.Unit_Price).IsRequired();
          entity.Property(e => e.Stock_Available).IsRequired();
        });
        modelBuilder.Entity<Product>().ToTable("products");
    }
    }
}