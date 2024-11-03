using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_MemberSocialMedia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AboutDescription",
                table: "Home",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "Id",
                keyValue: 1,
                column: "AboutDescription",
                value: null);

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, null, "Home" },
                    { 2, "profile-default.jpg", "عبدالله معمار" },
                    { 3, "profile-default.jpg", "محمد شهبازی" },
                    { 4, "profile-default.jpg", "روح‌الله معمار" }
                });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MemberId", "SocialURL" },
                values: new object[] { 2, "HyperCodeCompany.com" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MemberId", "SocialURL" },
                values: new object[] { 2, "HyperCodeCompany.com" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Icon", "MemberId", "SocialURL" },
                values: new object[] { "telegram.svg", 3, "HyperCodeCompany.com" });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Icon", "MemberId", "SocialURL" },
                values: new object[] { "instagram.svg", 3, "HyperCodeCompany.com" });

            migrationBuilder.InsertData(
                table: "SocialMedias",
                columns: new[] { "Id", "Icon", "MemberId", "SocialURL" },
                values: new object[,]
                {
                    { 5, "telegram.svg", 4, "HyperCodeCompany.com" },
                    { 6, "instagram.svg", 4, "HyperCodeCompany.com" },
                    { 7, "telegram.svg", 1, "HyperCodeCompany.com" },
                    { 8, "instagram.svg", 1, "HyperCodeCompany.com" },
                    { 9, "whatsapp.svg", 1, "HyperCodeCompany.com" },
                    { 10, "whatsapp.svg", 1, "HyperCodeCompany.com" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedias_MemberId",
                table: "SocialMedias",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropIndex(
                name: "IX_SocialMedias_MemberId",
                table: "SocialMedias");

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "SocialMedias");

            migrationBuilder.DropColumn(
                name: "AboutDescription",
                table: "Home");

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 1,
                column: "SocialURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 2,
                column: "SocialURL",
                value: null);

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Icon", "SocialURL" },
                values: new object[] { "twitter.svg", null });

            migrationBuilder.UpdateData(
                table: "SocialMedias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Icon", "SocialURL" },
                values: new object[] { "whatsapp.svg", null });
        }
    }
}
