using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintLayer.Migrations
{
    public partial class VotePrintContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("37c53a1f-285b-4014-9885-ef5ad71ba7be"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("65db5fe0-9bd6-4a55-a7ba-05c69de56448"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("6a422299-022a-46bb-8841-97495a12a1f0"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e1cf271e-a19b-4b06-8c60-b3bd6be937bc"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1054bb35-06e2-4acd-a89c-02c91476cc2a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("10dde664-3c3b-4975-8f0a-0e10bfead574"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1181a275-2db2-4246-987d-610087e4db03"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("20d799f2-60ea-4b3e-9b95-5b345982993a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5690ad1e-0fb1-4cbe-99bb-7ac68db03e45"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6843ab1d-030c-434e-b3b7-101320607800"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("79f5570b-7d4b-4cad-aeec-0583b8aca7a4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("7d0a9203-6091-45fa-a04c-cb42aed683a7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("80d9f28e-a045-4b5f-b4f1-faaa4818a59b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("987541f2-641c-451b-97d9-c7d847ff1d63"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9f273644-40ae-4c75-96d5-90c8d65d0b9b"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a3a8f511-9824-4ba6-a9f4-a8a395c678e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4af7b95-6d81-43b5-bd1a-ae16975747f5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b91a9fc4-4305-4b30-b85c-6cc53a019df6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("caead71d-8e4e-4560-8eab-df40eb8d58b5"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("de922c6a-4dc8-4923-8fd3-9c275ec6e9ea"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e28bb77c-d1ac-4f4e-b95e-a510ed4cfb8d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e635733f-0d01-42e4-ae60-cdca1231cb0e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("efeb9587-c07a-44ca-bbf3-3967ba964831"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f3ffe41e-80b2-4d14-bb7b-c733d664b30f"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("471d313d-bfaa-4327-8686-eab7f73c5eee"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("7e4494ab-4d74-447a-bcab-fd322e036a1c"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("83b7f926-d06a-42b9-967b-8ed5e08f912e"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("dc71cf95-91f9-4fb0-9787-7e8838730b78"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8e05b50-4df5-45e5-b5cf-671869c40dd2");

            migrationBuilder.CreateTable(
                name: "Image",
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
                    table.PrimaryKey("PK_Image", x => x.Id);
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
                        name: "FK_VotePrints_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
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
                values: new object[] { "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc", 0, "80fbd119-61c5-45b5-8d32-94e61520e72b", "admin", true, false, null, null, null, "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c", null, false, "e7b93b65-0afd-4d83-88a0-22fc35f0b9ec", false, "Admin Admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("4df0e149-a7f1-4bbc-9dce-1474229b1ddd"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(3020), "This is a test news description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 1" },
                    { new Guid("9ec66680-79b2-4344-be7e-03306ab60c8a"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(3645), "This is a test news description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 2" },
                    { new Guid("5cf1c284-6dd8-4cdd-bf79-9b6a9ce39f48"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(3695), "This is a test news description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 3" },
                    { new Guid("2016463b-3433-4700-b768-ff128962ec9e"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(3716), "This is a test news description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "ModifiedDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("9ae88a2e-0b07-4f6e-9142-ccba0ced0a31"), "Moscow Kremlin st 0", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(4365), "Sample Description 0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("b0ff37b2-32a2-47c0-9b2c-0f2f89ca2a65"), "Moscow Kremlin st 19", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6436), "Sample Description 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("64d3e54e-ef32-4dfc-868b-42f8a268f72d"), "Moscow Kremlin st 18", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6416), "Sample Description 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("b4d3dbfb-bee0-42ff-bcf8-05aed26d3db8"), "Moscow Kremlin st 17", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6345), "Sample Description 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("51438859-a30f-42bb-a01a-98433575810c"), "Moscow Kremlin st 16", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6324), "Sample Description 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("8e121cb4-8a71-4939-8a5e-2eadb0632866"), "Moscow Kremlin st 15", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6304), "Sample Description 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("234f466a-896f-4a35-b131-d316469009e0"), "Moscow Kremlin st 14", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6284), "Sample Description 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("eefb2b5e-6ee9-4165-a813-a8ab4ba20dbd"), "Moscow Kremlin st 13", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6265), "Sample Description 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("e50ead8a-38e4-4b98-858f-ce7e2704f25c"), "Moscow Kremlin st 12", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6244), "Sample Description 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("15ff7c21-f02f-4321-b51e-f07707d89fd9"), "Moscow Kremlin st 10", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6201), "Sample Description 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("a4d50b0e-b4f7-4284-addd-e72806102cba"), "Moscow Kremlin st 11", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6222), "Sample Description 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("44e005c6-feb8-495f-8eff-3764680d59eb"), "Moscow Kremlin st 8", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6160), "Sample Description 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("c827c81f-3802-4f4d-95fd-c47f8ea4c3b8"), "Moscow Kremlin st 7", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6140), "Sample Description 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("b7b7c762-0c07-494a-bafc-38101fc06d3a"), "Moscow Kremlin st 6", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6119), "Sample Description 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("739d8a59-a5a5-4549-a122-21bc9389bde4"), "Moscow Kremlin st 5", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6098), "Sample Description 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("b791b594-cd0b-4410-a4d3-b5a91fed75b6"), "Moscow Kremlin st 4", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6073), "Sample Description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("2ae6a3d2-7ddb-435d-adae-1a33766dd94f"), "Moscow Kremlin st 3", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6037), "Sample Description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("e61a37cb-eff1-445c-93b7-07560861e614"), "Moscow Kremlin st 2", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(5971), "Sample Description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("fb94dc37-22d1-47c6-b0f6-315562239ad2"), "Moscow Kremlin st 1", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(5886), "Sample Description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" },
                    { new Guid("498af4f0-fb52-4a2c-adb5-a3ac53170a33"), "Moscow Kremlin st 9", new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(6182), "Sample Description 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Grade", "ModifiedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("3c0498ee-f835-409a-8056-db2b2e76ef53"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(391), "Sample review Description 3", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc", "Admin Admin" },
                    { new Guid("74ea8762-6ea7-4e0d-a4c4-89d1c4e9bc63"), new DateTime(2022, 3, 5, 11, 15, 41, 798, DateTimeKind.Utc).AddTicks(9077), "Sample review Description 1", (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc", "Admin Admin" },
                    { new Guid("96661908-dc34-463a-920c-372d5fb2c884"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(281), "Sample review Description 2", (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc", "Admin Admin" },
                    { new Guid("60cca17e-fc3f-429a-9a5f-df050ddfaa82"), new DateTime(2022, 3, 5, 11, 15, 41, 799, DateTimeKind.Utc).AddTicks(416), "Sample review Description 4", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc", "Admin Admin" }
                });

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
                name: "VotePrints");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("2016463b-3433-4700-b768-ff128962ec9e"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("4df0e149-a7f1-4bbc-9dce-1474229b1ddd"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("5cf1c284-6dd8-4cdd-bf79-9b6a9ce39f48"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("9ec66680-79b2-4344-be7e-03306ab60c8a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15ff7c21-f02f-4321-b51e-f07707d89fd9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("234f466a-896f-4a35-b131-d316469009e0"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("2ae6a3d2-7ddb-435d-adae-1a33766dd94f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("44e005c6-feb8-495f-8eff-3764680d59eb"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("498af4f0-fb52-4a2c-adb5-a3ac53170a33"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51438859-a30f-42bb-a01a-98433575810c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("64d3e54e-ef32-4dfc-868b-42f8a268f72d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("739d8a59-a5a5-4549-a122-21bc9389bde4"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8e121cb4-8a71-4939-8a5e-2eadb0632866"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("9ae88a2e-0b07-4f6e-9142-ccba0ced0a31"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("a4d50b0e-b4f7-4284-addd-e72806102cba"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b0ff37b2-32a2-47c0-9b2c-0f2f89ca2a65"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b4d3dbfb-bee0-42ff-bcf8-05aed26d3db8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b791b594-cd0b-4410-a4d3-b5a91fed75b6"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("b7b7c762-0c07-494a-bafc-38101fc06d3a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c827c81f-3802-4f4d-95fd-c47f8ea4c3b8"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e50ead8a-38e4-4b98-858f-ce7e2704f25c"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e61a37cb-eff1-445c-93b7-07560861e614"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("eefb2b5e-6ee9-4165-a813-a8ab4ba20dbd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fb94dc37-22d1-47c6-b0f6-315562239ad2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3c0498ee-f835-409a-8056-db2b2e76ef53"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("60cca17e-fc3f-429a-9a5f-df050ddfaa82"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("74ea8762-6ea7-4e0d-a4c4-89d1c4e9bc63"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("96661908-dc34-463a-920c-372d5fb2c884"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fc161d3-2f3d-40e5-bf6b-a712b7fce3bc");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8e05b50-4df5-45e5-b5cf-671869c40dd2", 0, "9ac860ca-c9ac-4220-bac4-2768043ee457", "admin", true, false, null, null, null, "a322b9c0b8e19ef16d4d308cd4e1222106d0edf8fbb3c8f1649242dff54a740c", null, false, "e3018a85-59f9-40a3-8494-5f907f12cc86", false, "Admin Admin" });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("65db5fe0-9bd6-4a55-a7ba-05c69de56448"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(3173), "This is a test news description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 1" },
                    { new Guid("6a422299-022a-46bb-8841-97495a12a1f0"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(3800), "This is a test news description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 2" },
                    { new Guid("37c53a1f-285b-4014-9885-ef5ad71ba7be"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(3849), "This is a test news description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 3" },
                    { new Guid("e1cf271e-a19b-4b06-8c60-b3bd6be937bc"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(3872), "This is a test news description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Test Name 4" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "CreatedDate", "Description", "ModifiedDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { new Guid("10dde664-3c3b-4975-8f0a-0e10bfead574"), "Moscow Kremlin st 0", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(4528), "Sample Description 0", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("a4af7b95-6d81-43b5-bd1a-ae16975747f5"), "Moscow Kremlin st 19", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6529), "Sample Description 19", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("9f273644-40ae-4c75-96d5-90c8d65d0b9b"), "Moscow Kremlin st 18", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6510), "Sample Description 18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("b91a9fc4-4305-4b30-b85c-6cc53a019df6"), "Moscow Kremlin st 17", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6486), "Sample Description 17", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("f3ffe41e-80b2-4d14-bb7b-c733d664b30f"), "Moscow Kremlin st 16", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6421), "Sample Description 16", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("79f5570b-7d4b-4cad-aeec-0583b8aca7a4"), "Moscow Kremlin st 15", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6402), "Sample Description 15", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("5690ad1e-0fb1-4cbe-99bb-7ac68db03e45"), "Moscow Kremlin st 14", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6382), "Sample Description 14", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("20d799f2-60ea-4b3e-9b95-5b345982993a"), "Moscow Kremlin st 13", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6362), "Sample Description 13", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("e635733f-0d01-42e4-ae60-cdca1231cb0e"), "Moscow Kremlin st 12", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6339), "Sample Description 12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("a3a8f511-9824-4ba6-a9f4-a8a395c678e0"), "Moscow Kremlin st 10", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6299), "Sample Description 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("efeb9587-c07a-44ca-bbf3-3967ba964831"), "Moscow Kremlin st 11", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6319), "Sample Description 11", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("6843ab1d-030c-434e-b3b7-101320607800"), "Moscow Kremlin st 8", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6258), "Sample Description 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("7d0a9203-6091-45fa-a04c-cb42aed683a7"), "Moscow Kremlin st 7", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6239), "Sample Description 7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("e28bb77c-d1ac-4f4e-b95e-a510ed4cfb8d"), "Moscow Kremlin st 6", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6219), "Sample Description 6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("987541f2-641c-451b-97d9-c7d847ff1d63"), "Moscow Kremlin st 5", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6198), "Sample Description 5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("caead71d-8e4e-4560-8eab-df40eb8d58b5"), "Moscow Kremlin st 4", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6170), "Sample Description 4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("80d9f28e-a045-4b5f-b4f1-faaa4818a59b"), "Moscow Kremlin st 3", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6149), "Sample Description 3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("de922c6a-4dc8-4923-8fd3-9c275ec6e9ea"), "Moscow Kremlin st 2", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6120), "Sample Description 2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("1054bb35-06e2-4acd-a89c-02c91476cc2a"), "Moscow Kremlin st 1", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(5997), "Sample Description 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" },
                    { new Guid("1181a275-2db2-4246-987d-610087e4db03"), "Moscow Kremlin st 9", new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(6279), "Sample Description 9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "+71234567890", 1, "b8e05b50-4df5-45e5-b5cf-671869c40dd2" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedDate", "Description", "Grade", "ModifiedDate", "UserId", "UserName" },
                values: new object[,]
                {
                    { new Guid("dc71cf95-91f9-4fb0-9787-7e8838730b78"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(522), "Sample review Description 3", (byte)3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "b8e05b50-4df5-45e5-b5cf-671869c40dd2", "Admin Admin" },
                    { new Guid("7e4494ab-4d74-447a-bcab-fd322e036a1c"), new DateTime(2022, 3, 5, 11, 8, 57, 311, DateTimeKind.Utc).AddTicks(9192), "Sample review Description 1", (byte)1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "b8e05b50-4df5-45e5-b5cf-671869c40dd2", "Admin Admin" },
                    { new Guid("471d313d-bfaa-4327-8686-eab7f73c5eee"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(411), "Sample review Description 2", (byte)2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "b8e05b50-4df5-45e5-b5cf-671869c40dd2", "Admin Admin" },
                    { new Guid("83b7f926-d06a-42b9-967b-8ed5e08f912e"), new DateTime(2022, 3, 5, 11, 8, 57, 312, DateTimeKind.Utc).AddTicks(548), "Sample review Description 4", (byte)4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "b8e05b50-4df5-45e5-b5cf-671869c40dd2", "Admin Admin" }
                });
        }
    }
}
