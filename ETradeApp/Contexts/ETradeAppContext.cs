using ETradeApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeApp.Contexts
{
    public class ETradeAppContext:DbContext
    {
        public ETradeAppContext(DbContextOptions<ETradeAppContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Picture> Pictures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData
                (
                new Category {Id=1, CategoryName="Giyim"},
                new Category {Id=2, CategoryName="Elektronik"},
                new Category {Id=3, CategoryName="Ev"},
                new Category {Id=4, CategoryName="Kozmetik"},
                new Category {Id=5, CategoryName="Spor"},
                new Category {Id=6, CategoryName="Kitap"}
                );

            modelBuilder.Entity<Product>().HasData
                (
                new Product { Id = 1, CategoryId = 1, ProductName = "Gömlek", ProductDescription="Mavi Gömlek", StockAmount=12, UnitPrice=45 },
                new Product { Id = 2, CategoryId = 1, ProductName = "Mont", ProductDescription="Çocuk Montu", StockAmount=4, UnitPrice=245 },
                new Product { Id = 3, CategoryId = 2, ProductName = "Laptop", ProductDescription="Lenovo Laptop", StockAmount=5, UnitPrice=12245 },
                new Product { Id = 4, CategoryId = 2, ProductName = "Telefon", ProductDescription="Akıllı Telefon", StockAmount=45, UnitPrice=5245 },
                new Product { Id = 5, CategoryId = 3, ProductName = "Koltuk", ProductDescription="Yeşil Konforlu Koltuk", StockAmount=32, UnitPrice=6245 },
                new Product { Id = 6, CategoryId = 4, ProductName = "Parfüm", ProductDescription="Kalıcı Parfüm", StockAmount=22, UnitPrice=345 },
                new Product { Id = 7, CategoryId = 5, ProductName = "Futbol Topu", ProductDescription="Desenli Futbol Topu", StockAmount=32, UnitPrice=145 },
                new Product { Id = 8, CategoryId = 5, ProductName = "Protein Tozu", ProductDescription="Mini Protein Tozu", StockAmount=22, UnitPrice=445 },
                new Product { Id = 9, CategoryId = 6, ProductName = "Moğol Tarihi", ProductDescription= "Abraham Constantin Mouradgea D’ohsson SELENGE YAYINLARI", StockAmount=12, UnitPrice=45 },
                new Product { Id = 10, CategoryId = 6, ProductName = "Bizans Tarihi", ProductDescription= "Kuruluşundan Yıkılışına Kadar", StockAmount=2, UnitPrice=55 }
                
                );

            modelBuilder.Entity<Picture>().HasData
                (
                new Picture { Id=1, ProductId = 1, PictureName="gomlek.png"},
                new Picture { Id=2, ProductId = 2, PictureName="mont.png"},
                new Picture { Id=3, ProductId = 3, PictureName="laptop.png"},
                new Picture { Id=4, ProductId = 4, PictureName="telefon.png"},
                new Picture { Id=5, ProductId = 5, PictureName="koltuk.png"},
                new Picture { Id=6, ProductId = 6, PictureName="parfum.png"},
                new Picture { Id=7, ProductId = 7, PictureName="futboltopu.png"},
                new Picture { Id=8, ProductId = 8, PictureName="proteintozu.png"},
                new Picture { Id=9, ProductId = 9, PictureName="mogoltarihi.png"},
                new Picture { Id=10, ProductId = 10, PictureName="bizanstarihi.png"}
                );
        }

    }
}
