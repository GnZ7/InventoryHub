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
                 .Select(product => new ProductDto(product.Id, product.Name, product.Price, product.Stock))
                 .AsNoTracking()
                 .ToListAsync();
        }).Produces<List<ProductDto>>();
    }

    public record ProductDto(Guid Id, string Name, decimal Price, int Stock);
}