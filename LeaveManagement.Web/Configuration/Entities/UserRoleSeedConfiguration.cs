using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configuration.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(new IdentityUserRole<string>
            {
                RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                UserId = "cac43a6e-f7af-4238-bccf-1add431cc487"

            },
            new IdentityUserRole<string>
            {
                RoleId = "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                UserId= "bab43a6e-f7af-4333-bccf-1add431cc487"
            });
        }
    }
}