using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace University.Migrations.EntityConfigurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<ApplicationUserEntity>
    {
        private readonly PasswordHasher<ApplicationUserEntity> hasher;
        private DateTime currentTime;
        public UsersConfiguration()
        {
            hasher = new PasswordHasher<ApplicationUserEntity>();
            currentTime = DateTime.UtcNow;
        }
        public void Configure(EntityTypeBuilder<ApplicationUserEntity> builder)
        {
            builder.HasData(
            new ApplicationUserEntity
            {
                UserName = "Administrator",
                NormalizedUserName = "ADMINISTRATOR",
                Email = "administrator@testuniversity.com",
                NormalizedEmail = "ADMINISTRATOR@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty,
                RegisteredDate = currentTime
            },
            new ApplicationUserEntity
            {
                UserName = "Student1",
                Name = "John",
                LastName = "Smith",
                Age = 19,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT1",
                Email = "student1@testuniversity.com",
                NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student2",
                Name = "David",
                LastName = "Jones",
                Age = 19,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT2",
                Email = "student2@testuniversity.com",
                NormalizedEmail = "STUDENT2@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student3",
                Name = "Michael",
                LastName = "Johnson",
                Age = 23,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT3",
                Email = "student3@testuniversity.com",
                NormalizedEmail = "STUDENT3@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student4",
                Name = "Chris",
                LastName = "Lee",
                Age = 18,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT4",
                Email = "student4@testuniversity.com",
                NormalizedEmail = "STUDENT4@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student5",
                Name = "Mike",
                LastName = "Brown",
                Age = 22,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT5",
                Email = "student5@testuniversity.com",
                NormalizedEmail = "STUDENT5@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student6",
                Name = "Mark",
                LastName = "Williams",
                Age = 19,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT6",
                Email = "student6@testuniversity.com",
                NormalizedEmail = "STUDENT6@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student7",
                Name = "Paul",
                LastName = "Rodriguez",
                Age = 21,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT7",
                Email = "student7@testuniversity.com",
                NormalizedEmail = "STUDENT7@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student8",
                Name = "Daniel",
                LastName = "Garcia",
                Age = 22,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT8",
                Email = "student8@testuniversity.com",
                NormalizedEmail = "STUDENT8@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student9",
                Name = "James",
                LastName = "Gonzalez",
                Age = 20,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT9",
                Email = "student9@testuniversity.com",
                NormalizedEmail = "STUDENT9@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            },
            new ApplicationUserEntity
            {
                UserName = "Student10",
                Name = "Maria",
                LastName = "Lopez",
                Age = 18,
                RegisteredDate = currentTime,
                NormalizedUserName = "STUDENT10",
                Email = "student10@testuniversity.com",
                NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Zxcv_1234"),
                SecurityStamp = string.Empty
            });
        }
    }
}
