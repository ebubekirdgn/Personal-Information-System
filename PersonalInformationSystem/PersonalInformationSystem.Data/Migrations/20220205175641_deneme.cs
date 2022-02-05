using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalInformationSystem.Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonalLeaveTypes",
                columns: new[] { "Id", "DateCreated", "DefaultDays", "IsActive", "Name" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Yıllık İzin" });

            migrationBuilder.InsertData(
                table: "PersonalLeaveTypes",
                columns: new[] { "Id", "DateCreated", "DefaultDays", "IsActive", "Name" },
                values: new object[] { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, false, "Doğum İzni" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonalLeaveTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonalLeaveTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
