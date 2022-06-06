using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class fistdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    IdDocument = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameDocument = table.Column<int>(type: "int", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.IdDocument);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                columns: table => new
                {
                    IdPermission = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.IdPermission);
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    IdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<int>(type: "int", nullable: false),
                    StartDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.IdSubject);
                });

            migrationBuilder.CreateTable(
                name: "TestSchedule",
                columns: table => new
                {
                    IdTestSchedule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSchedule", x => x.IdTestSchedule);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPermission = table.Column<int>(type: "int", nullable: false),
                    permissionIdPermission = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Permission_permissionIdPermission",
                        column: x => x.permissionIdPermission,
                        principalTable: "Permission",
                        principalColumn: "IdPermission",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    IdClass = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    subjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.IdClass);
                    table.ForeignKey(
                        name: "FK_Class_Subject_subjectIdSubject",
                        column: x => x.subjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    IdQuestion = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Form = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    subjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.IdQuestion);
                    table.ForeignKey(
                        name: "FK_Question_Subject_subjectIdSubject",
                        column: x => x.subjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedule",
                columns: table => new
                {
                    IdSchedule = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayLearn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    subjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedule", x => x.IdSchedule);
                    table.ForeignKey(
                        name: "FK_Schedule_Subject_subjectIdSubject",
                        column: x => x.subjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exam",
                columns: table => new
                {
                    IdExam = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameExam = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeTest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    SubjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TestScheduleIdTestSchedule = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exam", x => x.IdExam);
                    table.ForeignKey(
                        name: "FK_Exam_Subject_SubjectIdSubject",
                        column: x => x.SubjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exam_TestSchedule_TestScheduleIdTestSchedule",
                        column: x => x.TestScheduleIdTestSchedule,
                        principalTable: "TestSchedule",
                        principalColumn: "IdTestSchedule");
                });

            migrationBuilder.CreateTable(
                name: "LearningResult",
                columns: table => new
                {
                    IdLR = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreAvg = table.Column<float>(type: "real", nullable: false),
                    AttendancePoint = table.Column<float>(type: "real", nullable: false),
                    ScoreOralTest = table.Column<float>(type: "real", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    Score15Minunes = table.Column<float>(type: "real", nullable: false),
                    ScoreCoefficient2 = table.Column<float>(type: "real", nullable: false),
                    ScoreCoefficient3 = table.Column<float>(type: "real", nullable: false),
                    SumScoreAvg = table.Column<float>(type: "real", nullable: false),
                    ResultOfEvaluation = table.Column<bool>(type: "bit", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    subjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    userIdUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearningResult", x => x.IdLR);
                    table.ForeignKey(
                        name: "FK_LearningResult_Subject_subjectIdSubject",
                        column: x => x.subjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LearningResult_Users_userIdUser",
                        column: x => x.userIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    IdTest = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    SubjectIdSubject = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    userIdUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.IdTest);
                    table.ForeignKey(
                        name: "FK_Test_Subject_SubjectIdSubject",
                        column: x => x.SubjectIdSubject,
                        principalTable: "Subject",
                        principalColumn: "IdSubject");
                    table.ForeignKey(
                        name: "FK_Test_Users_userIdUser",
                        column: x => x.userIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    IdAnswer = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightWrong = table.Column<bool>(type: "bit", nullable: false),
                    IdExam = table.Column<int>(type: "int", nullable: false),
                    examIdExam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.IdAnswer);
                    table.ForeignKey(
                        name: "FK_Answer_Exam_examIdExam",
                        column: x => x.examIdExam,
                        principalTable: "Exam",
                        principalColumn: "IdExam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultExam",
                columns: table => new
                {
                    IdResult = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    DayExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdExam = table.Column<int>(type: "int", nullable: false),
                    examIdExam = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    userIdUser = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultExam", x => x.IdResult);
                    table.ForeignKey(
                        name: "FK_ResultExam_Exam_examIdExam",
                        column: x => x.examIdExam,
                        principalTable: "Exam",
                        principalColumn: "IdExam",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultExam_Users_userIdUser",
                        column: x => x.userIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentTest",
                columns: table => new
                {
                    IdContent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false),
                    IdTest = table.Column<int>(type: "int", nullable: false),
                    testIdTest = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTest", x => x.IdContent);
                    table.ForeignKey(
                        name: "FK_ContentTest_Test_testIdTest",
                        column: x => x.testIdTest,
                        principalTable: "Test",
                        principalColumn: "IdTest",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_examIdExam",
                table: "Answer",
                column: "examIdExam");

            migrationBuilder.CreateIndex(
                name: "IX_Class_subjectIdSubject",
                table: "Class",
                column: "subjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTest_testIdTest",
                table: "ContentTest",
                column: "testIdTest");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_SubjectIdSubject",
                table: "Exam",
                column: "SubjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Exam_TestScheduleIdTestSchedule",
                table: "Exam",
                column: "TestScheduleIdTestSchedule");

            migrationBuilder.CreateIndex(
                name: "IX_LearningResult_subjectIdSubject",
                table: "LearningResult",
                column: "subjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_LearningResult_userIdUser",
                table: "LearningResult",
                column: "userIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Question_subjectIdSubject",
                table: "Question",
                column: "subjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_ResultExam_examIdExam",
                table: "ResultExam",
                column: "examIdExam");

            migrationBuilder.CreateIndex(
                name: "IX_ResultExam_userIdUser",
                table: "ResultExam",
                column: "userIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Schedule_subjectIdSubject",
                table: "Schedule",
                column: "subjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Test_SubjectIdSubject",
                table: "Test",
                column: "SubjectIdSubject");

            migrationBuilder.CreateIndex(
                name: "IX_Test_userIdUser",
                table: "Test",
                column: "userIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Users_permissionIdPermission",
                table: "Users",
                column: "permissionIdPermission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "ContentTest");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "LearningResult");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "ResultExam");

            migrationBuilder.DropTable(
                name: "Schedule");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Exam");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.DropTable(
                name: "TestSchedule");

            migrationBuilder.DropTable(
                name: "Permission");
        }
    }
}
