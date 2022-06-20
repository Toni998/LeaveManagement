using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class addedPeriodToLeaveAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c0c18560-e662-454b-b593-ebdf27e68fa4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "088ddf39-1631-4f6d-aa28-9fa17cd7f68f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "740f6e53-3278-43c3-909e-5ad4d1854f75", "AQAAAAEAACcQAAAAEI98MxhmHwUpOQrFjTMnZXDYQXOlrQEPD5fTOnUkQasJ3wnIy2KK/sQiwM/jruwrVw==", "2f28eb8e-85b6-4081-bf2a-20479ede87b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eac8eea3-17c1-4af1-900a-74a740253da3", "AQAAAAEAACcQAAAAENaf7sjTwMK6YQk//Baj6xNpdVcgbFpUfWjavxXCUJ+hrBoRBJLrhbB628fgLdUl+Q==", "b716b1c6-07f2-4b94-ac3e-088554ee4203" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f47c8cb-5a3f-4601-9af7-5056b5368807", "AQAAAAEAACcQAAAAEIINwaNp1vP7xVoq9YPJUr22eZ1FLvaDL4h3FZ6/6pIvz7Hr4s+mKg+QjX8Yp3CIVg==", "ad216840-3654-473c-8b59-22a79728b565" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64749e52-3b35-4c4a-839b-e377cc94897d", "AQAAAAEAACcQAAAAEEhhVS/64A8QeXB+TDn+2GQFRROFMXJbM1Y0Ch/MqFyd7z+fdfd4Df51PJ9RhL6DOg==", "a336d62f-6e6b-40be-9569-e8cd2ce8896b" });
        }
    }
}
