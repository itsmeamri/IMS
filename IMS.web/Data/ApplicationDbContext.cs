using IMS.web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.web.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> adbcontext)
            : base(adbcontext)
        {
        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Firstname)
                .HasMaxLength(255)
                .IsRequired();

            builder.Entity<ApplicationUser>()
                .Property(e => e.Middlename)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Lastname)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.StoreId)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.Address)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.UserRoleId)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.IsActive)
                .HasDefaultValue(true)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.ProfilePictureUrl)
                .HasMaxLength(255);

            builder.Entity<ApplicationUser>()
                .Property(e => e.CreatedDate)
                .IsRequired()
                .HasDefaultValueSql("GETDATE()")
                .HasMaxLength(255);

            builder.Entity<IdentityRole>()
                .ToTable("Roles")
                .Property(p => p.Id)
                .HasColumnName("RoleId");

        }

    }



}
