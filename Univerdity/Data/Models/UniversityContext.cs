using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Univerdity.Data.Models
{
    public class UniversityContext : DbContext
    {
        public UniversityContext()
        {

        }

        public UniversityContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Cource> Cources { get; set; }
        public virtual DbSet<Resource> Resources { get; set; }
        public virtual DbSet<Homework> Homeworks { get; set; }
        public virtual DbSet<StudentCource> StudentCources { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=University;Integrated Security=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCource>(entity =>
            {
                entity.HasKey(sc => new { sc.CourceId, sc.StudentId });
            });
        }
    }
}
