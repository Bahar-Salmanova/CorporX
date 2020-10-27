using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class DeleteCategoryWork : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CategoryWorks_CategoryWorkId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "CategoryWorks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CategoryWorkId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CategoryWorkId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "Category",
                table: "Projects",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "CategoryWorkId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CategoryWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryWorks", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryWorkId",
                table: "Projects",
                column: "CategoryWorkId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CategoryWorks_CategoryWorkId",
                table: "Projects",
                column: "CategoryWorkId",
                principalTable: "CategoryWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
