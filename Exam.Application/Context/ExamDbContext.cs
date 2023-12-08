using Exam.Domain.Etities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Application.Context
{
    public class ExamDbContext : DbContext
    {
        public ExamDbContext(DbContextOptions<ExamDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Lesson>()
                .HasKey(x => x.LessonCode);

            modelBuilder.Entity<Student>()
                .HasKey(x => x.StudentNumber);

            modelBuilder.Entity<ClassExam>()
                .Property(x=>x.Result).HasColumnType("decimal(5,2)");
                 
        }

        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ClassExam> ClassExam { get; set; }
    }
}
