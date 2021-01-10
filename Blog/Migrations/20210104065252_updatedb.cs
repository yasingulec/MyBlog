using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "SubComments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MainComments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "SubComments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MainComments");
        }
    }
}
