﻿// <auto-generated />
using ETradeApp.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ETradeApp.Migrations
{
    [DbContext(typeof(ETradeAppContext))]
    partial class ETradeAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ETradeApp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Giyim"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Elektronik"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Ev"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Kozmetik"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "Spor"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Kitap"
                        });
                });

            modelBuilder.Entity("ETradeApp.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PictureName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Pictures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PictureName = "gomlek.png",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            PictureName = "mont.png",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 3,
                            PictureName = "laptop.png",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 4,
                            PictureName = "telefon.png",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 5,
                            PictureName = "koltuk.png",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 6,
                            PictureName = "parfum.png",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 7,
                            PictureName = "futboltopu.png",
                            ProductId = 7
                        },
                        new
                        {
                            Id = 8,
                            PictureName = "proteintozu.png",
                            ProductId = 8
                        },
                        new
                        {
                            Id = 9,
                            PictureName = "mogoltarihi.png",
                            ProductId = 9
                        },
                        new
                        {
                            Id = 10,
                            PictureName = "bizanstarihi.png",
                            ProductId = 10
                        });
                });

            modelBuilder.Entity("ETradeApp.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockAmount")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            ProductDescription = "Mavi Gömlek",
                            ProductName = "Gömlek",
                            StockAmount = 12,
                            UnitPrice = 45m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            ProductDescription = "Çocuk Montu",
                            ProductName = "Mont",
                            StockAmount = 4,
                            UnitPrice = 245m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            ProductDescription = "Lenovo Laptop",
                            ProductName = "Laptop",
                            StockAmount = 5,
                            UnitPrice = 12245m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            ProductDescription = "Akıllı Telefon",
                            ProductName = "Telefon",
                            StockAmount = 45,
                            UnitPrice = 5245m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            ProductDescription = "Yeşil Konforlu Koltuk",
                            ProductName = "Koltuk",
                            StockAmount = 32,
                            UnitPrice = 6245m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 4,
                            ProductDescription = "Kalıcı Parfüm",
                            ProductName = "Parfüm",
                            StockAmount = 22,
                            UnitPrice = 345m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            ProductDescription = "Desenli Futbol Topu",
                            ProductName = "Futbol Topu",
                            StockAmount = 32,
                            UnitPrice = 145m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            ProductDescription = "Mini Protein Tozu",
                            ProductName = "Protein Tozu",
                            StockAmount = 22,
                            UnitPrice = 445m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 6,
                            ProductDescription = "Abraham Constantin Mouradgea D’ohsson SELENGE YAYINLARI",
                            ProductName = "Moğol Tarihi",
                            StockAmount = 12,
                            UnitPrice = 45m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 6,
                            ProductDescription = "Kuruluşundan Yıkılışına Kadar",
                            ProductName = "Bizans Tarihi",
                            StockAmount = 2,
                            UnitPrice = 55m
                        });
                });

            modelBuilder.Entity("ETradeApp.Models.Picture", b =>
                {
                    b.HasOne("ETradeApp.Models.Product", null)
                        .WithMany("Pictures")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ETradeApp.Models.Product", b =>
                {
                    b.HasOne("ETradeApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ETradeApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ETradeApp.Models.Product", b =>
                {
                    b.Navigation("Pictures");
                });
#pragma warning restore 612, 618
        }
    }
}
