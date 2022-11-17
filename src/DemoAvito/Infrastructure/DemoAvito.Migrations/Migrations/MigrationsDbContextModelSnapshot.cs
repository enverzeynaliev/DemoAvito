﻿// <auto-generated />
using System;
using DemoAvito.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DemoAvito.Migrations.Migrations
{
    [DbContext(typeof(MigrationsDbContext))]
    partial class MigrationsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DemoAvito.Domain.Adverts", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreationDate")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasMaxLength(800)
                        .HasColumnType("character varying(800)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("ProductPrice")
                        .HasColumnType("integer");

                    b.Property<string>("SubCategory")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ProductId");

                    b.ToTable("DemoAvitoDtoAdverts", (string)null);
                });

            modelBuilder.Entity("DemoAvito.Domain.Categories", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories", (string)null);
                });

            modelBuilder.Entity("DemoAvito.Domain.Cities", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("NameCity")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("CityId");

                    b.ToTable("CitiesTable", (string)null);
                });

            modelBuilder.Entity("DemoAvito.Domain.Pictures", b =>
                {
                    b.Property<Guid>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PictureId");

                    b.ToTable("Images", (string)null);
                });

            modelBuilder.Entity("DemoAvito.Domain.Adverts", b =>
                {
                    b.HasOne("DemoAvito.Domain.Categories", "Category")
                        .WithMany("Advert")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DemoAvito.Domain.Cities", "LocationCity")
                        .WithMany("Advert")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("LocationCity");
                });

            modelBuilder.Entity("DemoAvito.Domain.Pictures", b =>
                {
                    b.HasOne("DemoAvito.Domain.Adverts", "Advert")
                        .WithMany("Picture")
                        .HasForeignKey("PictureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("DemoAvito.Domain.Adverts", b =>
                {
                    b.Navigation("Picture");
                });

            modelBuilder.Entity("DemoAvito.Domain.Categories", b =>
                {
                    b.Navigation("Advert");
                });

            modelBuilder.Entity("DemoAvito.Domain.Cities", b =>
                {
                    b.Navigation("Advert");
                });
#pragma warning restore 612, 618
        }
    }
}
