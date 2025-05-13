using Microsoft.EntityFrameworkCore;
using ProjectVirtuqlisqtion.Models;

namespace ProjectVirtuqlisqtion.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSection> CourseSections { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<WhatYouWillLearn> Whats { get; set; }
        public DbSet<QuizOption> QuizOptions { get; set; }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
    }
}
