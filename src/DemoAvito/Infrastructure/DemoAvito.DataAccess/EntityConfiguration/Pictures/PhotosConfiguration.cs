using DemoAvito.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoAvito.DataAccess.EntityConfiguration.Pictures;

public class PhotosConfiguration : IEntityTypeConfiguration<Domain.Pictures>
{
    public void Configure(EntityTypeBuilder<Domain.Pictures> builder)
    {
        builder.ToTable("Images");

        builder.HasKey(b => b.PictureId);
        builder.Property(b => b.PictureId).ValueGeneratedOnAdd();

        builder.HasOne(p => p.Advert)
            .WithMany(s => s.Picture).HasForeignKey(s => s.PictureId);
        // builder.HasMany(p => p)
        //     .WithMany(s=> s);

    }
}