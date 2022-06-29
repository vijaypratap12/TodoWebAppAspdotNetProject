using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoWebAppAsp.Net.Migrations
{
    public partial class UpdatedFieldInTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConfirmPassword",
                table: "SignupDetailTodos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmPassword",
                table: "SignupDetailTodos");
        }
    }
}
