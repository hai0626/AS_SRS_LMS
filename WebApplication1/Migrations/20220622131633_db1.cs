using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_LearningResult_LearningResultLRId",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_LearningResultLRId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "LearningResultLRId",
                table: "Class");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LearningResultLRId",
                table: "Class",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Class_LearningResultLRId",
                table: "Class",
                column: "LearningResultLRId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_LearningResult_LearningResultLRId",
                table: "Class",
                column: "LearningResultLRId",
                principalTable: "LearningResult",
                principalColumn: "LRId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
