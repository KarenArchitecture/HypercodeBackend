using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addHomeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreSlogan = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Slogan = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    BannerImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "Id", "BannerImage", "PreSlogan", "Slogan" },
                values: new object[] { 1, "HC-LOGO-1-01.svg", "دنبال پیشرفت کسب و کارت هستی؟", "بهترین خدمات برنامه نویسی، طراحی و دیزاین و سئو در ایران" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home");
        }
    }
}
