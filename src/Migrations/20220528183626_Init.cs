using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

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
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Data = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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

            migrationBuilder.CreateTable(
                name: "VotePrints",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Votes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VotePrints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VotePrints_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VotePrints_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8e5a649-14f4-428a-87ef-7f8b8c24a030", 0, "7a754759-1df0-4ec7-8d3e-7d8aa53363f2", "admin", true, false, null, null, null, "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c", null, false, "a1f55514-6b5f-4ef1-87f9-0d43c57580a0", false, "Admin Admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4486341b-de86-487e-8f33-7ed134d63205"), new DateTime(2022, 5, 28, 18, 36, 24, 692, DateTimeKind.Utc).AddTicks(9186), "This is a test news description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 1" },
                    { new Guid("e252f6dc-418d-46ef-a7bb-53d8e0129d71"), new DateTime(2022, 5, 28, 18, 36, 24, 693, DateTimeKind.Utc).AddTicks(564), "This is a test news description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 2" },
                    { new Guid("f4034489-3f25-411f-a16c-c08162c9ba59"), new DateTime(2022, 5, 28, 18, 36, 24, 693, DateTimeKind.Utc).AddTicks(648), "This is a test news description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 3" },
                    { new Guid("e3b3892f-64fd-490f-be31-d1f15faf20e7"), new DateTime(2022, 5, 28, 18, 36, 24, 693, DateTimeKind.Utc).AddTicks(683), "This is a test news description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "ModifiedDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("4245a898-4606-4b16-9bdc-4095dd269286"), "Moscow Kremlin st 0", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(2760), "Sample Description 0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("456ba330-8832-4a8f-970d-ffb027c138c8"), "Moscow Kremlin st 19", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6405), "Sample Description 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("c81a82da-b89c-4994-ae9f-188b7e13a234"), "Moscow Kremlin st 18", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6373), "Sample Description 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("9853d08f-3d1e-4eb1-9f7b-98a287ff4472"), "Moscow Kremlin st 17", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6340), "Sample Description 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("1860991a-eab0-4328-b18b-8f6cdef51465"), "Moscow Kremlin st 16", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6305), "Sample Description 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("0522a2c2-3aae-4239-be65-aac569bfa516"), "Moscow Kremlin st 15", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6272), "Sample Description 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("5dbaf0c2-1d05-4d09-905f-ded31addf7a8"), "Moscow Kremlin st 14", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6239), "Sample Description 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("73c712fb-9734-4d38-a966-59e54d3b2aaf"), "Moscow Kremlin st 13", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6205), "Sample Description 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("0b3ca4f8-e81e-4cf2-bc26-5600340ef9d6"), "Moscow Kremlin st 12", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6168), "Sample Description 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("a1117317-7508-4a65-95c1-c7c9d9f3f0c5"), "Moscow Kremlin st 10", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6098), "Sample Description 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("d4713f2d-51ec-463e-8415-75b5e38f4405"), "Moscow Kremlin st 11", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(6135), "Sample Description 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("6edec01d-2663-436d-94cc-a56fb85ac99d"), "Moscow Kremlin st 8", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5947), "Sample Description 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("143af7e7-0125-496d-85b8-7328491a2852"), "Moscow Kremlin st 7", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5914), "Sample Description 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("332fa908-8fc2-41c7-a238-26d32a6516e5"), "Moscow Kremlin st 6", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5881), "Sample Description 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("764d37c3-dd4e-42dd-8068-e22fb53046f5"), "Moscow Kremlin st 5", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5847), "Sample Description 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("2c6038f1-9171-4755-b17c-176a9aa1b49b"), "Moscow Kremlin st 4", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5799), "Sample Description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("38b4404c-3978-4fcd-8e88-c785707c2b95"), "Moscow Kremlin st 3", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5764), "Sample Description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("15d547ac-0386-4da3-98ff-d2e8528bee4e"), "Moscow Kremlin st 2", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5722), "Sample Description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("168615cf-78ed-4659-bdee-377ac58b444d"), "Moscow Kremlin st 1", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5572), "Sample Description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" },
                    { new Guid("f415768e-9197-47bf-9af8-06fb2af6eb27"), "Moscow Kremlin st 9", new DateTime(2022, 5, 28, 18, 36, 24, 691, DateTimeKind.Utc).AddTicks(5982), "Sample Description 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "c8e5a649-14f4-428a-87ef-7f8b8c24a030" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Grade", "ModifiedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("54a0b596-28b1-4659-8f76-492713f03d4f"), new DateTime(2022, 5, 28, 18, 36, 24, 692, DateTimeKind.Utc).AddTicks(4115), "Sample review Description 3", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "c8e5a649-14f4-428a-87ef-7f8b8c24a030", "Admin Admin" },
                    { new Guid("dac50ffa-9203-4443-9134-ffff61153ed3"), new DateTime(2022, 5, 28, 18, 36, 24, 692, DateTimeKind.Utc).AddTicks(1513), "Sample review Description 1", (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "c8e5a649-14f4-428a-87ef-7f8b8c24a030", "Admin Admin" },
                    { new Guid("cb7dac40-057a-4053-9fbe-6db97ce2787a"), new DateTime(2022, 5, 28, 18, 36, 24, 692, DateTimeKind.Utc).AddTicks(3904), "Sample review Description 2", (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "c8e5a649-14f4-428a-87ef-7f8b8c24a030", "Admin Admin" },
                    { new Guid("31edd7a1-e91a-49ed-9a2f-1e0c089a7ca7"), new DateTime(2022, 5, 28, 18, 36, 24, 692, DateTimeKind.Utc).AddTicks(4156), "Sample review Description 4", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "c8e5a649-14f4-428a-87ef-7f8b8c24a030", "Admin Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_VotePrints_ImageId",
                table: "VotePrints",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_VotePrints_UserId",
                table: "VotePrints",
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
                name: "VotePrints");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
