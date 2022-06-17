using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    //class for seeding default user 
    public class UserSeedConfiguratiion : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
            new Employee
            {
                Id = "cac43a6e-f7af-4238-bccf-1add431cc487",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM", 
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                UserName = "admin@localhost.com",
                FirstName = "System",
                LastName ="Admin",
                PasswordHash =hasher.HashPassword(null, "Password1"),
                EmailConfirmed = true
            },
            new Employee
            {
                Id = "bab43a6e-f7af-4333-bccf-1add431cc487",
                Email = "user@localhost.com",
                NormalizedEmail = "USER@LOCALHOST.COM",
                FirstName = "System",
                NormalizedUserName = "USER@LOCALHOST.COM",
                UserName = "user@localhost.com",
                LastName = "User",
                PasswordHash = hasher.HashPassword(null, "Password1"),
                EmailConfirmed=true
            });
        }
    }
}