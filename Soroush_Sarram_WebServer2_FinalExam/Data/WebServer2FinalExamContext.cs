using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Soroush_Sarram_WebServer2_FinalExam.Models;

namespace Soroush_Sarram_WebServer2_FinalExam.Data
{
    public partial class WebServer2FinalExamContext : DbContext
    {
        public WebServer2FinalExamContext()
        {
        }

        public WebServer2FinalExamContext(DbContextOptions<WebServer2FinalExamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Models.Task> Tasks { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
                optionsBuilder.UseSqlServer("Data Source=SOROUSH\\SQLEXPRESS; Initial catalog=WebServer2FinalExam; Trusted_Connection=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
