using InventoryHub.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InventoryHub.Api.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(product => product.Id);

            builder.Property(product => product.Id)
                .ValueGeneratedOnAdd();

            builder.Property(product => product.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(product => product.Price)
                .HasColumnType("decimal(18,2)");

            builder.Property(product => product.Stock)
                .HasDefaultValue(0);
        }
    }
}
