using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities;

public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
             new IdentityUserRole<string>
             {
                 RoleId = "5f43a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                 UserId = "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b"
             },
             new IdentityUserRole<string>
             {
                 RoleId = "5f43a5f7-5d55-40a2-12ac-2c8b0c8b0c8b",
                 UserId = "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b"
             }
         );
    }
}