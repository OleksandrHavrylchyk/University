using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class ModifyCoursesSubscribersEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4aeb7345-08b7-4865-b229-2fbb60075197");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5e7bb04-cd0c-4bc1-ad1c-ae81d1903a25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "084e880d-08da-4c05-9a56-d754655d0fb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23379e09-02a5-421a-b74a-2605431a043d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3048b6ea-601b-4ad9-bb50-3e7cc0ef8182");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "309b3531-8d78-4220-8ec8-415634b28d9a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a604780-f8b4-492d-aa87-f3030ccf64dd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f27ea8c-b4ce-49db-b15e-30b89dd6e909");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "813208a0-cbd0-4bf5-8f88-95f376338a49");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85917a90-2d5f-45b8-bfa3-eb8eea9ed423");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8dd6410e-8b01-4b1d-9505-721c843b1caa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5e962f7-50e3-4b28-a269-f98103b4bdf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1de004b-1565-4299-a1b1-6a5e6e5da15a");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StudyDate",
                table: "CourseSubscribers",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a33a295-3fcf-45cb-a5a5-a0d448d11012", "943ea836-6896-4fc2-9c5e-2b6fa601a6d7", "User", "USER" },
                    { "d6a29138-46aa-41ff-8587-fad0a9bd0cfd", "15bbedd3-449e-4fdc-9fd2-a33a19430376", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e44a6e1b-da0f-4296-999f-1da1d995853a", 0, 18, "c624ad6d-d938-49b0-b5ae-92a30dc4b691", "student10@testuniversity.com", true, "Lopez", false, null, "Maria", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAENKVYone5UcBjHqnMuBl4krw3r8cR0cgejAv1M1I6evgCdBo6SGzovw2SAXevdC0Qw==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student10" },
                    { "544d4acd-9310-4fb9-a6f6-0dfe2673a8f3", 0, 20, "829e9b15-7419-4c30-a05e-44f502868138", "student9@testuniversity.com", true, "Gonzalez", false, null, "James", "STUDENT9@TESTUNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEAo1U56HqE0J7UAX9lB3S7gZmLbBUomYhFCuJ8OQ1xN/tD/hVVhIctgXlO6SOXd73w==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student9" },
                    { "c7c375aa-e0b1-412e-aa2d-de386338ab55", 0, 22, "5a3b95b4-5d77-404b-bead-df63f5c7dc6e", "student8@testuniversity.com", true, "Garcia", false, null, "Daniel", "STUDENT8@TESTUNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEN9Ccx34P9dbjJrvjhAvSsPN6k5nQn+Wcb07XhjjIWqfHJenABHQ+vscZItE9zACeg==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student8" },
                    { "79efe5db-e948-475d-b048-9ba9f76c7601", 0, 19, "7f4c3bda-d9a6-4b51-afd2-0e240e131938", "student6@testuniversity.com", true, "Williams", false, null, "Mark", "STUDENT6@TESTUNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAEI2e4XirWNzCJgupMSEh0ZNzHzT0lPu37LuSP6zK89sduAs3NLmO92OVf+cMeLTgAw==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student6" },
                    { "bde70c9c-e937-4b20-a759-bf29b125e3d6", 0, 22, "936cb600-68df-4eff-91f7-8469afa6cd70", "student5@testuniversity.com", true, "Brown", false, null, "Mike", "STUDENT5@TESTUNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAEDUEt8vjoixf67Ko1qOwBLJQXgM8lenpJeESOb5/568d2J7yFYzrjwIfRUxbD70syw==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student5" },
                    { "a29290e8-c5e4-400a-a45c-d09b6d05ca7c", 0, 21, "6acde338-cc3e-4f1b-b9a6-cdf716861ac8", "student7@testuniversity.com", true, "Rodriguez", false, null, "Paul", "STUDENT7@TESTUNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEGOyhecFjiNzhrKXEIQ153Q3kAgGlA6nT72R4AFV+rFHYalrhZ5bSmY2MfxFGjv+IQ==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student7" },
                    { "42bdbe6a-4684-42a7-91be-4837c80c5cf8", 0, 23, "96809f2d-c429-41d9-b8b3-f265f8bd55e0", "student3@testuniversity.com", true, "Johnson", false, null, "Michael", "STUDENT3@TESTUNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEEnFTdwrVoPhkKJsmsDQ6lQ1gwFrhFy9SrFUCCWjl8O1Xm6W9PER689ImrqmhTc0Vw==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student3" },
                    { "58bfa728-6d50-49c1-a13e-accb82a84dc8", 0, 19, "f11e63b8-cd1d-4c11-b8ef-0758cfd11386", "student2@testuniversity.com", true, "Jones", false, null, "David", "STUDENT2@TESTUNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAELvm/+3UrYLiNgWDl/tc31eTSPQdp8ZX4rEWO0AEeOldTY6/QljkI2+z2mVUNQxN0Q==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student2" },
                    { "067454ff-b104-49b2-9be8-decc5f978c34", 0, 19, "80e2d1cb-8bfa-4d54-b682-f27ae763ea20", "student1@testuniversity.com", true, "Smith", false, null, "John", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEKKSqWwVj5F5Sqia/LLucXMFRgu6ieA4WE7BAbVwsEuDV0QCgdypF6Erq5CXuI2S1g==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student1" },
                    { "52ccc657-0d89-44c0-bb44-115adcd62d19", 0, 0, "a17c7a4f-5326-43ae-8439-d34bccc7ca77", "administrator@testuniversity.com", true, null, false, null, null, "ADMINISTRATOR@TESTUNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEE7Flw/AKxeEL14XUIjXljxVH3Q7HLz9TrUnCU9vYhELa8Nn+suD0t7QgNmNlvLqOQ==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Administrator" },
                    { "f7c792fc-9f75-4d23-8390-fa533ce9d3ca", 0, 18, "6b5b52f0-8b9c-4ffd-9c96-d8430a7b5fea", "student4@testuniversity.com", true, "Lee", false, null, "Chris", "STUDENT4@TESTUNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEIoQuRiwyBXZ/l3vmv4NAlq9UFQ6GOh9ETLqhsH9J6H2JIxWOqXYcQ2cX5zIFl3E2A==", null, false, new DateTime(2020, 3, 18, 14, 14, 4, 959, DateTimeKind.Utc).AddTicks(6687), "", false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 5f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 12f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 15f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 9f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 8f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756), 9f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a33a295-3fcf-45cb-a5a5-a0d448d11012");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6a29138-46aa-41ff-8587-fad0a9bd0cfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "067454ff-b104-49b2-9be8-decc5f978c34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42bdbe6a-4684-42a7-91be-4837c80c5cf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52ccc657-0d89-44c0-bb44-115adcd62d19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "544d4acd-9310-4fb9-a6f6-0dfe2673a8f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58bfa728-6d50-49c1-a13e-accb82a84dc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79efe5db-e948-475d-b048-9ba9f76c7601");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a29290e8-c5e4-400a-a45c-d09b6d05ca7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bde70c9c-e937-4b20-a759-bf29b125e3d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7c375aa-e0b1-412e-aa2d-de386338ab55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e44a6e1b-da0f-4296-999f-1da1d995853a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7c792fc-9f75-4d23-8390-fa533ce9d3ca");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StudyDate",
                table: "CourseSubscribers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5e7bb04-cd0c-4bc1-ad1c-ae81d1903a25", "d6ea8015-72a5-45d0-90bf-95176b019db4", "User", "USER" },
                    { "4aeb7345-08b7-4865-b229-2fbb60075197", "ee3a3922-2ec0-4fe2-b1f6-b2cb1ed3dd94", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8dd6410e-8b01-4b1d-9505-721c843b1caa", 0, 18, "3af72710-9209-438a-b77b-fae0c95c2ef0", "student10@test_university.com", true, "Lopez", false, null, "Maria", "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAEIsG52iA0NdUr+iTV4fIFkHJrxIN8ZJepbGVVuvXCI6c2yF/aoKW+SoJEClEpHoQbw==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student10" },
                    { "309b3531-8d78-4220-8ec8-415634b28d9a", 0, 20, "624b80dc-8b2c-4830-b3c2-ea68387bfb0a", "student9@test_university.com", true, "Gonzalez", false, null, "James", "STUDENT9@TEST_UNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEJLKJDlGIbjdYXhoaP8kvgskK+1vt9LkWgO7iEy/p7bV/xdgrT0/4EnFR8ilNCOR6Q==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student9" },
                    { "3a604780-f8b4-492d-aa87-f3030ccf64dd", 0, 22, "43eb98b6-431d-4aa5-8a0e-6c85f40ef594", "student8@test_university.com", true, "Garcia", false, null, "Daniel", "STUDENT8@TEST_UNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEKBmaTHI2CWhzCA8oH89aMXTd4sFy58eYlMxEDE3go7Id0zRESzZYaIUADzyHZtx2Q==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student8" },
                    { "813208a0-cbd0-4bf5-8f88-95f376338a49", 0, 19, "555878b4-28c6-45c2-b26d-d5d8f3bd9ce8", "student6@test_university.com", true, "Williams", false, null, "Mark", "STUDENT6@TEST_UNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAENz3HDrb9+Rtp+0HfTxz8/P70X3QdxFcjvgszU3f6JUAhLAFlSN5+BNrbKVxgyY5Dg==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student6" },
                    { "f1de004b-1565-4299-a1b1-6a5e6e5da15a", 0, 22, "8ad74724-5552-4bae-a1d7-b65738c22430", "student5@test_university.com", true, "Brown", false, null, "Mike", "STUDENT5@TEST_UNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAEA1E4UontlQalTEbmCO7ubSK4dhDqFa0yf5W3JZjW1d4+ZcZF754UqMVAKRpaPoC5A==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student5" },
                    { "3048b6ea-601b-4ad9-bb50-3e7cc0ef8182", 0, 21, "5a7ff6df-66ba-48f6-bf15-0ffad195a13a", "student7@test_university.com", true, "Rodriguez", false, null, "Paul", "STUDENT7@TEST_UNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEILGmF6knsfpuEZNmqlqmgC4lx7IjejDtk/HJqYeIt+hIfOjywA9R1peq5M2lA7/Fw==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student7" },
                    { "85917a90-2d5f-45b8-bfa3-eb8eea9ed423", 0, 23, "11c0cd1e-55e2-42ca-b0c8-308be1dbf381", "student3@test_university.com", true, "Johnson", false, null, "Michael", "STUDENT3@TEST_UNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEDt5RC1WLzCW9VKEqp8H28ZJU5kOOQ6oi9ST91sNQrDFNVnqb+4yiL+4v0IvyDBEKQ==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student3" },
                    { "b5e962f7-50e3-4b28-a269-f98103b4bdf2", 0, 19, "c6470add-2c3e-417d-a237-ca31a3f39f3f", "student2@test_university.com", true, "Jones", false, null, "David", "STUDENT2@TEST_UNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEKjA3zvmZpaGw0oppxd3g+jLfWEZ5VtjLaKyJMx1NlQK75uSySY0njCvr/a6E6b4EQ==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student2" },
                    { "23379e09-02a5-421a-b74a-2605431a043d", 0, 19, "0e4866e9-3e5d-4aa7-8de2-a77e655b636c", "student1@test_university.com", true, "Smith", false, null, "John", "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEAipshHzbZRLTQRFge9SI/jEXPX0yX+oWlRIMaDT6VXD3hXIvAVcg9iD2EmF2z7FMw==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student1" },
                    { "084e880d-08da-4c05-9a56-d754655d0fb9", 0, 0, "58199d86-e112-4092-9592-70389dc78ca8", "administrator@test_university.com", true, null, false, null, null, "ADMINISTRATOR@TEST_UNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEOIISDH57HTmWFJXsejgySQXi2ENKLDVXWLTNguLwIDFCeZDbqcaxevTNEpjN+1THQ==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Administrator" },
                    { "3f27ea8c-b4ce-49db-b15e-30b89dd6e909", 0, 18, "5892cbe9-fa4c-4f2a-8586-e878bb303e03", "student4@test_university.com", true, "Lee", false, null, "Chris", "STUDENT4@TEST_UNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAECo4n8VtVoJHUG4/dvmAEKHB5DbI1x2V/Nj7O5D3tCsbL68FDTW44NYzF6PsufsFWQ==", null, false, new DateTime(2020, 3, 16, 11, 48, 53, 818, DateTimeKind.Utc).AddTicks(2581), "", false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 1.5f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 2f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 1.5f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 1f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 1.5f });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DateAdded", "Duration" },
                values: new object[] { new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463), 1.5f });
        }
    }
}
