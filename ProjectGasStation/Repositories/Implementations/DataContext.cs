using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjectGasStation.Entities;

namespace ProjectGasStation.Repositories.Implementations;

public class DataContext : DbContext
{
    public DbSet<Fuel> Fuels => Set<Fuel>();

    public DbSet<Seller> Sellers => Set<Seller>();

    public DbSet<Supplier> Suppliers => Set<Supplier>();

    public DbSet<Sale> Sales => Set<Sale>();

    public DbSet<Purchase> Purchases => Set<Purchase>();

    public DbSet<FuelPurchase> FuelPurchases => Set<FuelPurchase>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (optionsBuilder.IsConfigured)
        {
            return;
        }

        var basePath = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"))
            ? Directory.GetCurrentDirectory()
            : AppContext.BaseDirectory;
        var configuration = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasOne(x => x.Seller)
                .WithMany()
                .HasForeignKey(x => x.SellerId)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasOne(x => x.Fuel)
                .WithMany()
                .HasForeignKey(x => x.FuelId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasOne(x => x.Supplier)
                .WithMany()
                .HasForeignKey(x => x.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);
            entity.HasMany(x => x.FuelPurchases)
                .WithOne()
                .HasForeignKey("PurchaseId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<FuelPurchase>(entity =>
        {
            entity.HasOne(x => x.Fuel)
                .WithMany()
                .HasForeignKey(x => x.FuelId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        base.OnModelCreating(modelBuilder);
    }
}
