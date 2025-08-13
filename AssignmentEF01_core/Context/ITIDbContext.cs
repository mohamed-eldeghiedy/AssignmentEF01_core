using System;
using Microsoft.EntityFrameworkCore;
using AssignmentEF01_core.Models;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AssignmentEF01_core.Context
{
    internal class ITIDbContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
           
            optionsBuilder.UseSqlServer("Server=.;Database= ITIDb ;Trusted_Connection=True; TrustServerCertificate = true;");
         }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Stud_Course>(builder => 
            {
                builder.ToTable("Stud_Course")               
                .HasKey(x => new { x.Stu_ID, x.Course_ID });

                
                builder.Property(x => x.Stu_ID)
                      .HasColumnName("Stu_ID")
                      .IsRequired();

                builder.Property(x => x.Course_ID)
                      .HasColumnName("Course_ID")
                      .IsRequired();

                builder.Property(x => x.Grade)
                      .HasColumnName("Grade")
                      .IsRequired();


            });

            modelBuilder.Entity<CourseInstructor>(builder => 
            {
                builder.ToTable("CourseInstructor")
                .HasKey(x => new { x.Ins_ID, x.Course_ID });
                builder.Property(x => x.Ins_ID)
                      .HasColumnName("Ins_ID")
                      .IsRequired();
                builder.Property(x => x.Course_ID)
                      .HasColumnName("Course_ID")
                      .IsRequired();
                builder.Property(x => x.Evaluation)
                      .HasColumnName("Evaluation")
                      .IsRequired();
            });

        }
    }
}
