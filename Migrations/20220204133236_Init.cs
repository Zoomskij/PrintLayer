using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Grade = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("a6ea94bf-9441-4a96-af1d-91bcd71e0d6b"), new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(9773), "This is a test news description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 1" },
                    { new Guid("1557a5aa-9162-4598-972a-b484dfbe3e41"), new DateTime(2022, 2, 4, 13, 32, 25, 404, DateTimeKind.Utc).AddTicks(372), "This is a test news description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 2" },
                    { new Guid("f3c285e4-89a8-4b71-8acf-0a5797e71443"), new DateTime(2022, 2, 4, 13, 32, 25, 404, DateTimeKind.Utc).AddTicks(416), "This is a test news description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 3" },
                    { new Guid("a7fe9af6-8b1f-4d5b-8572-7a87b26f9e07"), new DateTime(2022, 2, 4, 13, 32, 25, 404, DateTimeKind.Utc).AddTicks(435), "This is a test news description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 4" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "01b2b81c-50ba-4364-9a06-2c1aaa5338a1", 0, "fac287d1-61e8-49ff-8ad9-3c3040a18ec8", "admin", true, false, null, null, null, "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c", null, false, "a3a2c0fe-3e31-4aee-a2f4-1a3c05fa1de4", false, "Admin Admin" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "ModifiedDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("d79df427-4a10-48e0-9382-ee9132693636"), "Moscow Kremlin st 0", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(1543), "Sample Description 0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("0b3f92fa-e610-408d-8d76-62e08c1d2390"), "Moscow Kremlin st 19", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3461), "Sample Description 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("4a22cef3-d059-422f-af00-a2c9f158e671"), "Moscow Kremlin st 18", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3443), "Sample Description 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("ec78a5af-0ea4-4690-95b8-40c60e801293"), "Moscow Kremlin st 17", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3426), "Sample Description 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("5e2980c6-3866-434c-b958-aa8786fbd476"), "Moscow Kremlin st 16", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3408), "Sample Description 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("b8136ec9-0457-47ff-ac4d-409c84dec7ec"), "Moscow Kremlin st 15", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3391), "Sample Description 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("969db66c-b984-4215-b20b-674bcf7310ec"), "Moscow Kremlin st 14", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3369), "Sample Description 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("4c986f86-2fbe-4904-8e06-5351373533d3"), "Moscow Kremlin st 13", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3323), "Sample Description 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("9f234fd8-15fa-45df-b4f2-503e38832808"), "Moscow Kremlin st 12", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3305), "Sample Description 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("9e17c12e-2bbd-4f18-9c92-842084889de2"), "Moscow Kremlin st 10", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3268), "Sample Description 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("fc413f24-b61f-46c3-8cbb-c144e11d369a"), "Moscow Kremlin st 11", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3286), "Sample Description 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("9d916b83-7c21-49fa-851c-d705ba0dfe8d"), "Moscow Kremlin st 8", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3231), "Sample Description 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("89263206-80d2-4883-bdbe-4ee1f63fc576"), "Moscow Kremlin st 7", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3214), "Sample Description 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("67322e7e-b3c0-43e1-ac73-b75a69b54022"), "Moscow Kremlin st 6", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3196), "Sample Description 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("1ed74ca9-55c4-4971-a126-83909861f303"), "Moscow Kremlin st 5", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3178), "Sample Description 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("1be3af4e-0bb8-4e8f-bc3b-ff4c76cdb384"), "Moscow Kremlin st 4", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3157), "Sample Description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("5ae1121f-d280-4461-8ec5-264c4d3a9460"), "Moscow Kremlin st 3", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3126), "Sample Description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("98f5e8d1-7bdb-442b-84a9-2549202733a3"), "Moscow Kremlin st 2", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3105), "Sample Description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("1e027204-02f9-4ee1-bd70-e714db17a24a"), "Moscow Kremlin st 1", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3027), "Sample Description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" },
                    { new Guid("020c70f0-66a6-48e4-bca1-e0665bea9e8e"), "Moscow Kremlin st 9", new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(3250), "Sample Description 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "01b2b81c-50ba-4364-9a06-2c1aaa5338a1" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Grade", "ModifiedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("bcb8353f-cc02-4593-b648-ceaa92be35d8"), new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(7277), "Sample review Description 3", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "01b2b81c-50ba-4364-9a06-2c1aaa5338a1", "Admin Admin" },
                    { new Guid("a92a42ca-bc29-4985-8e1d-74b4a8dba546"), new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(5995), "Sample review Description 1", (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "01b2b81c-50ba-4364-9a06-2c1aaa5338a1", "Admin Admin" },
                    { new Guid("428c0eb4-adca-410b-8978-698c29acba45"), new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(7182), "Sample review Description 2", (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "01b2b81c-50ba-4364-9a06-2c1aaa5338a1", "Admin Admin" },
                    { new Guid("4d05a212-8afe-4e99-a331-e8bfa0a1c472"), new DateTime(2022, 2, 4, 13, 32, 25, 403, DateTimeKind.Utc).AddTicks(7299), "Sample review Description 4", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "01b2b81c-50ba-4364-9a06-2c1aaa5338a1", "Admin Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
