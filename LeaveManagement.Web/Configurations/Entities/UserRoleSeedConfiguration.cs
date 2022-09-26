using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "04d03fcd-70bf-44d5-81ea-0a9074dc7c21",
                    UserId = "04d03fcd-70bf-44d5-81ea-0a9074dc7c06"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "03d03fcd-20bf-44d5-81ea-0a9074dc7c21",
                    UserId = "4077189e-6786-4d03-b0e7-698efbfe4ed0"
                });
        }
    }
}