using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class AdminSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "687dbc2c-be45-492a-9a32-7cee9f33ebb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7bebb78-de19-4f50-967c-fe7139eb0b6d");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "c7bebb78-de19-4f50-967c-fe7139eb0b6d", "239270ba-f0a4-4100-8226-2269217d65c9", "User", "USER" },
                    { "687dbc2c-be45-492a-9a32-7cee9f33ebb4", "8d55602f-3305-456c-abd3-ccb5e8859f7f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 7, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 3, 9, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 11, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 13, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                column: "StartDate",
                value: new DateTime(2020, 3, 15, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                column: "StartDate",
                value: new DateTime(2020, 3, 17, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022));
        }
    }
}
