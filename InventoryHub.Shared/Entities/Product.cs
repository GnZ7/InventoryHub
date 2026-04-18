using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace InventoryHub.Shared.Entities
{
    public class Product
    {
        [Required] public Guid Id { get; set; }
        [Required] public string Name { get; set; } = string.Empty;
        [Required] public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
