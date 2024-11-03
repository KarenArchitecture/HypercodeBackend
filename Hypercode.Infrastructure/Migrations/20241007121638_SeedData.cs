using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProjectCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Websites" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Description", "FinishedDate", "Name", "ProjectCategoryId", "URL" },
                values: new object[,]
                {
                    { 1, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dolorem voluptate beatae ratione quo error. Accusantium rerum impedit, obcaecati nam aliquam culpa nemo quidem voluptates, optio quam sint beatae architecto!", new DateTime(2022, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Datakadeh", 1, "https://datakadeh.com/" },
                    { 2, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dolorem voluptate beatae ratione quo error. Accusantium rerum impedit, obcaecati nam aliquam culpa nemo quidem voluptates, optio quam sint beatae architecto!", new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Davazdah", 1, "https://12application.ir/" },
                    { 3, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dolorem voluptate beatae ratione quo error. Accusantium rerum impedit, obcaecati nam aliquam culpa nemo quidem voluptates, optio quam sint beatae architecto!", new DateTime(2021, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arnika Stone", 1, "https://arnika-stone.com/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProjectCategories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
