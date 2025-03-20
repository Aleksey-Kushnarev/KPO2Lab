using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KPO2Lab.models;
using Microsoft.EntityFrameworkCore;

namespace KPO2Lab.utils
{

    public class AppDbContext : DbContext
    {
        public DbSet<ProjectEntity> Projects { get; set; }
        public DbSet<TaskEntity> Tasks { get; set; }

        public DbSet<UserEntity> User { get; set; }

        public DbSet<RegisteredUserEntity> RegisteredUser { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=kpo;Username=postgres;Password=postgres");
        }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskEntity>()
                .HasOne(t => t.Project)
                .WithMany(p => p.Tasks)
                .OnDelete(DeleteBehavior.Cascade); // Каскадное удаление задач при удалении проекта

            modelBuilder.Entity<UserEntity>()
                .HasOne(u => u.Task)
                .WithMany(t => t.Users)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
