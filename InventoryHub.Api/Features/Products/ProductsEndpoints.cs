using InventoryHub.Api.Features.Products.GetProducts;

namespace InventoryHub.Api.Features.Products;

public static class ProductsEndpoints
{
    public static void MapProductsEndpoints(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/products");
        group.MapGetProducts();
    }
}