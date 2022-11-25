using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagement.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "be2e7efb-8f03-4efa-a7ff-0029924ef8d5", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "98280c03-1d4d-42f6-bbd0-4cbcacf6ec3d", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "ef9b35d9-6da7-4ad7-ad41-9ca2e0c7c682", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAEOCqeA3Etonhcl7/WkK+NS1C/ZpiNXt1JVd1cA8W4osI17Gk1DGAddcvRU8fbmDYbg==", null, false, "d6a235bf-aa73-4ede-b057-3200177de244", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 25, 11, 11, 35, 412, DateTimeKind.Local).AddTicks(7417), new DateTime(2022, 11, 25, 11, 11, 35, 414, DateTimeKind.Local).AddTicks(3196), "Black", "System" },
                    { 2, "System", new DateTime(2022, 11, 25, 11, 11, 35, 414, DateTimeKind.Local).AddTicks(5289), new DateTime(2022, 11, 25, 11, 11, 35, 414, DateTimeKind.Local).AddTicks(5302), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 25, 11, 11, 35, 417, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 11, 25, 11, 11, 35, 417, DateTimeKind.Local).AddTicks(2495), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 11, 25, 11, 11, 35, 417, DateTimeKind.Local).AddTicks(2505), new DateTime(2022, 11, 25, 11, 11, 35, 417, DateTimeKind.Local).AddTicks(2509), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1203), new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1221), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1228), new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1231), "X5", "System" },
                    { 3, "System", new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1234), new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1236), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 11, 25, 11, 11, 35, 418, DateTimeKind.Local).AddTicks(1242), "Rev4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
