using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class db5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Class_ClassId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ClassId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "VerificationToken",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VerifiedAt",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Exam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Exam",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "ContentTest",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Exam_UserId1",
                table: "Exam",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTest_ExamId",
                table: "ContentTest",
                column: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentTest_Exam_ExamId",
                table: "ContentTest",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "ExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Users_UserId1",
                table: "Exam",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContentTest_Exam_ExamId",
                table: "ContentTest");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Users_UserId1",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_UserId1",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_ContentTest_ExamId",
                table: "ContentTest");

            migrationBuilder.DropColumn(
                name: "VerificationToken",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "VerifiedAt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Exam");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "ContentTest");

            migrationBuilder.AddColumn<string>(
                name: "ClassId",
                table: "Users",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClassId",
                table: "Users",
                column: "ClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Class_ClassId",
                table: "Users",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId");
        }
    }
}
