using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class updatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "d8d8a16d-4e62-4d0e-a8e2-46fb783119b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "657b29fc-0b93-4fa1-9f25-8c4f171fcd2b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae13571d-078f-4365-b2bb-d46d5300c7a0", "AQAAAAEAACcQAAAAEBqaLHYD9fgwyPH6b67/VvBC1eRjDgwwhq/TLJMsVI+Kw5/oT+7MQdzSJmxKpt08fw==", "12331f55-2ddb-48b6-9017-5c27f7643acb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d26dfce3-4f78-4c19-9c4b-f8a7654b709b", "AQAAAAEAACcQAAAAEPA1TZnlo9TOGX/YuuPmsTywwEFrb0g2Vimlcz7BsAipF4OkIsTKOVyga7bkjnBgSw==", "ab48df20-c54d-4b92-a5cc-d6ab76e72129" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aca43a6e-f7aa-5648-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "c12d04dd-6b06-4918-a1e5-7366105e7ac6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "6fbe8527-da2c-4c3d-99ae-06d17aeaff36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bab43a6e-f7af-4333-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b1ccef6-18db-45d6-84c9-4e751c21018a", "AQAAAAEAACcQAAAAELhhLkHJvPI78Mi5OoVTDfRhguxDOATAQbQfAUdmqHT1boGM3OzctuxMtZ7+Pgvq3g==", "b3ab1a5b-7eb5-4020-ac35-e7fc8f38b458" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7af-4238-bccf-1add431cc487",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d2c5bdf-d0b8-4604-ac1a-11ac40937ed8", "AQAAAAEAACcQAAAAEP79TmA0xelQj4i5VGFZTl3HNbPbCs1H8ckzd0bGqh7jvT00ZaMx6wO2a/YUiEBbRA==", "c05d9fe9-0954-42a9-b8a3-f456434fca66" });
        }
    }
}
