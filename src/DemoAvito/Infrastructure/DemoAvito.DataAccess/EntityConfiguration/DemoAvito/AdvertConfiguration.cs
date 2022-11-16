using DemoAvito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAvito.DataAccess.EntityConfiguration.DemoAvito;

/// <summary>
/// Конфигурация таблицы Объявления
/// </summary>
public class AdvertConfiguration : IEntityTypeConfiguration<Adverts>
{
    public void Configure(EntityTypeBuilder<Adverts> builder)
    {
        builder.ToTable("DemoAvitoDtoAdverts");

        builder.HasKey(b => b.ProductId);
        builder.Property(b => b.ProductId).ValueGeneratedOnAdd();

        builder.Property(b => b.ProductName).HasMaxLength(50);
        builder.Property(b => b.Description).HasMaxLength(800);

        // builder.HasMany(p => p.Picture)
        //     .WithOne(s => s.Advert).HasForeignKey(s => s.ProductId);
    }
}