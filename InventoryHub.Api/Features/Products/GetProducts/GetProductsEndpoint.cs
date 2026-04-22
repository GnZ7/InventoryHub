using InventoryHub.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace InventoryHub.Api.Features.Products.GetProducts;

public static class GetProductsEndpoint
{
    public static void MapGetProducts(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (InventoryHubContext dbContext) =>
        {
            return await dbContext.Products
                .Include(product => product.Category)
                .Select(product => new ProductDto(
                    product.Id,
                    product.Name,
                    product.Price,
                    product.Stock,
                    product.Category == null ? null : new CategoryDto(product.Category.Id, product.Category.Name)))                
                .AsNoTracking()
                .ToListAsync();
        }).Produces<List<ProductDto>>();
    }

    public record CategoryDto(int Id, string Name);
    public record ProductDto(Guid Id, string Name, decimal Price, int Stock, CategoryDto? Category);
}