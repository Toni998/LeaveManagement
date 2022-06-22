using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Canclled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

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
    }
}
