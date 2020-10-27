using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class ChangeProjectType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Category",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Category",
                table: "Projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
