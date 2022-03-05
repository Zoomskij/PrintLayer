using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrintLayer.Migrations
{
    public partial class VotePrint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("116237d8-5eb3-47a1-81db-1421ac7cb73b"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("31d7cda3-7f1e-4ebd-83f1-e346f84abdd3"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("710fb015-5a4d-4805-bde7-1d5030ecf950"));

            migrationBuilder.DeleteData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("e47fc99e-9796-4bfc-b700-76b892e1caed"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1327c0da-68de-4b80-870d-bbbff8c1710d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15a71a7d-6118-459a-ae6e-8124e7e8677d"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("3c1a2b8d-447f-4c18-b2f5-2ab7422ebc53"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("45a3da50-d3bd-4c19-a970-f925e8221c0e"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cea8115-215a-4db9-b323-6d01c6eb0cdd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("56fb7c2c-34ac-40db-9561-6bb3706d3d5f"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5cba18cd-4d71-4fe9-90db-3f410e34af27"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5d6e0834-5c05-4fa4-9f0e-753000fcb5fd"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5e56290c-ef75-4e04-803e-c82866ae91ca"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("6606290b-6811-494c-9974-d62cddb440be"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("70d96bd6-6333-4e8d-b985-97322b41c292"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ac5f46f7-4841-451f-9ed6-8cf8a16349e9"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("c9363010-62de-4f9a-a5fa-7eda997395d7"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("cd9efa5f-11b2-432e-af43-3a2f3872a579"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e039b1d0-1d30-4989-ae2d-6606d794e35a"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ec64890f-b6df-4554-8260-ab88bfce4ffe"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ee1bfda5-8179-4b23-a041-c217151814d1"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f04b38af-fbdb-47c7-85f1-688af15a9cff"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("f822e6e8-b5a5-4d4a-9dd0-727e2a267def"));

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("fb2f0222-8553-4242-9722-a6d6c12b7310"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("48d7f120-6383-4849-ba16-b01168f652a1"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("4beee834-d716-4674-bfd7-c05bc0cae3e2"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("515e4da6-3746-469f-b735-fcf9bf521b0a"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("c128e968-1e51-4268-9148-4217c25482ec"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c32f093-abb1-48b8-bb89-c75f484dd8f8");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
