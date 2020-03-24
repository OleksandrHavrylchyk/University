using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class SeedingCourses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "467c2b84-c8fc-4dbb-92ac-2c6a999edcfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4b7774c-6712-414a-8676-7ef8613092c3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7bebb78-de19-4f50-967c-fe7139eb0b6d", "239270ba-f0a4-4100-8226-2269217d65c9", "User", "USER" },
                    { "687dbc2c-be45-492a-9a32-7cee9f33ebb4", "8d55602f-3305-456c-abd3-ccb5e8859f7f", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "CourseName", "CoverUrl", "Description", "Duration", "StartDate" },
                values: new object[,]
                {
                    { 1, "Geometry and Trygonometry", "https://cdn01.alison-static.net/courses/1819/alison_courseware_intro_1819.jpg", "Course Descriprion", 1.5f, new DateTime(2020, 3, 7, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) },
                    { 2, "Art", "https://news.artnet.com/app/news-upload/2019/12/5db820a075ba3-1500x826.jpg", "Course Descriprion", 2f, new DateTime(2020, 3, 9, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) },
                    { 3, "English", "https://ichef.bbci.co.uk/images/ic/640x360/p03zh5tk.jpg", "Course Descriprion", 1.5f, new DateTime(2020, 3, 11, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) },
                    { 4, "Programming", "https://prod-discovery.edx-cdn.org/media/course/image/d64fa565-a848-4f82-8c07-f2a2d98c3e4e-1cf577279324.small.jpeg", "Course Descriprion", 1f, new DateTime(2020, 3, 13, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) },
                    { 5, "History", "https://www.thegreatcourses.com/media/catalog/product/cache/1/plus_image/800x451/0f396e8a55728e79b48334e699243c07/8/0/8080.1551362662.jpg", "Course Descriprion", 1.5f, new DateTime(2020, 3, 15, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) },
                    { 6, "Chemistry", "https://www.scitecheuropa.eu/wp-content/uploads/2018/06/ST27-McGillU1-image-%C2%A9-iStock-Garsya.jpg", "Course Descriprion", 1.5f, new DateTime(2020, 3, 17, 6, 12, 44, 109, DateTimeKind.Local).AddTicks(7022) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "687dbc2c-be45-492a-9a32-7cee9f33ebb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7bebb78-de19-4f50-967c-fe7139eb0b6d");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "467c2b84-c8fc-4dbb-92ac-2c6a999edcfa", "1b4e88cc-d406-429a-b7d4-4213a5b0b159", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a4b7774c-6712-414a-8676-7ef8613092c3", "26795bf5-465b-49d0-8278-5d8506b17909", "Administrator", "ADMINISTRATOR" });
        }
    }
}
