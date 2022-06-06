﻿using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Exam> Exam { get; set; }
        public DbSet<ResultExam> ResultExam { get; set; }
        public DbSet<LearningResult> LearningResult { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Test> Test { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<TestSchedule> TestSchedule { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<ContentTest> ContentTest { get; set; }
    }
}
