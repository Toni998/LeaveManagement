using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "086e6a86-727b-457f-8bea-45a977abd07c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "766c6900-cd12-4ae2-91b8-afdca529bcbb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0f47c8cb-5a3f-4601-9af7-5056b5368807", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEIINwaNp1vP7xVoq9YPJUr22eZ1FLvaDL4h3FZ6/6pIvz7Hr4s+mKg+QjX8Yp3CIVg==", "ad216840-3654-473c-8b59-22a79728b565", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "64749e52-3b35-4c4a-839b-e377cc94897d", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEhhVS/64A8QeXB+TDn+2GQFRROFMXJbM1Y0Ch/MqFyd7z+fdfd4Df51PJ9RhL6DOg==", "a336d62f-6e6b-40be-9569-e8cd2ce8896b", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "baaef977-3729-42a6-97e9-02807db1d4ab");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2a22fd33-cc6f-49f5-9219-39f276532c4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9d7e0ff8-6eba-4ac3-a50d-eefb531f7ea2", false, null, "AQAAAAEAACcQAAAAEL7IO6wdIqPrMb9kDexbK+TYryhIvzTCf8WAzBEWzK8pzjcIUNYvl6sLIS2O3sZJgQ==", "d4449406-7afc-4017-ae54-058868726149", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "42debcb0-fb6a-4889-883e-6f1280a2e6de", false, null, "AQAAAAEAACcQAAAAEB5R1trjZAXrUxazICXSkSAga0djCX/WE1yfcPzh7iFROsqkSdfZgnrVWAf9bKDwcA==", "6cf330cb-f03b-42ad-9639-7bb916903fba", null });
        }
    }
}
