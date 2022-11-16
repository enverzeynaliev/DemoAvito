using DemoAvito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAvito.DataAccess.EntityConfiguration.Category;

public class CategoryConfiguration : IEntityTypeConfiguration<Domain.Categories>
{
    public void Configure(EntityTypeBuilder<Categories> builder)
    {
        builder.ToTable("Categories");

        builder.HasKey(b => b.CategoryId);
        builder.Property(b => b.CategoryId).ValueGeneratedOnAdd();

        builder.HasMany(p => p.Advert)
            .WithOne(s => s.Category)
            .HasForeignKey(s => s.ProductId);

    }
}