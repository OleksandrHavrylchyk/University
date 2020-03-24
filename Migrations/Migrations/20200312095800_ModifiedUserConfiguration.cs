using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class ModifiedUserConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
