using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add_MemberSocialMedia2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "SocialMedias",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias");

            migrationBuilder.AlterColumn<int>(
                name: "MemberId",
                table: "SocialMedias",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_SocialMedias_Members_MemberId",
                table: "SocialMedias",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
