﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Migrations;

namespace University.Migrations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200325111410_AddedCourseUrl")]
    partial class AddedCourseUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "03b5f7c0-3045-42cb-9837-30e5a5847c1c",
                            ConcurrencyStamp = "9262dfa2-87af-4ce7-8138-9bef5757db27",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "0c9bebb8-6d1e-47b8-a606-1c41b6044447",
                            ConcurrencyStamp = "ae1ed0ef-459b-4054-987f-6bddebd64074",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("University.ApplicationUserEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "5fcf59d1-6377-4875-b6b6-abd6f117c343",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "d6cb5643-242e-4ab8-bff1-009fae5b9bfc",
                            Email = "administrator@testuniversity.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@TESTUNIVERSITY.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEOaMzKcpcHoM+iI+czalSpSe/ahRApHe4fUtVBtsTUjZKZsORTssJJRZgHQD4YwAvg==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "e841bc12-bb82-4c1c-a229-b585467b90f8",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "cd35e37a-b78e-45e4-aece-83476acb5764",
                            Email = "student1@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Smith",
                            LockoutEnabled = false,
                            Name = "John",
                            NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAEAACcQAAAAECggzoW7QAOrJwN2+C9sQPdzyRrKrgSraEtLaCYWADWUPqUDAFtu39YTg8cazjbINA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student1"
                        },
                        new
                        {
                            Id = "a3bbcb10-13e8-47e0-9cdb-36d57ab44b02",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "85bf08e9-0cec-4c9c-aca9-270606baa033",
                            Email = "student2@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Jones",
                            LockoutEnabled = false,
                            Name = "David",
                            NormalizedEmail = "STUDENT2@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAEAACcQAAAAEN8meUo00UIU0vARSORDNtoyyXpH7wtgl7AycuKEYzgD1WLh7beiIbMKaeZwhD/pOQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student2"
                        },
                        new
                        {
                            Id = "0d653369-2545-4161-a957-b529d1081e90",
                            AccessFailedCount = 0,
                            Age = 23,
                            ConcurrencyStamp = "b9048634-b3af-472a-9ba7-ec77b0a499c9",
                            Email = "student3@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            Name = "Michael",
                            NormalizedEmail = "STUDENT3@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT3",
                            PasswordHash = "AQAAAAEAACcQAAAAEKNCj9MyALqcZHcpLkArNo5iEdD8ffFKoq0ZAUms006nGKjWf6ArV4Hl/gZV68UkQA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student3"
                        },
                        new
                        {
                            Id = "baba9cd9-baa7-443b-a8c5-5a6b4da56b68",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "17bccc95-dc80-43fd-a65f-cde0ecfe0a57",
                            Email = "student4@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Lee",
                            LockoutEnabled = false,
                            Name = "Chris",
                            NormalizedEmail = "STUDENT4@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT4",
                            PasswordHash = "AQAAAAEAACcQAAAAEDrHHon40bwt9ilvzpaq1GVMhsLmi3sk37S6Ro5GU4/HVVORuoo6oAJS3A7roikh3A==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student4"
                        },
                        new
                        {
                            Id = "58921adc-558b-4f2e-b88d-9750a91c827d",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "c58371f9-6b37-40ef-b941-ef394a021c8d",
                            Email = "student5@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Brown",
                            LockoutEnabled = false,
                            Name = "Mike",
                            NormalizedEmail = "STUDENT5@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT5",
                            PasswordHash = "AQAAAAEAACcQAAAAELVRZW1ZV2nxakKlla9aFaVVhvKhwWOqGm9dviWJG3SvSYMQYU1uccusxETTncbtGw==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student5"
                        },
                        new
                        {
                            Id = "69dbe69c-6805-453f-88c1-307b1a084d91",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "62ecc405-15c4-43ee-9b86-740cc82494b7",
                            Email = "student6@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Williams",
                            LockoutEnabled = false,
                            Name = "Mark",
                            NormalizedEmail = "STUDENT6@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT6",
                            PasswordHash = "AQAAAAEAACcQAAAAEFerSNCon85D36rucYWl2Y8Smuk2Q0IBoKZZT6igqYgpIlcCnueOdkKjmDig+3tIgA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student6"
                        },
                        new
                        {
                            Id = "e7f25b63-3f6b-4f8d-9f73-c3d46034623b",
                            AccessFailedCount = 0,
                            Age = 21,
                            ConcurrencyStamp = "d63abd54-3276-4d79-877a-cabb4fffada0",
                            Email = "student7@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Rodriguez",
                            LockoutEnabled = false,
                            Name = "Paul",
                            NormalizedEmail = "STUDENT7@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT7",
                            PasswordHash = "AQAAAAEAACcQAAAAELEyg97ntcCRFcQ9M/bXwNrGCso6WycOyjAPq1yOLDzr4HWGbK90AW0ceJ8str2ppw==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student7"
                        },
                        new
                        {
                            Id = "71dd7ee3-a7f9-4d38-be45-bf4d38591e55",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "54f829a7-4285-48c8-ba9a-8c0e3d7831e1",
                            Email = "student8@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Garcia",
                            LockoutEnabled = false,
                            Name = "Daniel",
                            NormalizedEmail = "STUDENT8@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT8",
                            PasswordHash = "AQAAAAEAACcQAAAAEFbzvnqZ3sDObq5sZrYsq30lnxvt0HXQk7iioEItiWn9Gwl4aaa6jRnyJuR1oKMhVQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student8"
                        },
                        new
                        {
                            Id = "9d06e32d-4a49-4897-bc3c-404bad6a1b7d",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "22532c0c-bd12-4a3d-ad1c-76def482207a",
                            Email = "student9@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Gonzalez",
                            LockoutEnabled = false,
                            Name = "James",
                            NormalizedEmail = "STUDENT9@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT9",
                            PasswordHash = "AQAAAAEAACcQAAAAEKPNj/laSskr++ai4YH6LKr1cZP6EdlFW5/ZQj69j1FY0RlFY3sfuoqbvjpYeS2qKg==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student9"
                        },
                        new
                        {
                            Id = "fddcaf22-0bb6-4946-aad5-3f1284abc023",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "e184a92a-8f89-4343-b515-3a4682675377",
                            Email = "student10@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Lopez",
                            LockoutEnabled = false,
                            Name = "Maria",
                            NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT10",
                            PasswordHash = "AQAAAAEAACcQAAAAEMG7xknkPKG/kumpu4tF0bXSVnwP5mHvU0LpZ93UaWvqjEPQK3smfF7seROILEGkFA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student10"
                        });
                });

            modelBuilder.Entity("University.CourseEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CourseUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseName = "Geometry and Trygonometry",
                            CourseUrl = "geomentry_and_trygonometry_25.03.2020",
                            CoverUrl = "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 5f
                        },
                        new
                        {
                            ID = 2,
                            CourseName = "Art",
                            CourseUrl = "art_25.03.2020",
                            CoverUrl = "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 12f
                        },
                        new
                        {
                            ID = 3,
                            CourseName = "English",
                            CourseUrl = "english_25.03.2020",
                            CoverUrl = "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 15f
                        },
                        new
                        {
                            ID = 4,
                            CourseName = "Programming",
                            CourseUrl = "programming_25.03.2020",
                            CoverUrl = "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 9f
                        },
                        new
                        {
                            ID = 5,
                            CourseName = "History",
                            CourseUrl = "history_25.03.2020",
                            CoverUrl = "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 8f
                        },
                        new
                        {
                            ID = 6,
                            CourseName = "Chemistry",
                            CourseUrl = "chemistry_25.03.2020",
                            CoverUrl = "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg",
                            DateAdded = new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516),
                            Description = "Course Descriprion",
                            Duration = 9f
                        });
                });

            modelBuilder.Entity("University.CourseSubscribersEntity", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StudyDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("UserId");

                    b.ToTable("CourseSubscribers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("University.ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("University.ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("University.ApplicationUserEntity", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("University.CourseSubscribersEntity", b =>
                {
                    b.HasOne("University.CourseEntity", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("University.ApplicationUserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
