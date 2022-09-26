using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "04d03fcd-70bf-44d5-81ea-0a9074dc7c21",
                    Name = Roles.ADMINISTRATOR,
                    NormalizedName = Roles.ADMINISTRATOR.ToUpper()
                },
                new IdentityRole
                {
                    Id = "03d03fcd-20bf-44d5-81ea-0a9074dc7c21",
                    Name = Roles.USER,
                    NormalizedName = Roles.USER.ToUpper()
                });
        }
    }
}