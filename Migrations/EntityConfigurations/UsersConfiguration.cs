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
            },
            new ApplicationUserEntity
            {
                UserName = "Student1",
                NormalizedUserName = "STUDENT1",
                Email = "student1@test_university.com",
                NormalizedEmail = "STUDENT1@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student2",
                NormalizedUserName = "STUDENT2",
                Email = "student2@test_university.com",
                NormalizedEmail = "STUDENT2@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student3",
                NormalizedUserName = "STUDENT3",
                Email = "student3@test_university.com",
                NormalizedEmail = "STUDENT3@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student4",
                NormalizedUserName = "STUDENT4",
                Email = "student4@test_university.com",
                NormalizedEmail = "STUDENT4@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student5",
                NormalizedUserName = "STUDENT5",
                Email = "student5@test_university.com",
                NormalizedEmail = "STUDENT5@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student6",
                NormalizedUserName = "STUDENT6",
                Email = "student6@test_university.com",
                NormalizedEmail = "STUDENT6@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student7",
                NormalizedUserName = "STUDENT7",
                Email = "student7@test_university.com",
                NormalizedEmail = "STUDENT7@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student8",
                NormalizedUserName = "STUDENT8",
                Email = "student8@test_university.com",
                NormalizedEmail = "STUDENT8@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student9",
                NormalizedUserName = "STUDENT9",
                Email = "student9@test_university.com",
                NormalizedEmail = "STUDENT9@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student10",
                NormalizedUserName = "STUDENT10",
                Email = "student10@test_university.com",
                NormalizedEmail = "STUDENT1@TEST_UNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            });
        }
    }
}
