using Microsoft.EntityFrameworkCore.Migrations;

namespace CorporX.Migrations
{
    public partial class ChangeTypeString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CategoryWorks_CategoryWorkId1",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CategoryWorkId1",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "CategoryWorkId1",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryWorkId",
                table: "Projects",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_CategoryWorks_CategoryWorkId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CategoryWorkId",
                table: "Projects");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryWorkId",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "CategoryWorkId1",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CategoryWorkId1",
                table: "Projects",
                column: "CategoryWorkId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_CategoryWorks_CategoryWorkId1",
                table: "Projects",
                column: "CategoryWorkId1",
                principalTable: "CategoryWorks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
