using System.ComponentModel.DataAnnotations;

namespace InventoryHub.Shared.Entities;

public class Category
{
    [Required] public int Id { get; set; }
    [Required] public string Name { get; set; } = string.Empty;
}
