using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class ModifyUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8cd3c75a-31fc-4244-b289-225070f9c5b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee7c75cf-6752-470c-8338-3b46e5f688fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25ddad4c-1a1d-41ca-8764-3d85ed67f658");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39c56e5c-170c-475b-9002-4bb74ed2e751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4815e3c0-7281-4730-b618-531964000a90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "59c98eff-f9ec-4850-8f60-f7226598181b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "616adeaf-f609-4c87-a45c-17f2427fa04d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b5b3e1e-9ee9-4532-9948-8196610406c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9fa75550-5af8-443c-9757-1c0a6d1c0a4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bfb1cc89-9cc0-4139-8081-4edbaf2eca16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e70cafd1-8001-4d9e-818b-e4af10a52f41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9861c1d-02c7-48e9-b7db-996f6fd026fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f56b2ede-bb0a-4891-a9ee-811fc163bab2");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StudyDate",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d5438346-e6ed-4208-8e89-ad0dc6549b66", "33a3d5f3-0b87-4e20-b125-f9b067e1cdf0", "User", "USER" },
                    { "fef9c9ad-f886-4481-b42d-8e81e048242c", "03b86443-c14d-4850-942e-4436ae71143f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "StudyDate", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04294453-d2a7-43bd-8a57-6200a1c0f424", 0, 0, "c31dd710-3943-46ba-ad13-519272a4248c", "student10@test_university.com", true, null, false, null, null, "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAENENmlD25Rblg/Dve7lw/KlgTggoiHBGuf9w/cSyo/dTbxcHai256Z3kY+U2Oi5FhA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student10" },
                    { "69c78f7f-2d14-4379-aef9-a32fb726c28c", 0, 0, "863b3902-7f8d-4b4a-8944-10a3d0f7bb1a", "student9@test_university.com", true, null, false, null, null, "STUDENT9@TEST_UNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEAF3cmKA0jbOo5ZI7u7q2Ce4wOBNK9QqnogG6SNEH+JrnqfmE1Xrjpc9faW4mahpgQ==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student9" },
                    { "b1022a33-6488-4e45-b61d-9a976e14c485", 0, 0, "12ecdbfa-37ab-4cc5-b4b9-24adb210766f", "student8@test_university.com", true, null, false, null, null, "STUDENT8@TEST_UNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEC511pvlmiE10i+pilbFY7Kpy2bajS4Ko6jHE3rH6b9ljR42IKa4ZzI263hm/zo3JA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student8" },
                    { "b241b70d-98ca-486d-8111-5f012569fc00", 0, 0, "eb6cb153-b4e9-4ce8-b5ba-48fea883d0ae", "student6@test_university.com", true, null, false, null, null, "STUDENT6@TEST_UNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAELnsuy/AfXx+LIzjtuqayOTBSg2Bpqbb/0LuSwi7Rh3VdH6Jmv7AN4HfGvl9f0lhzA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student6" },
                    { "e19b0d20-547b-4417-98e2-35fcc2afe010", 0, 0, "2f506c60-a1b6-4cc4-8146-2ed898481dda", "student5@test_university.com", true, null, false, null, null, "STUDENT5@TEST_UNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAEPTG/HU4rCAeGgu4W/Xt3k31EExGhNwdEWNCMKjQVZpoVr7a6Jf3fq0Kdh5DmHg+IA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student5" },
                    { "757cb929-ef1c-4e30-987f-26e39d00eca8", 0, 0, "53a6ad2c-5f92-4f67-9cc8-4b290d72b0c3", "student7@test_university.com", true, null, false, null, null, "STUDENT7@TEST_UNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEPZJwvp/h4NP7wLA0THsADej3Q7Yhu26pAQ3bNWiTxsgCIK1jY7iUk/F29quLvhEVg==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student7" },
                    { "e2f8fa59-7527-437e-9d5a-0749e543d039", 0, 0, "c0b90361-c20f-4768-8127-1b55def19966", "student3@test_university.com", true, null, false, null, null, "STUDENT3@TEST_UNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEPUKb+acGbTKxuMSI27S/LtZJycg6604O1xY8h0xUtFw9YdtmD3YYrKz2mIchVOjgg==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student3" },
                    { "196e7b54-1801-4a6a-b991-8fcea174715c", 0, 0, "6e02b9e0-0b0a-436a-bc10-260e25b2f0c9", "student2@test_university.com", true, null, false, null, null, "STUDENT2@TEST_UNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEELLhUJgY0Bo57m+tUXvbg/RDy4N3uoRXjjlAHK5+IxRdIzBlzrPxFTtBUKHdhx+pQ==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student2" },
                    { "b88eb297-874c-430e-9932-5afb40e852d7", 0, 0, "0bae193a-f424-465c-9d53-eb9663a00665", "student1@test_university.com", true, null, false, null, null, "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEAxTSm3Ux/jo5mdA7+cLE/M6dYtxjE8d3/9qb0ppqwanw7PNBAlqX8kZzuBasBeSJw==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student1" },
                    { "184d11f7-9a85-459b-8811-7639820e3ded", 0, 0, "dfd72b53-b47a-4bc3-a40f-72455ad86156", "administrator@test_university.com", true, null, false, null, null, "ADMINISTRATOR@TEST_UNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEJ50E+JltdTc+NrpMokZ/08hi7qW7hkfSb1iUEWYJNg18S4VBt/aBNqD8X1deQmvmQ==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Administrator" },
                    { "00941377-8ca3-4c21-857a-49c594691657", 0, 0, "df533714-f685-4295-8df9-40f8bc342644", "student4@test_university.com", true, null, false, null, null, "STUDENT4@TEST_UNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEObrsaK1VnrjhpinNyN5dxNwlQzCZ+/KrmX25R2bWBPilif2rnY+jfYtz8njkslGuw==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 13, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 3, 15, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 17, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 19, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2020, 3, 21, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2020, 3, 23, 8, 58, 42, 893, DateTimeKind.Local).AddTicks(3153));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5438346-e6ed-4208-8e89-ad0dc6549b66");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fef9c9ad-f886-4481-b42d-8e81e048242c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00941377-8ca3-4c21-857a-49c594691657");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04294453-d2a7-43bd-8a57-6200a1c0f424");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "184d11f7-9a85-459b-8811-7639820e3ded");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "196e7b54-1801-4a6a-b991-8fcea174715c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69c78f7f-2d14-4379-aef9-a32fb726c28c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "757cb929-ef1c-4e30-987f-26e39d00eca8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b1022a33-6488-4e45-b61d-9a976e14c485");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b241b70d-98ca-486d-8111-5f012569fc00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b88eb297-874c-430e-9932-5afb40e852d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e19b0d20-547b-4417-98e2-35fcc2afe010");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2f8fa59-7527-437e-9d5a-0749e543d039");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegisteredDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StudyDate",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ee7c75cf-6752-470c-8338-3b46e5f688fb", "a9874276-1e89-4d20-90e4-8bad24acf2ed", "User", "USER" },
                    { "8cd3c75a-31fc-4244-b289-225070f9c5b5", "62dc2b66-94a3-41a4-b45c-1e4d6239f97a", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8b5b3e1e-9ee9-4532-9948-8196610406c1", 0, "2a37de6c-ac54-49b0-81f6-72142fdfa833", "student10@test_university.com", true, false, null, "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAEHuSnAyhyl5YphKcQO6T6fziyzoZiCOJW+MOstoifZa0dhyT7skAY1wChnf1SrjvEg==", null, false, "", false, "Student10" },
                    { "4815e3c0-7281-4730-b618-531964000a90", 0, "626a9841-fb78-40d1-89a2-13d64409bcda", "student9@test_university.com", true, false, null, "STUDENT9@TEST_UNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEEKni9kKMWxNljElymYx2ciBH3VXpvsG8fcEDGkIpYZNrbdrfLIxoiYnW484q6lidw==", null, false, "", false, "Student9" },
                    { "616adeaf-f609-4c87-a45c-17f2427fa04d", 0, "91922884-a14e-4bcc-b76c-baa23a7e704b", "student8@test_university.com", true, false, null, "STUDENT8@TEST_UNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEH1XMiZT+ptKIYL//okDfum9Ep9WVIv7yNuTgS2ROix8Aj9gTObNxbT9wY0sZbwwGA==", null, false, "", false, "Student8" },
                    { "59c98eff-f9ec-4850-8f60-f7226598181b", 0, "c7ff3cd6-cf0d-49bf-bb83-52223f9c6df1", "student6@test_university.com", true, false, null, "STUDENT6@TEST_UNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAEE+NY8nMRQPO1nWSx9hCX2La0kaBze5nAaBKk2WliOxnaQ7EySwDosxayfbP+cdFsg==", null, false, "", false, "Student6" },
                    { "e9861c1d-02c7-48e9-b7db-996f6fd026fc", 0, "fd9bc19c-70a7-48f5-93e8-325e8e569c07", "student5@test_university.com", true, false, null, "STUDENT5@TEST_UNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAED3SnWRe1uZTqTV0Tr2OaR9e8exBP41BgltMeWOrxPIdZe1rv/nadm3BujuapkGREg==", null, false, "", false, "Student5" },
                    { "9fa75550-5af8-443c-9757-1c0a6d1c0a4f", 0, "f50e8745-1d26-4455-99a5-77641acdfaaa", "student7@test_university.com", true, false, null, "STUDENT7@TEST_UNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEInUGXGGa0tpjf+2v/XwA+jGWSqndj9WLH4PgoqJJjcK7ya+FJue+Hla0QV+s9x1xw==", null, false, "", false, "Student7" },
                    { "39c56e5c-170c-475b-9002-4bb74ed2e751", 0, "07cb2e94-95b8-4ff5-8362-8a96c2e83cff", "student3@test_university.com", true, false, null, "STUDENT3@TEST_UNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEJhKBqDhBAVEAB5s2hChlOTbpfi0sHYgCySH35NHTWqfNMGFGJ8iUxwKeJIrmSp5Hw==", null, false, "", false, "Student3" },
                    { "bfb1cc89-9cc0-4139-8081-4edbaf2eca16", 0, "34983133-c114-47d7-a378-3a85cd0850b7", "student2@test_university.com", true, false, null, "STUDENT2@TEST_UNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEA0p0QCe7F6i1AfGYPGHqBweadEP38gZHHn9/LsubbpnVfLZ9I+Nz8TXD2ZKcs81ig==", null, false, "", false, "Student2" },
                    { "e70cafd1-8001-4d9e-818b-e4af10a52f41", 0, "cefd4a47-4c2e-4bf1-b270-b1973dc40bf8", "student1@test_university.com", true, false, null, "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEC2zkbLnyBmTq+dStY7JdTT5XU0SADbJxXHkTT8uI9bnogK0J0b6elAY0SrK7f46Uw==", null, false, "", false, "Student1" },
                    { "f56b2ede-bb0a-4891-a9ee-811fc163bab2", 0, "19b10cd2-6ecb-4f3c-9b2a-999e417a32d2", "administrator@test_university.com", true, false, null, "ADMINISTRATOR@TEST_UNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEJJm87JeHwErq/WW2m5BkgGxFs17eZR8rjLEZsLqGWYhXGffeagctVDdz/T8JtU3/w==", null, false, "", false, "Administrator" },
                    { "25ddad4c-1a1d-41ca-8764-3d85ed67f658", 0, "cf3fb3fb-6e27-4062-b770-6a1336e34355", "student4@test_university.com", true, false, null, "STUDENT4@TEST_UNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEOQ0cW7D9FaOV4taWfbvGwO8NhoJ+2eFFssl5+K5A5Jn9JAbW6ZJpozphziVPls+2Q==", null, false, "", false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 13, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 3, 15, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 17, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 19, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2020, 3, 21, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2020, 3, 23, 5, 35, 0, 718, DateTimeKind.Local).AddTicks(8558));
        }
    }
}
