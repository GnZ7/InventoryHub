using System;
using System.Globalization;
using InventoryHub.Shared.Entities;

namespace InventoryHub.Client.Extensions;

public static class ProductExtensions
{
    public static string ToUsdPrice(this Product product)
    {
        ArgumentNullException.ThrowIfNull(product);
        return "$" + product.Price.ToString("0.00", CultureInfo.InvariantCulture);
    }
}
