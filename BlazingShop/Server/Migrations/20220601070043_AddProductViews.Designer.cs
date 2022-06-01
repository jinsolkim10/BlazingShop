﻿// <auto-generated />
using System;
using BlazingShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220601070043_AddProductViews")]
    partial class AddProductViews
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazingShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "vedio-games"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "video",
                            Name = "Movie",
                            Url = "movie"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Edition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Editions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Default"
                        },
                        new
                        {
                            Id = 2,
                            Name = "E-Book"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Audiobook"
                        },
                        new
                        {
                            Id = 4,
                            Name = "PC"
                        },
                        new
                        {
                            Id = 5,
                            Name = "PlayStation"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Xbox"
                        },
                        new
                        {
                            Id = 7,
                            Name = "CD"
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Href")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "독일 지방의 설화로, 이를 그림 형제가 채집해 동화로 각색해서 1812년의 동화집에 수록했다.",
                            Href = "none",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "라푼젤",
                            Views = 0
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "라푼젤 1탄의 후속작으로 1탄에 이어 엄청난 호평을 받았다.",
                            Href = "none",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "라푼젤 2탄",
                            Views = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "iPhone 이래 가장 획기적인 iPhone",
                            Href = "none",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/f/fa/IPhone_5.png",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "아이폰5",
                            Views = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "닌텐도의 대표 비디오 게임인 마리오 시리즈의 핵심이 되는 본가 시리즈.",
                            Href = "none",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/6/67/Dibujo_de_Mario.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "슈퍼마리오",
                            Views = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            DateCreated = new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "2019년 암스테르담에서 열린 콘서트",
                            Href = "https://www.youtube.com/watch?v=nJiVgPncupo",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/1/1d/20190518_Blackpink_Amsterdam_concert_18.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Title = "블랙핑크 콘서트",
                            Views = 0
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("EditionId")
                        .HasColumnType("int");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "EditionId");

                    b.HasIndex("EditionId");

                    b.ToTable("ProductVariant");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            EditionId = 2,
                            OriginalPrice = 19.99m,
                            Price = 9.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 2,
                            OriginalPrice = 129.99m,
                            Price = 5.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 3,
                            OriginalPrice = 29.99m,
                            Price = 6.99m
                        },
                        new
                        {
                            ProductId = 4,
                            EditionId = 4,
                            OriginalPrice = 59.99m,
                            Price = 8.99m
                        },
                        new
                        {
                            ProductId = 1,
                            EditionId = 5,
                            OriginalPrice = 69.99m,
                            Price = 7.99m
                        },
                        new
                        {
                            ProductId = 2,
                            EditionId = 6,
                            OriginalPrice = 79.99m,
                            Price = 19.99m
                        },
                        new
                        {
                            ProductId = 3,
                            EditionId = 7,
                            OriginalPrice = 89.99m,
                            Price = 13.99m
                        });
                });

            modelBuilder.Entity("BlazingShop.Shared.Stats", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("LastVisit")
                        .HasColumnType("datetime2");

                    b.Property<int>("Visits")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.HasOne("BlazingShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazingShop.Shared.ProductVariant", b =>
                {
                    b.HasOne("BlazingShop.Shared.Edition", "Edition")
                        .WithMany()
                        .HasForeignKey("EditionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazingShop.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Edition");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BlazingShop.Shared.Product", b =>
                {
                    b.Navigation("Variants");
                });
#pragma warning restore 612, 618
        }
    }
}
