using InventoryHub.Shared.Entities;

namespace InventoryHub.Api.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(InventoryHubContext context)
    {
        if (context.Products.Any())
            return;

        var products = new List<Product>
        {
            new() { Id = Guid.NewGuid(), Name = "MacBook Pro 16\" M3 Pro", Price = 2499.99m, Stock = 15 },
            new() { Id = Guid.NewGuid(), Name = "Dell XPS 15 Laptop", Price = 1799.99m, Stock = 22 },
            new() { Id = Guid.NewGuid(), Name = "ASUS ROG Swift 27\" 4K Monitor", Price = 899.99m, Stock = 30 },
            new() { Id = Guid.NewGuid(), Name = "LG UltraWide 34\" Monitor", Price = 649.99m, Stock = 18 },
            new() { Id = Guid.NewGuid(), Name = "Logitech MX Keys Keyboard", Price = 119.99m, Stock = 50 },
            new() { Id = Guid.NewGuid(), Name = "Keychron Q1 Mechanical Keyboard", Price = 169.99m, Stock = 35 },
            new() { Id = Guid.NewGuid(), Name = "Logitech MX Master 3 Mouse", Price = 99.99m, Stock = 60 },
            new() { Id = Guid.NewGuid(), Name = "Razer DeathAdder V3 Mouse", Price = 69.99m, Stock = 45 },
            new() { Id = Guid.NewGuid(), Name = "Sony WH-1000XM5 Headphones", Price = 349.99m, Stock = 25 },
            new() { Id = Guid.NewGuid(), Name = "Logitech Brio 4K Webcam", Price = 199.99m, Stock = 40 },
            new() { Id = Guid.NewGuid(), Name = "Samsung 990 Pro 2TB NVMe SSD", Price = 189.99m, Stock = 55 },
            new() { Id = Guid.NewGuid(), Name = "Corsair Vengeance 32GB DDR5 RAM", Price = 129.99m, Stock = 48 },
            new() { Id = Guid.NewGuid(), Name = "NVIDIA GeForce RTX 4070 Ti", Price = 799.99m, Stock = 12 },
            new() { Id = Guid.NewGuid(), Name = "AMD Ryzen 9 7950X CPU", Price = 549.99m, Stock = 20 },
            new() { Id = Guid.NewGuid(), Name = "Elgato Stream Deck MK.2", Price = 149.99m, Stock = 33 },
        };

        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();
    }
}
