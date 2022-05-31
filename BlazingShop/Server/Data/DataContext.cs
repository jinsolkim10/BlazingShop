using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }
        public DbSet<Stats> Stats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.EditionId });

            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = 1, Name = "Books", Url = "books", Icon = "book", },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "vedio-games", Icon = "aperture" },
                new Category { Id = 4, Name = "Movie", Url = "movie", Icon = "video" }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "라푼젤",
                    Description = "독일 지방의 설화로, 이를 그림 형제가 채집해 동화로 각색해서 1812년의 동화집에 수록했다.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
                    Href = "none",
                    DateCreated = new DateTime(2022, 1, 1)
                },
                   new Product
                   {
                       Id = 11,
                       CategoryId = 1,
                       Title = "라푼젤 2탄",
                       Description = "라푼젤 1탄의 후속작으로 1탄에 이어 엄청난 호평을 받았다.",
                       Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
                       Href = "none",
                       DateCreated = new DateTime(2022, 1, 1)
                   },
                    new Product
                    {
                        Id = 2,
                        CategoryId = 2,
                        Title = "아이폰5",
                        Description = "iPhone 이래 가장 획기적인 iPhone",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/f/fa/IPhone_5.png",
                        Href = "none",
                        DateCreated = new DateTime(2022, 1, 1)
                    },
                     new Product
                     {
                         Id = 3,
                         CategoryId = 3,
                         Title = "슈퍼마리오",
                         Description = "닌텐도의 대표 비디오 게임인 마리오 시리즈의 핵심이 되는 본가 시리즈.",
                         Image = "https://upload.wikimedia.org/wikipedia/commons/6/67/Dibujo_de_Mario.jpg",
                         Href = "none",
                         DateCreated = new DateTime(2022, 1, 1)
                     },
                     new Product
                     {
                         Id = 4,
                         CategoryId = 4,
                         Title = "블랙핑크 콘서트",
                         Description = "2019년 암스테르담에서 열린 콘서트",
                         Image = "https://upload.wikimedia.org/wikipedia/commons/1/1d/20190518_Blackpink_Amsterdam_concert_18.jpg",
                         Href = "https://www.youtube.com/watch?v=nJiVgPncupo",
                         DateCreated = new DateTime(2022, 1, 1)
                     }
                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Default" },
                new Edition { Id = 2, Name = "E-Book" },
                new Edition { Id = 3, Name = "Audiobook" },
                new Edition { Id = 4, Name = "PC" },
                new Edition { Id = 5, Name = "PlayStation" },
                new Edition { Id = 6, Name = "Xbox" },
                     new Edition { Id = 7, Name = "CD" }
                );
            modelBuilder.Entity<ProductVariant>()
                .HasData(
                    new ProductVariant
                    {
                        ProductId = 1,
                        EditionId = 2,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        EditionId = 2,
                        Price = 5.99m,
                        OriginalPrice = 129.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        EditionId = 3,
                        Price = 6.99m,
                        OriginalPrice = 29.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        EditionId = 4,
                        Price = 8.99m,
                        OriginalPrice = 59.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        EditionId = 5,
                        Price = 7.99m,
                        OriginalPrice = 69.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        EditionId = 6,
                        Price = 19.99m,
                        OriginalPrice = 79.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        EditionId = 7,
                        Price = 13.99m,
                        OriginalPrice = 89.99m
                    }
                );

        }








    }
}
