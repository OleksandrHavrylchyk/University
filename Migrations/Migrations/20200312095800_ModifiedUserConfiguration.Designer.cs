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
    [Migration("20200312095800_ModifiedUserConfiguration")]
    partial class ModifiedUserConfiguration
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
                            Id = "71d2ea2d-37c7-4317-95a2-543dc9f59cc0",
                            ConcurrencyStamp = "5e883516-001d-41b7-95f5-d14b39dcee46",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "13b25c20-4f7d-4bc0-b095-b4243e7d03b4",
                            ConcurrencyStamp = "f5af6e6a-e054-4d58-9bb5-1288d70bf553",
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

                    b.Property<DateTime>("StudyDate")
                        .HasColumnType("datetime2");

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
                            Id = "72cf58e7-8115-4b0a-8560-0ec51077f4d7",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "47ff89c0-b146-4eb5-992e-69d0cc9de3ad",
                            Email = "administrator@test_university.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEGnXGpXdBPPdFkqKRH6/LJKnbfupMQ1HIefhEBkM8q/4VC4+6oEafaKLPAO3PjM+sA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "97a75a27-e980-42a4-90ef-b5e43e9b3dc1",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "e2601378-dd9c-4b56-b2e9-e1f43084e631",
                            Email = "student1@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Smith",
                            LockoutEnabled = false,
                            Name = "John",
                            NormalizedEmail = "STUDENT1@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAEAACcQAAAAEFx171Dv4kn1+5F5qNljmfl6Y4uUxyAxiE7yU9ypqd3JaKAGoI4N2IUrb+HRvDetWg==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student1"
                        },
                        new
                        {
                            Id = "2c90ca14-33f1-4319-ae98-05c2c8df6289",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "e2c080cb-2ed7-45f8-b077-89e0f8820610",
                            Email = "student2@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Jones",
                            LockoutEnabled = false,
                            Name = "David",
                            NormalizedEmail = "STUDENT2@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAEAACcQAAAAEAS7oBO6EP1DmL6EAiIf9bK8+J8in9JYsWkJvNO4MULEYfk9iwcFVmBOYciMr4vkkA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student2"
                        },
                        new
                        {
                            Id = "a3663c55-d346-412a-a5a1-c40b3a4a5c4d",
                            AccessFailedCount = 0,
                            Age = 23,
                            ConcurrencyStamp = "069a7242-310e-46fb-9667-9174ce1b5040",
                            Email = "student3@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            Name = "Michael",
                            NormalizedEmail = "STUDENT3@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT3",
                            PasswordHash = "AQAAAAEAACcQAAAAELcIsOfUeJSdaZF1UB2Et9lTL5ZWWVlXs90JpZfd7nSbTwJCxv9ohil9WP1eUFYrEA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student3"
                        },
                        new
                        {
                            Id = "6afb1113-3462-42d6-92be-0b3fe5c6302d",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "b70d6ecd-5268-4742-a0f8-59ffa24733bb",
                            Email = "student4@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Lee",
                            LockoutEnabled = false,
                            Name = "Chris",
                            NormalizedEmail = "STUDENT4@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT4",
                            PasswordHash = "AQAAAAEAACcQAAAAEFyoED1yYpNYuBhHH9Fh0hrMuqZ61YebXxFJ4HDdhX+xLccOgWuNHULmZxnmiTwP/g==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student4"
                        },
                        new
                        {
                            Id = "d22215c9-91cd-4874-ad88-602bc427d111",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "e29e4dd7-b703-43cd-aa2a-18d9554d977b",
                            Email = "student5@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Brown",
                            LockoutEnabled = false,
                            Name = "Mike",
                            NormalizedEmail = "STUDENT5@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT5",
                            PasswordHash = "AQAAAAEAACcQAAAAEBiIMrMEMAg1Bf8+EFKiYVLC+6T7P9ePFZ86QNtpDomN4YYgTFz7GWZMeQflSNtBYQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student5"
                        },
                        new
                        {
                            Id = "cffedb0c-2989-47b6-943b-c5ac8cbc3199",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "3b33793b-514d-47d4-a7f4-7ab267c5bc51",
                            Email = "student6@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Williams",
                            LockoutEnabled = false,
                            Name = "Mark",
                            NormalizedEmail = "STUDENT6@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT6",
                            PasswordHash = "AQAAAAEAACcQAAAAEH4WeQBvXdQAxlrgPNMZa4XjjJEcViQta1dGJX9910EBUg50i2KMJOFNhOMTvu95lg==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student6"
                        },
                        new
                        {
                            Id = "f1536f90-c88d-4c1e-982b-c73fa83f45e5",
                            AccessFailedCount = 0,
                            Age = 21,
                            ConcurrencyStamp = "d30f9502-83b4-407d-97a3-58e8595b6f42",
                            Email = "student7@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Rodriguez",
                            LockoutEnabled = false,
                            Name = "Paul",
                            NormalizedEmail = "STUDENT7@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT7",
                            PasswordHash = "AQAAAAEAACcQAAAAEKiv1P6/B7xHT6+0H+mhzuyOsRCVZ8m4r6N4EE0BhMhsKtHwh0uDmMKDNjDim7zU/g==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student7"
                        },
                        new
                        {
                            Id = "8c809388-129f-4ae3-8189-ca67357823ce",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "ec08501a-7aaa-4907-8d85-bb9900cf8c03",
                            Email = "student8@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Garcia",
                            LockoutEnabled = false,
                            Name = "Daniel",
                            NormalizedEmail = "STUDENT8@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT8",
                            PasswordHash = "AQAAAAEAACcQAAAAEE2Ks57jOx7eDsfTi5+W+Z3e0B4eUdz6NIvcOYLP21MVApjVC9+KJMDWive4xnFOSA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student8"
                        },
                        new
                        {
                            Id = "76f5e330-c804-4b7d-b5df-ddaa29e6c8f0",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "c45409d8-d3b1-47f8-95f1-097d21072671",
                            Email = "student9@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Gonzalez",
                            LockoutEnabled = false,
                            Name = "James",
                            NormalizedEmail = "STUDENT9@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT9",
                            PasswordHash = "AQAAAAEAACcQAAAAEIhxq4xksA/8fYrryEcZg3DsXHIwmFZOyvBAraW4m7v5E0Yu6qxu05Pjq5QZlAdT1w==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TwoFactorEnabled = false,
                            UserName = "Student9"
                        },
                        new
                        {
                            Id = "154c07e4-a991-4488-9b53-008ea92cc2c1",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "2e80f021-2074-4fbb-bb2c-5795df02bbd4",
                            Email = "student10@test_university.com",
                            EmailConfirmed = true,
                            LastName = "Lopez",
                            LockoutEnabled = false,
                            Name = "Maria",
                            NormalizedEmail = "STUDENT1@TEST_UNIVERSITY.COM",
                            NormalizedUserName = "STUDENT10",
                            PasswordHash = "AQAAAAEAACcQAAAAEEHt3eYaiXrKvvf6AEhmJdjXAlPVwkwWGrt0NgScp67Eo6EUGCPJwdb5VsaUGx1jqA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SecurityStamp = "",
                            StudyDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
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

                    b.Property<string>("CoverUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Duration")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseName = "Geometry and Trygonometry",
                            CoverUrl = "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg",
                            Description = "Course Descriprion",
                            Duration = 1.5f,
                            StartDate = new DateTime(2020, 3, 14, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
                        },
                        new
                        {
                            ID = 2,
                            CourseName = "Art",
                            CoverUrl = "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg",
                            Description = "Course Descriprion",
                            Duration = 2f,
                            StartDate = new DateTime(2020, 3, 16, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
                        },
                        new
                        {
                            ID = 3,
                            CourseName = "English",
                            CoverUrl = "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg",
                            Description = "Course Descriprion",
                            Duration = 1.5f,
                            StartDate = new DateTime(2020, 3, 18, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
                        },
                        new
                        {
                            ID = 4,
                            CourseName = "Programming",
                            CoverUrl = "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg",
                            Description = "Course Descriprion",
                            Duration = 1f,
                            StartDate = new DateTime(2020, 3, 20, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
                        },
                        new
                        {
                            ID = 5,
                            CourseName = "History",
                            CoverUrl = "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg",
                            Description = "Course Descriprion",
                            Duration = 1.5f,
                            StartDate = new DateTime(2020, 3, 22, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
                        },
                        new
                        {
                            ID = 6,
                            CourseName = "Chemistry",
                            CoverUrl = "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg",
                            Description = "Course Descriprion",
                            Duration = 1.5f,
                            StartDate = new DateTime(2020, 3, 24, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940)
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
