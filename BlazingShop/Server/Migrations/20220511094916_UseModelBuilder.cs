using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    public partial class UseModelBuilder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "book", "Books", "books" },
                    { 2, "camera-slr", "Electronics", "electronics" },
                    { 3, "aperture", "Video Games", "vedio-games" },
                    { 4, "video", "Movie", "movie" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Href", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 5, 11, 18, 49, 16, 11, DateTimeKind.Local).AddTicks(9160), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "독일 지방의 설화로, 이를 그림 형제가 채집해 동화로 각색해서 1812년의 동화집에 수록했다.", "none", "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg", false, false, 19.99m, 9.99m, "라푼젤" },
                    { 2, 2, new DateTime(2022, 5, 11, 18, 49, 16, 11, DateTimeKind.Local).AddTicks(9177), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "iPhone 이래 가장 획기적인 iPhone", "none", "https://upload.wikimedia.org/wikipedia/commons/f/fa/IPhone_5.png", false, false, 199.99m, 68.19m, "아이폰5" },
                    { 3, 3, new DateTime(2022, 5, 11, 18, 49, 16, 11, DateTimeKind.Local).AddTicks(9179), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "닌텐도의 대표 비디오 게임인 마리오 시리즈의 핵심이 되는 본가 시리즈.", "none", "https://upload.wikimedia.org/wikipedia/commons/6/67/Dibujo_de_Mario.jpg", false, false, 53.91m, 14.24m, "슈퍼마리오" },
                    { 4, 4, new DateTime(2022, 5, 11, 18, 49, 16, 11, DateTimeKind.Local).AddTicks(9180), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "2019년 암스테르담에서 열린 콘서트", "https://www.youtube.com/watch?v=nJiVgPncupo", "https://upload.wikimedia.org/wikipedia/commons/1/1d/20190518_Blackpink_Amsterdam_concert_18.jpg", false, false, 53.91m, 14.24m, "블랙핑크 콘서트" },
                    { 11, 1, new DateTime(2022, 5, 11, 18, 49, 16, 11, DateTimeKind.Local).AddTicks(9176), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "라푼젤 1탄의 후속작으로 1탄에 이어 엄청난 호평을 받았다.", "none", "https://upload.wikimedia.org/wikipedia/commons/8/8c/Rapunzel-Paul-Hey.jpg", false, false, 29.99m, 25.99m, "라푼젤 2탄" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
