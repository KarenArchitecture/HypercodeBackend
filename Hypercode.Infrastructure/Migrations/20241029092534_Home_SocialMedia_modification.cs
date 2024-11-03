using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Home_SocialMedia_modification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "URL",
                table: "SocialMedias",
                newName: "SocialURL");

            migrationBuilder.RenameColumn(
                name: "Slogan",
                table: "Home",
                newName: "HeaderSlogan");

            migrationBuilder.RenameColumn(
                name: "PreSlogan",
                table: "Home",
                newName: "HeaderPreSlogan");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactLogo",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContactSlogan",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebsiteURL",
                table: "Home",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Home",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "ContactLogo", "ContactSlogan", "Email", "PhoneNumber", "WebsiteURL" },
                values: new object[] { " تهران - امیرآباد - خیابان سیندخت - کوچه فتاح الجنان - پلاک 3", "logo.jpg", "باهم برای هم", "hypercode@gmail.com", "+9899******67", "HyperCodeCompany.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "ContactLogo",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "ContactSlogan",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Home");

            migrationBuilder.DropColumn(
                name: "WebsiteURL",
                table: "Home");

            migrationBuilder.RenameColumn(
                name: "SocialURL",
                table: "SocialMedias",
                newName: "URL");

            migrationBuilder.RenameColumn(
                name: "HeaderSlogan",
                table: "Home",
                newName: "Slogan");

            migrationBuilder.RenameColumn(
                name: "HeaderPreSlogan",
                table: "Home",
                newName: "PreSlogan");
        }
    }
}
