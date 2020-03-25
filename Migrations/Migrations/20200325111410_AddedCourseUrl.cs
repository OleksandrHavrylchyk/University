using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class AddedCourseUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "CourseUrl",
                table: "Courses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03b5f7c0-3045-42cb-9837-30e5a5847c1c", "9262dfa2-87af-4ce7-8138-9bef5757db27", "User", "USER" },
                    { "0c9bebb8-6d1e-47b8-a606-1c41b6044447", "ae1ed0ef-459b-4054-987f-6bddebd64074", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fddcaf22-0bb6-4946-aad5-3f1284abc023", 0, 18, "e184a92a-8f89-4343-b515-3a4682675377", "student10@testuniversity.com", true, "Lopez", false, null, "Maria", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAEMG7xknkPKG/kumpu4tF0bXSVnwP5mHvU0LpZ93UaWvqjEPQK3smfF7seROILEGkFA==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student10" },
                    { "9d06e32d-4a49-4897-bc3c-404bad6a1b7d", 0, 20, "22532c0c-bd12-4a3d-ad1c-76def482207a", "student9@testuniversity.com", true, "Gonzalez", false, null, "James", "STUDENT9@TESTUNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEKPNj/laSskr++ai4YH6LKr1cZP6EdlFW5/ZQj69j1FY0RlFY3sfuoqbvjpYeS2qKg==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student9" },
                    { "71dd7ee3-a7f9-4d38-be45-bf4d38591e55", 0, 22, "54f829a7-4285-48c8-ba9a-8c0e3d7831e1", "student8@testuniversity.com", true, "Garcia", false, null, "Daniel", "STUDENT8@TESTUNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEFbzvnqZ3sDObq5sZrYsq30lnxvt0HXQk7iioEItiWn9Gwl4aaa6jRnyJuR1oKMhVQ==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student8" },
                    { "69dbe69c-6805-453f-88c1-307b1a084d91", 0, 19, "62ecc405-15c4-43ee-9b86-740cc82494b7", "student6@testuniversity.com", true, "Williams", false, null, "Mark", "STUDENT6@TESTUNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAEFerSNCon85D36rucYWl2Y8Smuk2Q0IBoKZZT6igqYgpIlcCnueOdkKjmDig+3tIgA==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student6" },
                    { "58921adc-558b-4f2e-b88d-9750a91c827d", 0, 22, "c58371f9-6b37-40ef-b941-ef394a021c8d", "student5@testuniversity.com", true, "Brown", false, null, "Mike", "STUDENT5@TESTUNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAELVRZW1ZV2nxakKlla9aFaVVhvKhwWOqGm9dviWJG3SvSYMQYU1uccusxETTncbtGw==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student5" },
                    { "e7f25b63-3f6b-4f8d-9f73-c3d46034623b", 0, 21, "d63abd54-3276-4d79-877a-cabb4fffada0", "student7@testuniversity.com", true, "Rodriguez", false, null, "Paul", "STUDENT7@TESTUNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAELEyg97ntcCRFcQ9M/bXwNrGCso6WycOyjAPq1yOLDzr4HWGbK90AW0ceJ8str2ppw==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student7" },
                    { "0d653369-2545-4161-a957-b529d1081e90", 0, 23, "b9048634-b3af-472a-9ba7-ec77b0a499c9", "student3@testuniversity.com", true, "Johnson", false, null, "Michael", "STUDENT3@TESTUNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEKNCj9MyALqcZHcpLkArNo5iEdD8ffFKoq0ZAUms006nGKjWf6ArV4Hl/gZV68UkQA==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student3" },
                    { "a3bbcb10-13e8-47e0-9cdb-36d57ab44b02", 0, 19, "85bf08e9-0cec-4c9c-aca9-270606baa033", "student2@testuniversity.com", true, "Jones", false, null, "David", "STUDENT2@TESTUNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEN8meUo00UIU0vARSORDNtoyyXpH7wtgl7AycuKEYzgD1WLh7beiIbMKaeZwhD/pOQ==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student2" },
                    { "e841bc12-bb82-4c1c-a229-b585467b90f8", 0, 19, "cd35e37a-b78e-45e4-aece-83476acb5764", "student1@testuniversity.com", true, "Smith", false, null, "John", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAECggzoW7QAOrJwN2+C9sQPdzyRrKrgSraEtLaCYWADWUPqUDAFtu39YTg8cazjbINA==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student1" },
                    { "5fcf59d1-6377-4875-b6b6-abd6f117c343", 0, 0, "d6cb5643-242e-4ab8-bff1-009fae5b9bfc", "administrator@testuniversity.com", true, null, false, null, null, "ADMINISTRATOR@TESTUNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEOaMzKcpcHoM+iI+czalSpSe/ahRApHe4fUtVBtsTUjZKZsORTssJJRZgHQD4YwAvg==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Administrator" },
                    { "baba9cd9-baa7-443b-a8c5-5a6b4da56b68", 0, 18, "17bccc95-dc80-43fd-a65f-cde0ecfe0a57", "student4@testuniversity.com", true, "Lee", false, null, "Chris", "STUDENT4@TESTUNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEDrHHon40bwt9ilvzpaq1GVMhsLmi3sk37S6Ro5GU4/HVVORuoo6oAJS3A7roikh3A==", null, false, new DateTime(2020, 3, 25, 11, 14, 9, 638, DateTimeKind.Utc).AddTicks(9103), "", false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "geomentry_and_trygonometry_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "art_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "english_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "programming_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "history_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "chemistry_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03b5f7c0-3045-42cb-9837-30e5a5847c1c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0c9bebb8-6d1e-47b8-a606-1c41b6044447");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d653369-2545-4161-a957-b529d1081e90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58921adc-558b-4f2e-b88d-9750a91c827d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fcf59d1-6377-4875-b6b6-abd6f117c343");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69dbe69c-6805-453f-88c1-307b1a084d91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "71dd7ee3-a7f9-4d38-be45-bf4d38591e55");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d06e32d-4a49-4897-bc3c-404bad6a1b7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3bbcb10-13e8-47e0-9cdb-36d57ab44b02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "baba9cd9-baa7-443b-a8c5-5a6b4da56b68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7f25b63-3f6b-4f8d-9f73-c3d46034623b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e841bc12-bb82-4c1c-a229-b585467b90f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddcaf22-0bb6-4946-aad5-3f1284abc023");

            migrationBuilder.DropColumn(
                name: "CourseUrl",
                table: "Courses");

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
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2020, 3, 18, 14, 14, 4, 958, DateTimeKind.Utc).AddTicks(7756));
        }
    }
}
