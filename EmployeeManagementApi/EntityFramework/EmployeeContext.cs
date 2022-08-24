using EmployeeManagementApi.EntityFramework.Interfaces;
using EmployeeManagementApi.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementApi.EntityFramework
{
    public class EmployeeContext: DbContext, IEmployeeContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        public DbSet<UserCredentials> UserCredentials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserCredentials>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnType("password");

                entity.Property(e => e.PasswordCreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PasswordUpdateDate)
                    .HasColumnType("date");
            });
        }
    }
}
