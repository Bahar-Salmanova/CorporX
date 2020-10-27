using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class CreateNewProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "MemberLinks",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icon",
                table: "MemberLinks");
        }
    }
}
