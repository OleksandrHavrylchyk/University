﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University.Migrations;

namespace University.Migrations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = "4068f51d-7c95-4c19-bfb0-5c9e12c082cc",
                            ConcurrencyStamp = "7cb094f2-50f7-41b2-a5cc-67d9a1369bb5",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "db36b19e-5afb-49c3-89f7-8ecee57c0912",
                            ConcurrencyStamp = "ea1156e0-9821-40e0-b6c6-86df14d541db",
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
                            Id = "ee940cf1-1b2e-4794-a5aa-927c438bd76d",
                            AccessFailedCount = 0,
                            Age = 0,
                            ConcurrencyStamp = "3b6e089d-143c-4741-832e-1e53de49f9fb",
                            Email = "administrator@testuniversity.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@TESTUNIVERSITY.COM",
                            NormalizedUserName = "ADMINISTRATOR",
                            PasswordHash = "AQAAAAEAACcQAAAAEEIbFS4m9rTwADM0As2WK3KK0un1qHkC4wcndv2IWuA+3IqPHa8Yt5lx3jGpyTm31g==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Administrator"
                        },
                        new
                        {
                            Id = "d0350d6e-afb1-42a1-a08e-4a57e046dfbd",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "c51aa8f0-bdfc-49da-ac78-9b8894b7da09",
                            Email = "student1@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Smith",
                            LockoutEnabled = false,
                            Name = "John",
                            NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAEAACcQAAAAEDo/WVdz7DgWK6Bfzl4Cjud3h0DPD5/f+GIkwKkdK6VR3EjD7nsTeUF49XWivZGNQA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student1"
                        },
                        new
                        {
                            Id = "8b340cad-e938-4c18-9bc5-49da6c3beeef",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "0f435514-5193-4e2a-8254-50842b642590",
                            Email = "student2@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Jones",
                            LockoutEnabled = false,
                            Name = "David",
                            NormalizedEmail = "STUDENT2@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAEAACcQAAAAEP08/IVpoxY+D9a7Air8rmNNKMDDL7GQkgcIE29nTBo7iP6fdN7JeU1oSrwwP0nsGQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student2"
                        },
                        new
                        {
                            Id = "daac0e00-2f85-49be-a39b-335b23c29f6f",
                            AccessFailedCount = 0,
                            Age = 23,
                            ConcurrencyStamp = "35cad4cb-e7b0-4780-9146-4a39e2f4576a",
                            Email = "student3@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Johnson",
                            LockoutEnabled = false,
                            Name = "Michael",
                            NormalizedEmail = "STUDENT3@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT3",
                            PasswordHash = "AQAAAAEAACcQAAAAEKZx4AKBG2zKUcHEa4onqX9eIzxeSq2ACkjqC+h8hs7k7n8pDPcLbm5LPr5SbbWAuA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student3"
                        },
                        new
                        {
                            Id = "07a5196c-86aa-4e25-bd44-592607ecae5b",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "d7b84ee2-a171-4a37-a4b5-d6608ff1e48a",
                            Email = "student4@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Lee",
                            LockoutEnabled = false,
                            Name = "Chris",
                            NormalizedEmail = "STUDENT4@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT4",
                            PasswordHash = "AQAAAAEAACcQAAAAEE1w/iy7xh1UypyiHpW5Ala28/OtXGdi3rZXNwrnaMIk06F+5zWtBA9BvkOWAynD8A==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student4"
                        },
                        new
                        {
                            Id = "7aaec7b8-b291-4583-aaa2-04e59d48e982",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "84a09b3f-9a0d-44fe-8f92-4b84d6347855",
                            Email = "student5@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Brown",
                            LockoutEnabled = false,
                            Name = "Mike",
                            NormalizedEmail = "STUDENT5@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT5",
                            PasswordHash = "AQAAAAEAACcQAAAAEF2q+2lenDUT3Vwb6OaNDM/c2G2j/fJltdHzJTLY6mWtd3xcmINEbi8bm7FRujnwKg==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student5"
                        },
                        new
                        {
                            Id = "5a96b78b-1020-4b3c-9628-de506039fa1d",
                            AccessFailedCount = 0,
                            Age = 19,
                            ConcurrencyStamp = "27baadfb-ceab-4c46-822e-e7e292ba57ee",
                            Email = "student6@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Williams",
                            LockoutEnabled = false,
                            Name = "Mark",
                            NormalizedEmail = "STUDENT6@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT6",
                            PasswordHash = "AQAAAAEAACcQAAAAECnEQIRn+ElYgIZF9BrBBCojKCYhIchPUCh/pzVdrR3t+/nRyrGsF0fmdNnL1XJrlw==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student6"
                        },
                        new
                        {
                            Id = "2a410466-ae76-4283-a667-8962b0ff8c29",
                            AccessFailedCount = 0,
                            Age = 21,
                            ConcurrencyStamp = "accec96f-484a-4aa7-abc4-38ee490ebc77",
                            Email = "student7@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Rodriguez",
                            LockoutEnabled = false,
                            Name = "Paul",
                            NormalizedEmail = "STUDENT7@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT7",
                            PasswordHash = "AQAAAAEAACcQAAAAEAvOAjFLTQPrJZPYO0DHWE35KTxX4SOaXI6SEYdTaVN3LUWIs1Yum/jQQDAWQ2Z3uQ==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student7"
                        },
                        new
                        {
                            Id = "1bce854d-df06-47b7-a73f-9d70d4a45f3d",
                            AccessFailedCount = 0,
                            Age = 22,
                            ConcurrencyStamp = "21cecfa3-a28d-42b3-bb43-165643383321",
                            Email = "student8@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Garcia",
                            LockoutEnabled = false,
                            Name = "Daniel",
                            NormalizedEmail = "STUDENT8@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT8",
                            PasswordHash = "AQAAAAEAACcQAAAAEEeLSYSHY3Gu9MFb9KauZpaXIL77wJstIbT5FYzIRTEwsQf4Y2eu1aRKLGmgiaQfDA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student8"
                        },
                        new
                        {
                            Id = "6c71fc31-a6c8-42d2-bb28-2de400446126",
                            AccessFailedCount = 0,
                            Age = 20,
                            ConcurrencyStamp = "4b9c0fcf-2866-450c-bffb-723bf8f1851a",
                            Email = "student9@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Gonzalez",
                            LockoutEnabled = false,
                            Name = "James",
                            NormalizedEmail = "STUDENT9@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT9",
                            PasswordHash = "AQAAAAEAACcQAAAAEA37qq49rlHsyYxuBlo/2kj9P1/K3Zp/cbnoYfmrPw+ZqphNgbOKL6AS59M4P4pfJA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "Student9"
                        },
                        new
                        {
                            Id = "aa780de3-3efb-4f58-b778-fa4baec6c01e",
                            AccessFailedCount = 0,
                            Age = 18,
                            ConcurrencyStamp = "2986f7e2-08c8-4b86-9ee0-18913db491ef",
                            Email = "student10@testuniversity.com",
                            EmailConfirmed = true,
                            LastName = "Lopez",
                            LockoutEnabled = false,
                            Name = "Maria",
                            NormalizedEmail = "STUDENT1@TESTUNIVERSITY.COM",
                            NormalizedUserName = "STUDENT10",
                            PasswordHash = "AQAAAAEAACcQAAAAEFWj1hrWAe7MADWolQW0Fl+q1d1w/rV7+r9bwzjfDurwFqYDL348zCQtZyJfetVijA==",
                            PhoneNumberConfirmed = false,
                            RegisteredDate = new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230),
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
                            CourseUrl = "geomentry_and_trygonometry_26.03.2020",
                            CoverUrl = "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
                            Description = "Yet bed any for travelling assistance indulgence unpleasing. Not thoughts all exercise blessing. Indulgence way everything joy alteration boisterous the attachment. Party we years to order allow asked of. We so opinion friends me message as delight. Whole front do of plate heard oh ought. His defective nor convinced residence own. Connection has put impossible own apartments boisterous.At jointure ladyship an insisted so humanity he. Friendly bachelor entrance to on by.Its had resolving otherwise she contented therefore.Afford relied warmth out sir hearts sister use garden.Men day warmth formed admire former simple.Humanity declared vicinity continue supplied no an.He hastened am no property exercise of.Dissimilar comparison no terminated devonshire no literature on. Say most yet head room such just easy. For norland produce age wishing.To figure on it spring season up.Her provision acuteness had excellent two why intention. As called mr needed praise at. Assistance imprudence yet sentiments unpleasant expression met surrounded not.Be at talked ye though secure nearer.Up am intention on dependent questions oh elsewhere september.No betrayed pleasure possible jointure we in throwing.And can event rapid any shall woman green.Hope they dear who its bred.Smiling nothing affixed he carried it clothes calling he no.Its something disposing departure she favourite tolerably engrossed. Truth short folly court why she their balls.Excellence put unaffected reasonable mrs introduced conviction she. Nay particular delightful but unpleasant for uncommonly who. Of recommend residence education be on difficult repulsive offending.Judge views had mirth table seems great him for her.Alone all happy asked begin fully stand own get.Excuse ye seeing result of we. See scale dried songs old may not.Promotion did disposing you household any instantly.Hills we do under times at first short an. One advanced diverted domestic sex repeated bringing you old.Possible procured her trifling laughter thoughts property she met way. Companions shy had solicitude favourable own. Which could saw guest man now heard but. Lasted my coming uneasy marked so should.Gravity letters it amongst herself dearest an windows by.Wooded ladies she basket season age her uneasy saw.Discourse unwilling am no described dejection incommode no listening of. Before nature his parish boy.No comfort do written conduct at prevent manners on. Celebrated contrasted discretion him sympathize her collecting occasional. Do answered bachelor occasion in of offended no concerns. Supply worthy warmth branch of no ye.Voice tried known to as my to. Though wished merits or be.Alone visit use these smart rooms ham.No waiting in on enjoyed placing it inquiry.Much did had call new drew that kept.Limits expect wonder law she.Now has you views woman noisy match money rooms.To up remark it eldest length oh passed.Off because yet mistake feeling has men. Consulted disposing to moonlight ye extremity. Engage piqued in on coming. Rooms oh fully taken by worse do. Points afraid but may end law lasted.Was out laughter raptures returned outweigh. Luckily cheered colonel me do we attacks on highest enabled.Tried law yet style child.Bore of true of no be deal. Frequently sufficient in be unaffected. The furnished she concluded depending procuring concealed.Difficulty on insensible reasonable in. From as went he they.Preference themselves me as thoroughly partiality considered on in estimating.Middletons acceptance discovered projecting so is so or. In or attachment inquietude remarkably comparison at an. Is surrounded prosperous stimulated am me discretion expression. But truth being state can she china widow. Occasional preference fat remarkably now projecting uncommonly dissimilar. Sentiments projection particular companions interested do at my delightful.Listening newspaper in advantage frankness to concluded unwilling",
                            Duration = 5f
                        },
                        new
                        {
                            ID = 2,
                            CourseName = "Art",
                            CourseUrl = "art_26.03.2020",
                            CoverUrl = "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
                            Description = "Course Descriprion",
                            Duration = 12f
                        },
                        new
                        {
                            ID = 3,
                            CourseName = "English",
                            CourseUrl = "english_26.03.2020",
                            CoverUrl = "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
                            Description = "Course Descriprion",
                            Duration = 15f
                        },
                        new
                        {
                            ID = 4,
                            CourseName = "Programming",
                            CourseUrl = "programming_26.03.2020",
                            CoverUrl = "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
                            Description = "Course Descriprion",
                            Duration = 9f
                        },
                        new
                        {
                            ID = 5,
                            CourseName = "History",
                            CourseUrl = "history_26.03.2020",
                            CoverUrl = "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
                            Description = "Course Descriprion",
                            Duration = 8f
                        },
                        new
                        {
                            ID = 6,
                            CourseName = "Chemistry",
                            CourseUrl = "chemistry_26.03.2020",
                            CoverUrl = "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg",
                            DateAdded = new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446),
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
