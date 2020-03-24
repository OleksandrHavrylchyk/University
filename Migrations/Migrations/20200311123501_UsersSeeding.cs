using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class UsersSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3790f05f-0951-4d83-8f13-cd7b47b0456e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ec64d9f-0769-4099-b2e0-0f0047cc90a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "855ab658-1498-45c8-8e8d-529854c35ab5");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ec64d9f-0769-4099-b2e0-0f0047cc90a8", "0eb32cf0-5360-4be2-8e17-4891844adfa3", "User", "USER" },
                    { "3790f05f-0951-4d83-8f13-cd7b47b0456e", "19f529d0-90fe-4f70-98d2-af0aadc1a015", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "855ab658-1498-45c8-8e8d-529854c35ab5", 0, "08438f0f-4fa9-47f0-9841-0b1c07971220", "administrator@test_university.com", true, false, null, "ADMINISTRATOR@TEST_UNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEPgJ98kvdVKU2ZU9eojvZdWxCEFvjEDaG1P0qeT9sIB/VvjfpC/LRj1NiAD7Yuc1yg==", null, false, "", false, "Administrator" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 13, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 3, 15, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 17, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 19, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2020, 3, 21, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2020, 3, 23, 1, 10, 16, 927, DateTimeKind.Local).AddTicks(5887));
        }
    }
}
