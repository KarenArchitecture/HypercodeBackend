using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hypercode.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class persian_desc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "ShortDescription",
                value: "Lorem Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio consequuntur accusamus ducimus eveniet aut eos labore natus, at maiores soluta alias, distinctio enim sapiente pariatur rerum dolorum, facilis dolore eligendi.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "ShortDescription",
                value: "Lorem Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio consequuntur accusamus ducimus eveniet aut eos labore natus, at maiores soluta alias, distinctio enim sapiente pariatur rerum dolorum, facilis dolore eligendi.");

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "ShortDescription",
                value: "Lorem Lorem ipsum dolor sit amet consectetur adipisicing elit. Odio consequuntur accusamus ducimus eveniet aut eos labore natus, at maiores soluta alias, distinctio enim sapiente pariatur rerum dolorum, facilis dolore eligendi.");
        }
    }
}
