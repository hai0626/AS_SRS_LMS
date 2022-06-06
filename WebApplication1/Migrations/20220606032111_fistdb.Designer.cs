﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Model;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220606032111_fistdb")]
    partial class fistdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApplication1.Model.Answer", b =>
                {
                    b.Property<string>("IdAnswer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdExam")
                        .HasColumnType("int");

                    b.Property<bool>("RightWrong")
                        .HasColumnType("bit");

                    b.Property<int>("examIdExam")
                        .HasColumnType("int");

                    b.HasKey("IdAnswer");

                    b.HasIndex("examIdExam");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("WebApplication1.Model.Class", b =>
                {
                    b.Property<string>("IdClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("subjectIdSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdClass");

                    b.HasIndex("subjectIdSubject");

                    b.ToTable("Class");
                });

            modelBuilder.Entity("WebApplication1.Model.ContentTest", b =>
                {
                    b.Property<int>("IdContent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdContent"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdTest")
                        .HasColumnType("int");

                    b.Property<int>("Result")
                        .HasColumnType("int");

                    b.Property<int>("testIdTest")
                        .HasColumnType("int");

                    b.HasKey("IdContent");

                    b.HasIndex("testIdTest");

                    b.ToTable("ContentTest");
                });

            modelBuilder.Entity("WebApplication1.Model.Document", b =>
                {
                    b.Property<int>("IdDocument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDocument"), 1L, 1);

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NameDocument")
                        .HasColumnType("int");

                    b.HasKey("IdDocument");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("WebApplication1.Model.Exam", b =>
                {
                    b.Property<int>("IdExam")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdExam"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExamCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("NameExam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectIdSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("TestScheduleIdTestSchedule")
                        .HasColumnType("int");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("TypeTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdExam");

                    b.HasIndex("SubjectIdSubject");

                    b.HasIndex("TestScheduleIdTestSchedule");

                    b.ToTable("Exam");
                });

            modelBuilder.Entity("WebApplication1.Model.LearningResult", b =>
                {
                    b.Property<string>("IdLR")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("AttendancePoint")
                        .HasColumnType("real");

                    b.Property<DateTime>("DateUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<bool>("ResultOfEvaluation")
                        .HasColumnType("bit");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<float>("Score15Minunes")
                        .HasColumnType("real");

                    b.Property<float>("ScoreAvg")
                        .HasColumnType("real");

                    b.Property<float>("ScoreCoefficient2")
                        .HasColumnType("real");

                    b.Property<float>("ScoreCoefficient3")
                        .HasColumnType("real");

                    b.Property<float>("ScoreOralTest")
                        .HasColumnType("real");

                    b.Property<float>("SumScoreAvg")
                        .HasColumnType("real");

                    b.Property<string>("subjectIdSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("userIdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdLR");

                    b.HasIndex("subjectIdSubject");

                    b.HasIndex("userIdUser");

                    b.ToTable("LearningResult");
                });

            modelBuilder.Entity("WebApplication1.Model.Permission", b =>
                {
                    b.Property<int>("IdPermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPermission"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPermission");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("WebApplication1.Model.Question", b =>
                {
                    b.Property<string>("IdQuestion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Form")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<string>("subjectIdSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdQuestion");

                    b.HasIndex("subjectIdSubject");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("WebApplication1.Model.ResultExam", b =>
                {
                    b.Property<string>("IdResult")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DayExam")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdExam")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("examIdExam")
                        .HasColumnType("int");

                    b.Property<string>("userIdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdResult");

                    b.HasIndex("examIdExam");

                    b.HasIndex("userIdUser");

                    b.ToTable("ResultExam");
                });

            modelBuilder.Entity("WebApplication1.Model.Schedule", b =>
                {
                    b.Property<int>("IdSchedule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSchedule"), 1L, 1);

                    b.Property<DateTime>("DayLearn")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("subjectIdSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdSchedule");

                    b.HasIndex("subjectIdSubject");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("WebApplication1.Model.Subject", b =>
                {
                    b.Property<string>("IdSubject")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("EndDay")
                        .HasColumnType("datetime2");

                    b.Property<int>("Period")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSubject");

                    b.ToTable("Subject");
                });

            modelBuilder.Entity("WebApplication1.Model.Test", b =>
                {
                    b.Property<int>("IdTest")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTest"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSubject")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("NameTest")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("SubjectIdSubject")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Time")
                        .HasColumnType("int");

                    b.Property<string>("userIdUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdTest");

                    b.HasIndex("SubjectIdSubject");

                    b.HasIndex("userIdUser");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("WebApplication1.Model.TestSchedule", b =>
                {
                    b.Property<int>("IdTestSchedule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTestSchedule"), 1L, 1);

                    b.Property<DateTime>("DayExam")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("IdTestSchedule");

                    b.ToTable("TestSchedule");
                });

            modelBuilder.Entity("WebApplication1.Model.User", b =>
                {
                    b.Property<string>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<int>("IdPermission")
                        .HasColumnType("int");

                    b.Property<string>("Images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("permissionIdPermission")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.HasIndex("permissionIdPermission");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("WebApplication1.Model.Answer", b =>
                {
                    b.HasOne("WebApplication1.Model.Exam", "exam")
                        .WithMany()
                        .HasForeignKey("examIdExam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exam");
                });

            modelBuilder.Entity("WebApplication1.Model.Class", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectIdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");
                });

            modelBuilder.Entity("WebApplication1.Model.ContentTest", b =>
                {
                    b.HasOne("WebApplication1.Model.Test", "test")
                        .WithMany()
                        .HasForeignKey("testIdTest")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("test");
                });

            modelBuilder.Entity("WebApplication1.Model.Exam", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectIdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Model.TestSchedule", null)
                        .WithMany("Exam")
                        .HasForeignKey("TestScheduleIdTestSchedule");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("WebApplication1.Model.LearningResult", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectIdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebApplication1.Model.Question", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectIdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");
                });

            modelBuilder.Entity("WebApplication1.Model.ResultExam", b =>
                {
                    b.HasOne("WebApplication1.Model.Exam", "exam")
                        .WithMany()
                        .HasForeignKey("examIdExam")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication1.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("exam");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebApplication1.Model.Schedule", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "subject")
                        .WithMany()
                        .HasForeignKey("subjectIdSubject")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("subject");
                });

            modelBuilder.Entity("WebApplication1.Model.Test", b =>
                {
                    b.HasOne("WebApplication1.Model.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectIdSubject");

                    b.HasOne("WebApplication1.Model.User", "user")
                        .WithMany()
                        .HasForeignKey("userIdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("user");
                });

            modelBuilder.Entity("WebApplication1.Model.User", b =>
                {
                    b.HasOne("WebApplication1.Model.Permission", "permission")
                        .WithMany()
                        .HasForeignKey("permissionIdPermission")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("permission");
                });

            modelBuilder.Entity("WebApplication1.Model.TestSchedule", b =>
                {
                    b.Navigation("Exam");
                });
#pragma warning restore 612, 618
        }
    }
}
