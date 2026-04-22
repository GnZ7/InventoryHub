using InventoryHub.Api.Data.EntityConfigurations;
using InventoryHub.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventoryHub.Api.Data;

public class InventoryHubContext(DbContextOptions<InventoryHubContext> options) : DbContext(options)
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}