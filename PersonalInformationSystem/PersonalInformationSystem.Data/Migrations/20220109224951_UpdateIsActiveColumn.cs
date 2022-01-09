using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalInformationSystem.Data.Migrations
{
    public partial class UpdateIsActiveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "PersonalLeaveTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "PersonalLeaveTypes");
        }
    }
}
