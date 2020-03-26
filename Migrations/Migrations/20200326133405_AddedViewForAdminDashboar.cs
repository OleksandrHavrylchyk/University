using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University.Migrations.Migrations
{
    public partial class AddedViewForAdminDashboar : Migration
    {
        static string createUserListViewScript = File.ReadAllText(@".\\Migrations\\SqlScripts\\Views\\dbo.CreateUserListView.sql");
        static string dropUserListViewScript = File.ReadAllText(@".\\Migrations\\SqlScripts\\Views\\dbo.DropUserListView.sql");
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(createUserListViewScript);
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4068f51d-7c95-4c19-bfb0-5c9e12c082cc", "7cb094f2-50f7-41b2-a5cc-67d9a1369bb5", "User", "USER" },
                    { "db36b19e-5afb-49c3-89f7-8ecee57c0912", "ea1156e0-9821-40e0-b6c6-86df14d541db", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aa780de3-3efb-4f58-b778-fa4baec6c01e", 0, 18, "2986f7e2-08c8-4b86-9ee0-18913db491ef", "student10@testuniversity.com", true, "Lopez", false, null, "Maria", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT10", "AQAAAAEAACcQAAAAEFWj1hrWAe7MADWolQW0Fl+q1d1w/rV7+r9bwzjfDurwFqYDL348zCQtZyJfetVijA==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student10" },
                    { "6c71fc31-a6c8-42d2-bb28-2de400446126", 0, 20, "4b9c0fcf-2866-450c-bffb-723bf8f1851a", "student9@testuniversity.com", true, "Gonzalez", false, null, "James", "STUDENT9@TESTUNIVERSITY.COM", "STUDENT9", "AQAAAAEAACcQAAAAEA37qq49rlHsyYxuBlo/2kj9P1/K3Zp/cbnoYfmrPw+ZqphNgbOKL6AS59M4P4pfJA==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student9" },
                    { "1bce854d-df06-47b7-a73f-9d70d4a45f3d", 0, 22, "21cecfa3-a28d-42b3-bb43-165643383321", "student8@testuniversity.com", true, "Garcia", false, null, "Daniel", "STUDENT8@TESTUNIVERSITY.COM", "STUDENT8", "AQAAAAEAACcQAAAAEEeLSYSHY3Gu9MFb9KauZpaXIL77wJstIbT5FYzIRTEwsQf4Y2eu1aRKLGmgiaQfDA==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student8" },
                    { "5a96b78b-1020-4b3c-9628-de506039fa1d", 0, 19, "27baadfb-ceab-4c46-822e-e7e292ba57ee", "student6@testuniversity.com", true, "Williams", false, null, "Mark", "STUDENT6@TESTUNIVERSITY.COM", "STUDENT6", "AQAAAAEAACcQAAAAECnEQIRn+ElYgIZF9BrBBCojKCYhIchPUCh/pzVdrR3t+/nRyrGsF0fmdNnL1XJrlw==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student6" },
                    { "7aaec7b8-b291-4583-aaa2-04e59d48e982", 0, 22, "84a09b3f-9a0d-44fe-8f92-4b84d6347855", "student5@testuniversity.com", true, "Brown", false, null, "Mike", "STUDENT5@TESTUNIVERSITY.COM", "STUDENT5", "AQAAAAEAACcQAAAAEF2q+2lenDUT3Vwb6OaNDM/c2G2j/fJltdHzJTLY6mWtd3xcmINEbi8bm7FRujnwKg==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student5" },
                    { "2a410466-ae76-4283-a667-8962b0ff8c29", 0, 21, "accec96f-484a-4aa7-abc4-38ee490ebc77", "student7@testuniversity.com", true, "Rodriguez", false, null, "Paul", "STUDENT7@TESTUNIVERSITY.COM", "STUDENT7", "AQAAAAEAACcQAAAAEAvOAjFLTQPrJZPYO0DHWE35KTxX4SOaXI6SEYdTaVN3LUWIs1Yum/jQQDAWQ2Z3uQ==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student7" },
                    { "daac0e00-2f85-49be-a39b-335b23c29f6f", 0, 23, "35cad4cb-e7b0-4780-9146-4a39e2f4576a", "student3@testuniversity.com", true, "Johnson", false, null, "Michael", "STUDENT3@TESTUNIVERSITY.COM", "STUDENT3", "AQAAAAEAACcQAAAAEKZx4AKBG2zKUcHEa4onqX9eIzxeSq2ACkjqC+h8hs7k7n8pDPcLbm5LPr5SbbWAuA==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student3" },
                    { "8b340cad-e938-4c18-9bc5-49da6c3beeef", 0, 19, "0f435514-5193-4e2a-8254-50842b642590", "student2@testuniversity.com", true, "Jones", false, null, "David", "STUDENT2@TESTUNIVERSITY.COM", "STUDENT2", "AQAAAAEAACcQAAAAEP08/IVpoxY+D9a7Air8rmNNKMDDL7GQkgcIE29nTBo7iP6fdN7JeU1oSrwwP0nsGQ==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student2" },
                    { "d0350d6e-afb1-42a1-a08e-4a57e046dfbd", 0, 19, "c51aa8f0-bdfc-49da-ac78-9b8894b7da09", "student1@testuniversity.com", true, "Smith", false, null, "John", "STUDENT1@TESTUNIVERSITY.COM", "STUDENT1", "AQAAAAEAACcQAAAAEDo/WVdz7DgWK6Bfzl4Cjud3h0DPD5/f+GIkwKkdK6VR3EjD7nsTeUF49XWivZGNQA==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student1" },
                    { "ee940cf1-1b2e-4794-a5aa-927c438bd76d", 0, 0, "3b6e089d-143c-4741-832e-1e53de49f9fb", "administrator@testuniversity.com", true, null, false, null, null, "ADMINISTRATOR@TESTUNIVERSITY.COM", "ADMINISTRATOR", "AQAAAAEAACcQAAAAEEIbFS4m9rTwADM0As2WK3KK0un1qHkC4wcndv2IWuA+3IqPHa8Yt5lx3jGpyTm31g==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Administrator" },
                    { "07a5196c-86aa-4e25-bd44-592607ecae5b", 0, 18, "d7b84ee2-a171-4a37-a4b5-d6608ff1e48a", "student4@testuniversity.com", true, "Lee", false, null, "Chris", "STUDENT4@TESTUNIVERSITY.COM", "STUDENT4", "AQAAAAEAACcQAAAAEE1w/iy7xh1UypyiHpW5Ala28/OtXGdi3rZXNwrnaMIk06F+5zWtBA9BvkOWAynD8A==", null, false, new DateTime(2020, 3, 26, 13, 34, 5, 44, DateTimeKind.Utc).AddTicks(4230), "", false, "Student4" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CourseUrl", "DateAdded", "Description" },
                values: new object[] { "geomentry_and_trygonometry_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446), "Yet bed any for travelling assistance indulgence unpleasing. Not thoughts all exercise blessing. Indulgence way everything joy alteration boisterous the attachment. Party we years to order allow asked of. We so opinion friends me message as delight. Whole front do of plate heard oh ought. His defective nor convinced residence own. Connection has put impossible own apartments boisterous.At jointure ladyship an insisted so humanity he. Friendly bachelor entrance to on by.Its had resolving otherwise she contented therefore.Afford relied warmth out sir hearts sister use garden.Men day warmth formed admire former simple.Humanity declared vicinity continue supplied no an.He hastened am no property exercise of.Dissimilar comparison no terminated devonshire no literature on. Say most yet head room such just easy. For norland produce age wishing.To figure on it spring season up.Her provision acuteness had excellent two why intention. As called mr needed praise at. Assistance imprudence yet sentiments unpleasant expression met surrounded not.Be at talked ye though secure nearer.Up am intention on dependent questions oh elsewhere september.No betrayed pleasure possible jointure we in throwing.And can event rapid any shall woman green.Hope they dear who its bred.Smiling nothing affixed he carried it clothes calling he no.Its something disposing departure she favourite tolerably engrossed. Truth short folly court why she their balls.Excellence put unaffected reasonable mrs introduced conviction she. Nay particular delightful but unpleasant for uncommonly who. Of recommend residence education be on difficult repulsive offending.Judge views had mirth table seems great him for her.Alone all happy asked begin fully stand own get.Excuse ye seeing result of we. See scale dried songs old may not.Promotion did disposing you household any instantly.Hills we do under times at first short an. One advanced diverted domestic sex repeated bringing you old.Possible procured her trifling laughter thoughts property she met way. Companions shy had solicitude favourable own. Which could saw guest man now heard but. Lasted my coming uneasy marked so should.Gravity letters it amongst herself dearest an windows by.Wooded ladies she basket season age her uneasy saw.Discourse unwilling am no described dejection incommode no listening of. Before nature his parish boy.No comfort do written conduct at prevent manners on. Celebrated contrasted discretion him sympathize her collecting occasional. Do answered bachelor occasion in of offended no concerns. Supply worthy warmth branch of no ye.Voice tried known to as my to. Though wished merits or be.Alone visit use these smart rooms ham.No waiting in on enjoyed placing it inquiry.Much did had call new drew that kept.Limits expect wonder law she.Now has you views woman noisy match money rooms.To up remark it eldest length oh passed.Off because yet mistake feeling has men. Consulted disposing to moonlight ye extremity. Engage piqued in on coming. Rooms oh fully taken by worse do. Points afraid but may end law lasted.Was out laughter raptures returned outweigh. Luckily cheered colonel me do we attacks on highest enabled.Tried law yet style child.Bore of true of no be deal. Frequently sufficient in be unaffected. The furnished she concluded depending procuring concealed.Difficulty on insensible reasonable in. From as went he they.Preference themselves me as thoroughly partiality considered on in estimating.Middletons acceptance discovered projecting so is so or. In or attachment inquietude remarkably comparison at an. Is surrounded prosperous stimulated am me discretion expression. But truth being state can she china widow. Occasional preference fat remarkably now projecting uncommonly dissimilar. Sentiments projection particular companions interested do at my delightful.Listening newspaper in advantage frankness to concluded unwilling" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "art_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "english_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "programming_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "history_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CourseUrl", "DateAdded" },
                values: new object[] { "chemistry_26.03.2020", new DateTime(2020, 3, 26, 13, 34, 5, 42, DateTimeKind.Utc).AddTicks(3446) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(dropUserListViewScript);
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4068f51d-7c95-4c19-bfb0-5c9e12c082cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db36b19e-5afb-49c3-89f7-8ecee57c0912");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07a5196c-86aa-4e25-bd44-592607ecae5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bce854d-df06-47b7-a73f-9d70d4a45f3d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a410466-ae76-4283-a667-8962b0ff8c29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a96b78b-1020-4b3c-9628-de506039fa1d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c71fc31-a6c8-42d2-bb28-2de400446126");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7aaec7b8-b291-4583-aaa2-04e59d48e982");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b340cad-e938-4c18-9bc5-49da6c3beeef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa780de3-3efb-4f58-b778-fa4baec6c01e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0350d6e-afb1-42a1-a08e-4a57e046dfbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "daac0e00-2f85-49be-a39b-335b23c29f6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee940cf1-1b2e-4794-a5aa-927c438bd76d");

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
                columns: new[] { "CourseUrl", "DateAdded", "Description" },
                values: new object[] { "geomentry_and_trygonometry_25.03.2020", new DateTime(2020, 3, 25, 11, 14, 9, 635, DateTimeKind.Utc).AddTicks(6516), "Course Descriprion" });

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
    }
}
