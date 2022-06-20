using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Answer_TypeExamId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Class_ClassId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_ResultExam_ScheduleId1",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Subject_SubjectId",
                table: "Schedule");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_ClassId",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_ScheduleId1",
                table: "Schedule");

            migrationBuilder.DropIndex(
                name: "IX_Schedule_SubjectId",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestSchedule",
                table: "TestSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "DetailId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ScheduleId1",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "ResultExam");

            migrationBuilder.DropColumn(
                name: "End",
                table: "ResultExam");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "ResultExam");

            migrationBuilder.RenameTable(
                name: "TestSchedule",
                newName: "Semester");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "TypeExam");

            migrationBuilder.RenameColumn(
                name: "SubjectId",
                table: "Schedule",
                newName: "DayLearn");

            migrationBuilder.RenameColumn(
                name: "ScheduleName",
                table: "ResultExam",
                newName: "Score");

            migrationBuilder.RenameColumn(
                name: "DayLearn",
                table: "ResultExam",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "ScheduleId",
                table: "Schedule",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "End",
                table: "Schedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<float>(
                name: "ScheduleName",
                table: "Schedule",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Start",
                table: "Schedule",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ResultExamId",
                table: "ResultExam",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "ExamDate",
                table: "ResultExam",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "ResultExam",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam",
                column: "ResultExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Semester",
                table: "Semester",
                column: "SemesterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeExam",
                table: "TypeExam",
                column: "TypeExamId");

            migrationBuilder.CreateTable(
                name: "DetailClass",
                columns: table => new
                {
                    DetailClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    SemesterId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailClass", x => x.DetailClassId);
                    table.ForeignKey(
                        name: "FK_DetailClass_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailClass_Semester_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semester",
                        principalColumn: "SemesterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailClass_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailSubject",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId = table.Column<int>(type: "int", nullable: false),
                    ScheduleId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailSubject", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_DetailSubject_Class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailSubject_Schedule_ScheduleId1",
                        column: x => x.ScheduleId1,
                        principalTable: "Schedule",
                        principalColumn: "ScheduleId");
                    table.ForeignKey(
                        name: "FK_DetailSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResultExam_ExamId",
                table: "ResultExam",
                column: "ExamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResultExam_UserId",
                table: "ResultExam",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailClass_ClassId",
                table: "DetailClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailClass_SemesterId",
                table: "DetailClass",
                column: "SemesterId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailClass_UserId",
                table: "DetailClass",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSubject_ClassId",
                table: "DetailSubject",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSubject_ScheduleId1",
                table: "DetailSubject",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_DetailSubject_SubjectId",
                table: "DetailSubject",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_TypeExam_TypeExamId",
                table: "Exam",
                column: "TypeExamId",
                principalTable: "TypeExam",
                principalColumn: "TypeExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultExam_Exam_ExamId",
                table: "ResultExam",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResultExam_Users_UserId",
                table: "ResultExam",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exam_TypeExam_TypeExamId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultExam_Exam_ExamId",
                table: "ResultExam");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultExam_Users_UserId",
                table: "ResultExam");

            migrationBuilder.DropTable(
                name: "DetailClass");

            migrationBuilder.DropTable(
                name: "DetailSubject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam");

            migrationBuilder.DropIndex(
                name: "IX_ResultExam_ExamId",
                table: "ResultExam");

            migrationBuilder.DropIndex(
                name: "IX_ResultExam_UserId",
                table: "ResultExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeExam",
                table: "TypeExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Semester",
                table: "Semester");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ScheduleName",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "Schedule");

            migrationBuilder.DropColumn(
                name: "ResultExamId",
                table: "ResultExam");

            migrationBuilder.DropColumn(
                name: "ExamDate",
                table: "ResultExam");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "ResultExam");

            migrationBuilder.RenameTable(
                name: "TypeExam",
                newName: "Answer");

            migrationBuilder.RenameTable(
                name: "Semester",
                newName: "TestSchedule");

            migrationBuilder.RenameColumn(
                name: "DayLearn",
                table: "Schedule",
                newName: "SubjectId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ResultExam",
                newName: "DayLearn");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "ResultExam",
                newName: "ScheduleName");

            migrationBuilder.AlterColumn<int>(
                name: "ScheduleId",
                table: "Schedule",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "DetailId",
                table: "Schedule",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Schedule",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ScheduleId1",
                table: "Schedule",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ScheduleId",
                table: "ResultExam",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "End",
                table: "ResultExam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Start",
                table: "ResultExam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "DetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam",
                column: "ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "TypeExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestSchedule",
                table: "TestSchedule",
                column: "SemesterId");

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    ResultExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.ResultExamId);
                    table.ForeignKey(
                        name: "FK_Test_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Test_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ClassId",
                table: "Schedule",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_ScheduleId1",
                table: "Schedule",
                column: "ScheduleId1");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_SubjectId",
                table: "Schedule",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Test_ExamId",
                table: "Test",
                column: "ExamId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Test_UserId",
                table: "Test",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Answer_TypeExamId",
                table: "Exam",
                column: "TypeExamId",
                principalTable: "Answer",
                principalColumn: "TypeExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Class_ClassId",
                table: "Schedule",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "ClassId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_ResultExam_ScheduleId1",
                table: "Schedule",
                column: "ScheduleId1",
                principalTable: "ResultExam",
                principalColumn: "ScheduleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Subject_SubjectId",
                table: "Schedule",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
