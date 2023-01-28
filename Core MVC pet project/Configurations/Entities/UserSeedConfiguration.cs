using Core_MVC_pet_project.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Core_MVC_pet_project.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(new Employee
            {
                Id = "5f55a8f9-5d86-40a2-81ac-5c5b0c8b0c8b",
                Email = "test@gmail.com",
                NormalizedEmail = "TEST@GMAIL.COM",
                UserName = "test@gmail.com",
                NormalizedUserName = "TEST@GMAIL.COM",
                FirstName = "System",
                LastName = "Administrator",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
            },
                new Employee
            {
                Id = "5f55a8f9-5d86-40a2-81ac-2c8b0c8b0c8b",
                Email = "user@gmail.com",
                NormalizedEmail = "USER@GMAIL.COM",
                UserName = "user@gmail.com",
                NormalizedUserName = "USER@GMAIL.COM",
                FirstName = "Ralf",
                LastName = "Kurz",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true,
            }
            
            );
        }
    }
}