using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace University.Migrations.EntityConfigurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<ApplicationUserEntity>
    {
        private readonly PasswordHasher<ApplicationUserEntity> hasher;
        public UsersConfiguration()
        {
            hasher = new PasswordHasher<ApplicationUserEntity>();
        }
        public void Configure(EntityTypeBuilder<ApplicationUserEntity> builder)
        {
            builder.HasData(
            new ApplicationUserEntity
            {
                UserName = "Administrator",
                NormalizedUserName = "ADMINISTRATOR",
                Email = "administrator@test_university.com",
                NormalizedEmail = "ADMINISTRATOR@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            });
        }
    }
}
