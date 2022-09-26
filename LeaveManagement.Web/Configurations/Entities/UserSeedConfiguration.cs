using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "04d03fcd-70bf-44d5-81ea-0a9074dc7c06",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "PassWordAdin"),
                    EmailConfirmed = true
                },
                new Employee
                {
                    Id = "4077189e-6786-4d03-b0e7-698efbfe4ed0",
                    Email = "admin@user.com",
                    NormalizedEmail = "ADMIN@USER.COM",
                    UserName = "admin@user.com",
                    NormalizedUserName = "ADMIN@USER.COM",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null, "PassWordAdin"),
                    EmailConfirmed = true
                });
        }
    }
}