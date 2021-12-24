using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintLayer.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
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
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0c32f093-abb1-48b8-bb89-c75f484dd8f8", 0, "09d6c264-fe70-42a2-b572-6c0e7c5fee15", "admin", true, false, null, null, null, "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c", null, false, "a1850507-46b4-426d-9b85-be17620bf66b", false, "Admin Admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("e47fc99e-9796-4bfc-b700-76b892e1caed"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(6489), "This is a test news description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 1" },
                    { new Guid("31d7cda3-7f1e-4ebd-83f1-e346f84abdd3"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(7084), "This is a test news description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 2" },
                    { new Guid("710fb015-5a4d-4805-bde7-1d5030ecf950"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(7126), "This is a test news description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 3" },
                    { new Guid("116237d8-5eb3-47a1-81db-1421ac7cb73b"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(7151), "This is a test news description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "ModifiedDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("fb2f0222-8553-4242-9722-a6d6c12b7310"), "Moscow Kremlin st 0", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(7981), "Sample Description 0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("e039b1d0-1d30-4989-ae2d-6606d794e35a"), "Moscow Kremlin st 19", new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(19), "Sample Description 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("15a71a7d-6118-459a-ae6e-8124e7e8677d"), "Moscow Kremlin st 18", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9999), "Sample Description 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("4cea8115-215a-4db9-b323-6d01c6eb0cdd"), "Moscow Kremlin st 17", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9981), "Sample Description 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("3c1a2b8d-447f-4c18-b2f5-2ab7422ebc53"), "Moscow Kremlin st 16", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9961), "Sample Description 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("5e56290c-ef75-4e04-803e-c82866ae91ca"), "Moscow Kremlin st 15", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9942), "Sample Description 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("f04b38af-fbdb-47c7-85f1-688af15a9cff"), "Moscow Kremlin st 14", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9924), "Sample Description 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("ac5f46f7-4841-451f-9ed6-8cf8a16349e9"), "Moscow Kremlin st 13", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9905), "Sample Description 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("c9363010-62de-4f9a-a5fa-7eda997395d7"), "Moscow Kremlin st 12", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9882), "Sample Description 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("5d6e0834-5c05-4fa4-9f0e-753000fcb5fd"), "Moscow Kremlin st 10", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9791), "Sample Description 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("cd9efa5f-11b2-432e-af43-3a2f3872a579"), "Moscow Kremlin st 11", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9812), "Sample Description 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("1327c0da-68de-4b80-870d-bbbff8c1710d"), "Moscow Kremlin st 8", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9751), "Sample Description 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("6606290b-6811-494c-9974-d62cddb440be"), "Moscow Kremlin st 7", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9732), "Sample Description 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("f822e6e8-b5a5-4d4a-9dd0-727e2a267def"), "Moscow Kremlin st 6", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9713), "Sample Description 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("70d96bd6-6333-4e8d-b985-97322b41c292"), "Moscow Kremlin st 5", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9694), "Sample Description 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("ec64890f-b6df-4554-8260-ab88bfce4ffe"), "Moscow Kremlin st 4", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9672), "Sample Description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("45a3da50-d3bd-4c19-a970-f925e8221c0e"), "Moscow Kremlin st 3", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9650), "Sample Description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("5cba18cd-4d71-4fe9-90db-3f410e34af27"), "Moscow Kremlin st 2", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9618), "Sample Description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("56fb7c2c-34ac-40db-9561-6bb3706d3d5f"), "Moscow Kremlin st 1", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9535), "Sample Description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" },
                    { new Guid("ee1bfda5-8179-4b23-a041-c217151814d1"), "Moscow Kremlin st 9", new DateTime(2021, 12, 24, 10, 2, 49, 1, DateTimeKind.Utc).AddTicks(9772), "Sample Description 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0c32f093-abb1-48b8-bb89-c75f484dd8f8" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Grade", "ModifiedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("515e4da6-3746-469f-b735-fcf9bf521b0a"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(3967), "Sample review Description 3", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0c32f093-abb1-48b8-bb89-c75f484dd8f8", "Admin Admin" },
                    { new Guid("c128e968-1e51-4268-9148-4217c25482ec"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(2450), "Sample review Description 1", (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0c32f093-abb1-48b8-bb89-c75f484dd8f8", "Admin Admin" },
                    { new Guid("4beee834-d716-4674-bfd7-c05bc0cae3e2"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(3864), "Sample review Description 2", (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0c32f093-abb1-48b8-bb89-c75f484dd8f8", "Admin Admin" },
                    { new Guid("48d7f120-6383-4849-ba16-b01168f652a1"), new DateTime(2021, 12, 24, 10, 2, 49, 2, DateTimeKind.Utc).AddTicks(3992), "Sample review Description 4", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0c32f093-abb1-48b8-bb89-c75f484dd8f8", "Admin Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
