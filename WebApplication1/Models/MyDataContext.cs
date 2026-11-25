using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class MyDataContext : DbContext
    {
        public MyDataContext()
        {
        }

        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Professors> Professors { get; set; }
        public virtual DbSet<Registation> Registation { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<Students> Students { get; set; }
        public virtual DbSet<Syllabus> Syllabus { get; set; }
        public virtual DbSet<Topics> Topics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(" Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"S:\\כתה יב\\מדעי המחשב\\אוריאן\\GitHub\\dataBaseCourse\\DataBaseCourse.mdf\";Integrated Security=True;Connect Timeout=30");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CourseCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CourseName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfessorsId).HasColumnName("ProfessorsID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TopicsId).HasColumnName("TopicsID");

                //entity.HasOne(d => d.Professors)
                //    .WithMany(p => p.Course)
                //    .HasForeignKey(d => d.ProfessorsId)
                //    .HasConstraintName("FK_Course_ToTable_1");

                //entity.HasOne(d => d.Topics)
                //    .WithMany(p => p.Course)
                //    .HasForeignKey(d => d.TopicsId)
                //    .HasConstraintName("FK_Course_ToTable");
            });

            modelBuilder.Entity<Professors>(entity =>
            {
                entity.HasKey(e => e.ProfessorId)
                    .HasName("PK__Professo__900359693EA6B98E");

                entity.Property(e => e.ProfessorId).HasColumnName("ProfessorID");

                entity.Property(e => e.Department).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<Registation>(entity =>
            {
                entity.HasKey(e => e.RegId)
                    .HasName("PK__Registat__2C682118271F6551");

                entity.Property(e => e.RegId).HasColumnName("RegID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.RegDate).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StatusReg).HasMaxLength(50);

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                //entity.HasOne(d => d.Course)
                //    .WithMany(p => p.Registation)
                //    .HasForeignKey(d => d.CourseId)
                //    .HasConstraintName("FK_Registation_ToTable_1");

                //entity.HasOne(d => d.Student)
                //    .WithMany(p => p.Registation)
                //    .HasForeignKey(d => d.StudentId)
                //    .HasConstraintName("FK_Registation_ToTable");
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.Property(e => e.Classroom).HasMaxLength(50);

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.Day).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                //entity.HasOne(d => d.Course)
                //    .WithMany(p => p.Schedule)
                //    .HasForeignKey(d => d.CourseId)
                //    .HasConstraintName("FK_Schedule_ToTable");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.HasKey(e => e.CodeStudent)
                    .HasName("PK__Students__8BF8E5BBC4DB5D73");

                entity.Property(e => e.CodeStudent).HasColumnName("codeStudent");

                entity.Property(e => e.Degree).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");
            });

            modelBuilder.Entity<Syllabus>(entity =>
            {
                entity.Property(e => e.SyllabusId).HasColumnName("SyllabusID");

                entity.Property(e => e.CourseId).HasColumnName(" CourseID");

                entity.Property(e => e.LessonTopic).HasMaxLength(50);

                //entity.HasOne(d => d.Course)
                //    .WithMany(p => p.Syllabus)
                //    .HasForeignKey(d => d.CourseId)
                //    .HasConstraintName("FK_Syllabus_ToTable");
            });

            modelBuilder.Entity<Topics>(entity =>
            {
                entity.HasKey(e => e.TopicId)
                    .HasName("PK__Topics__022E0F7D4AE5220E");

                entity.Property(e => e.TopicId).HasColumnName("TopicID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TopicName).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
