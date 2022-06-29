using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoWebAppAsp.Net.Migrations
{
    public partial class AddedUserEmailInTableDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "SchoolTodos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "HomeTodos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "SchoolTodos");

            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "HomeTodos");
        }
    }
}
