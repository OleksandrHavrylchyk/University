using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class ChangedSubscribeLogic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13b25c20-4f7d-4bc0-b095-b4243e7d03b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71d2ea2d-37c7-4317-95a2-543dc9f59cc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "154c07e4-a991-4488-9b53-008ea92cc2c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c90ca14-33f1-4319-ae98-05c2c8df6289");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6afb1113-3462-42d6-92be-0b3fe5c6302d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "72cf58e7-8115-4b0a-8560-0ec51077f4d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76f5e330-c804-4b7d-b5df-ddaa29e6c8f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c809388-129f-4ae3-8189-ca67357823ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97a75a27-e980-42a4-90ef-b5e43e9b3dc1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3663c55-d346-412a-a5a1-c40b3a4a5c4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cffedb0c-2989-47b6-943b-c5ac8cbc3199");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d22215c9-91cd-4874-ad88-602bc427d111");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1536f90-c88d-4c1e-982b-c73fa83f45e5");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "StudyDate",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<DateTime>(
                name: "StudyDate",
                table: "CourseSubscribers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2020, 3, 16, 11, 48, 53, 817, DateTimeKind.Utc).AddTicks(3463));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "StudyDate",
                table: "CourseSubscribers");

            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Courses");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StudyDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "71d2ea2d-37c7-4317-95a2-543dc9f59cc0", "5e883516-001d-41b7-95f5-d14b39dcee46", "User", "USER" },
                    { "13b25c20-4f7d-4bc0-b095-b4243e7d03b4", "f5af6e6a-e054-4d58-9bb5-1288d70bf553", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "StudyDate", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "154c07e4-a991-4488-9b53-008ea92cc2c1", 0, 18, "2e80f021-2074-4fbb-bb2c-5795df02bbd4", "student10@test_university.com", true, "Lopez", false, null, "Maria", "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAEEHt3eYaiXrKvvf6AEhmJdjXAlPVwkwWGrt0NgScp67Eo6EUGCPJwdb5VsaUGx1jqA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student10" },
                    { "76f5e330-c804-4b7d-b5df-ddaa29e6c8f0", 0, 20, "c45409d8-d3b1-47f8-95f1-097d21072671", "student9@test_university.com", true, "Gonzalez", false, null, "James", "STUDENT9@TEST_UNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEIhxq4xksA/8fYrryEcZg3DsXHIwmFZOyvBAraW4m7v5E0Yu6qxu05Pjq5QZlAdT1w==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student9" },
                    { "8c809388-129f-4ae3-8189-ca67357823ce", 0, 22, "ec08501a-7aaa-4907-8d85-bb9900cf8c03", "student8@test_university.com", true, "Garcia", false, null, "Daniel", "STUDENT8@TEST_UNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEE2Ks57jOx7eDsfTi5+W+Z3e0B4eUdz6NIvcOYLP21MVApjVC9+KJMDWive4xnFOSA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student8" },
                    { "cffedb0c-2989-47b6-943b-c5ac8cbc3199", 0, 19, "3b33793b-514d-47d4-a7f4-7ab267c5bc51", "student6@test_university.com", true, "Williams", false, null, "Mark", "STUDENT6@TEST_UNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAEH4WeQBvXdQAxlrgPNMZa4XjjJEcViQta1dGJX9910EBUg50i2KMJOFNhOMTvu95lg==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student6" },
                    { "d22215c9-91cd-4874-ad88-602bc427d111", 0, 22, "e29e4dd7-b703-43cd-aa2a-18d9554d977b", "student5@test_university.com", true, "Brown", false, null, "Mike", "STUDENT5@TEST_UNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAEBiIMrMEMAg1Bf8+EFKiYVLC+6T7P9ePFZ86QNtpDomN4YYgTFz7GWZMeQflSNtBYQ==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student5" },
                    { "f1536f90-c88d-4c1e-982b-c73fa83f45e5", 0, 21, "d30f9502-83b4-407d-97a3-58e8595b6f42", "student7@test_university.com", true, "Rodriguez", false, null, "Paul", "STUDENT7@TEST_UNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEKiv1P6/B7xHT6+0H+mhzuyOsRCVZ8m4r6N4EE0BhMhsKtHwh0uDmMKDNjDim7zU/g==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student7" },
                    { "a3663c55-d346-412a-a5a1-c40b3a4a5c4d", 0, 23, "069a7242-310e-46fb-9667-9174ce1b5040", "student3@test_university.com", true, "Johnson", false, null, "Michael", "STUDENT3@TEST_UNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAELcIsOfUeJSdaZF1UB2Et9lTL5ZWWVlXs90JpZfd7nSbTwJCxv9ohil9WP1eUFYrEA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student3" },
                    { "2c90ca14-33f1-4319-ae98-05c2c8df6289", 0, 19, "e2c080cb-2ed7-45f8-b077-89e0f8820610", "student2@test_university.com", true, "Jones", false, null, "David", "STUDENT2@TEST_UNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEAS7oBO6EP1DmL6EAiIf9bK8+J8in9JYsWkJvNO4MULEYfk9iwcFVmBOYciMr4vkkA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student2" },
                    { "97a75a27-e980-42a4-90ef-b5e43e9b3dc1", 0, 19, "e2601378-dd9c-4b56-b2e9-e1f43084e631", "student1@test_university.com", true, "Smith", false, null, "John", "STUDENT1@TEST_UNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEFx171Dv4kn1+5F5qNljmfl6Y4uUxyAxiE7yU9ypqd3JaKAGoI4N2IUrb+HRvDetWg==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student1" },
                    { "72cf58e7-8115-4b0a-8560-0ec51077f4d7", 0, 0, "47ff89c0-b146-4eb5-992e-69d0cc9de3ad", "administrator@test_university.com", true, null, false, null, null, "ADMINISTRATOR@TEST_UNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEGnXGpXdBPPdFkqKRH6/LJKnbfupMQ1HIefhEBkM8q/4VC4+6oEafaKLPAO3PjM+sA==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Administrator" },
                    { "6afb1113-3462-42d6-92be-0b3fe5c6302d", 0, 18, "b70d6ecd-5268-4742-a0f8-59ffa24733bb", "student4@test_university.com", true, "Lee", false, null, "Chris", "STUDENT4@TEST_UNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEFyoED1yYpNYuBhHH9Fh0hrMuqZ61YebXxFJ4HDdhX+xLccOgWuNHULmZxnmiTwP/g==", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 14, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 3, 16, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 18, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 20, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2020, 3, 22, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2020, 3, 24, 2, 57, 59, 819, DateTimeKind.Local).AddTicks(4940));
        }
    }
}
