using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalInformationSystem.Data.Migrations
{
    public partial class AddPersonTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonalLeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestingPersonalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApprovedPersonalId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PersonalLeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalLeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalLeaveRequests_AspNetUsers_ApprovedPersonalId",
                        column: x => x.ApprovedPersonalId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalLeaveRequests_AspNetUsers_RequestingPersonalId",
                        column: x => x.RequestingPersonalId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonalLeaveRequests_PersonalLeaveTypes_PersonalLeaveTypeId",
                        column: x => x.PersonalLeaveTypeId,
                        principalTable: "PersonalLeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalLeaveRequests_ApprovedPersonalId",
                table: "PersonalLeaveRequests",
                column: "ApprovedPersonalId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalLeaveRequests_PersonalLeaveTypeId",
                table: "PersonalLeaveRequests",
                column: "PersonalLeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalLeaveRequests_RequestingPersonalId",
                table: "PersonalLeaveRequests",
                column: "RequestingPersonalId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalLeaveRequests");
        }
    }
}