using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedUSersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "aca43a6e-f7aa-5648-baaf-1add431ccbbf", "baaef977-3729-42a6-97e9-02807db1d4ab", "User", "USER" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "2a22fd33-cc6f-49f5-9219-39f276532c4c", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "bab43a6e-f7af-4333-bccf-1add431cc487", 0, "9d7e0ff8-6eba-4ac3-a50d-eefb531f7ea2", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEL7IO6wdIqPrMb9kDexbK+TYryhIvzTCf8WAzBEWzK8pzjcIUNYvl6sLIS2O3sZJgQ==", null, false, "d4449406-7afc-4017-ae54-058868726149", "", false, null },
                    { "cac43a6e-f7af-4238-bccf-1add431cc487", 0, "42debcb0-fb6a-4889-883e-6f1280a2e6de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEB5R1trjZAXrUxazICXSkSAga0djCX/WE1yfcPzh7iFROsqkSdfZgnrVWAf9bKDwcA==", null, false, "6cf330cb-f03b-42ad-9639-7bb916903fba", "", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "aca43a6e-f7aa-5648-baaf-1add431ccbbf", "bab43a6e-f7af-4333-bccf-1add431cc487" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "cac43a6e-f7af-4238-bccf-1add431cc487" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "aca43a6e-f7aa-5648-baaf-1add431ccbbf", "bab43a6e-f7af-4333-bccf-1add431cc487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "cac43a6e-f7af-4238-bccf-1add431cc487" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487");
        }
    }
}
