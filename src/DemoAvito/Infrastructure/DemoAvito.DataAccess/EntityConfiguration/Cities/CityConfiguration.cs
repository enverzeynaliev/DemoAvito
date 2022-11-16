using DemoAvito.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAvito.DataAccess.EntityConfiguration.Cities;

public class CityConfiguration : IEntityTypeConfiguration<Domain.Cities>
{
    public void Configure(EntityTypeBuilder<Domain.Cities> builder)
    {
        builder.ToTable("CitiesTable");

        builder.HasKey(b => b.CityId);
        builder.Property(b => b.CityId).ValueGeneratedOnAdd();

        builder.Property(b => b.NameCity).HasMaxLength(200);

        builder.HasMany(p => p.Advert)
            .WithOne(s => s.LocationCity)
            .HasForeignKey(s => s.ProductId);
    }
}