using InventoryHub.Shared.Entities;

namespace InventoryHub.Api.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(InventoryHubContext context)
    {
        if (context.Products.Any())
            return;

        var laptops      = new Category { Id = 1, Name = "Laptops" };
        var monitors     = new Category { Id = 2, Name = "Monitors" };
        var keyboards    = new Category { Id = 3, Name = "Keyboards" };
        var mice         = new Category { Id = 4, Name = "Mice" };
        var audio        = new Category { Id = 5, Name = "Audio" };
        var peripherals  = new Category { Id = 6, Name = "Peripherals" };
        var storage      = new Category { Id = 7, Name = "Storage" };
        var components   = new Category { Id = 8, Name = "Components" };

        var products = new List<Product>
        {
            new() { Id = Guid.NewGuid(), Name = "MacBook Pro 16\" M3 Pro",          Price = 2499.99m, Stock = 15, Category = laptops },
            new() { Id = Guid.NewGuid(), Name = "Dell XPS 15 Laptop",               Price = 1799.99m, Stock = 22, Category = laptops },
            new() { Id = Guid.NewGuid(), Name = "ASUS ROG Swift 27\" 4K Monitor",   Price =  899.99m, Stock = 30, Category = monitors },
            new() { Id = Guid.NewGuid(), Name = "LG UltraWide 34\" Monitor",        Price =  649.99m, Stock = 18, Category = monitors },
            new() { Id = Guid.NewGuid(), Name = "Logitech MX Keys Keyboard",        Price =  119.99m, Stock = 50, Category = keyboards },
            new() { Id = Guid.NewGuid(), Name = "Keychron Q1 Mechanical Keyboard",  Price =  169.99m, Stock = 35, Category = keyboards },
            new() { Id = Guid.NewGuid(), Name = "Logitech MX Master 3 Mouse",       Price =   99.99m, Stock = 60, Category = mice },
            new() { Id = Guid.NewGuid(), Name = "Razer DeathAdder V3 Mouse",        Price =   69.99m, Stock = 45, Category = mice },
            new() { Id = Guid.NewGuid(), Name = "Sony WH-1000XM5 Headphones",       Price =  349.99m, Stock = 25, Category = audio },
            new() { Id = Guid.NewGuid(), Name = "Logitech Brio 4K Webcam",          Price =  199.99m, Stock = 40, Category = peripherals },
            new() { Id = Guid.NewGuid(), Name = "Samsung 990 Pro 2TB NVMe SSD",     Price =  189.99m, Stock = 55, Category = storage },
            new() { Id = Guid.NewGuid(), Name = "Corsair Vengeance 32GB DDR5 RAM",  Price =  129.99m, Stock = 48, Category = components },
            new() { Id = Guid.NewGuid(), Name = "NVIDIA GeForce RTX 4070 Ti",       Price =  799.99m, Stock = 12, Category = components },
            new() { Id = Guid.NewGuid(), Name = "AMD Ryzen 9 7950X CPU",            Price =  549.99m, Stock = 20, Category = components },
            new() { Id = Guid.NewGuid(), Name = "Elgato Stream Deck MK.2",          Price =  149.99m, Stock = 33, Category = peripherals },
        };

        await context.Products.AddRangeAsync(products);
        await context.SaveChangesAsync();
    }
}
