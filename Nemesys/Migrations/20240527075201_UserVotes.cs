using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class UserVotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserVotes",
                columns: table => new
                {
                    UserVoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReportID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVotes", x => x.UserVoteID);
                    table.ForeignKey(
                        name: "FK_UserVotes_Reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Reports",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff799f8-0630-47e6-b8b2-d43c2eea58f0", "AQAAAAEAACcQAAAAEG0xI81vsUEUuyTPdMtZLrE2yuS6SyQvy+UBs3Hh/RAayZLB3tXuiNaMuSG56cQ5XA==", "47403240-e55e-4dc6-9513-979ea278b75f" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8262), new DateTime(2024, 5, 24, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8301), new DateTime(2024, 5, 23, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 5, 22, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.CreateIndex(
                name: "IX_UserVotes_ReportID",
                table: "UserVotes",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_UserVotes_UserId_ReportID",
                table: "UserVotes",
                columns: new[] { "UserId", "ReportID" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVotes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdfe7b40-73c1-4350-acaa-4477b268ff7c", "AQAAAAEAACcQAAAAED9sDznmtZy6jYYLvPktHregVKygDDPvb3jFzPFlkgNz7Mw7AG0MNhMO80Be1H/ycQ==", "7531aa5b-2065-4161-8148-c1bd66c43aa3" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8683), new DateTime(2024, 5, 23, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8740), new DateTime(2024, 5, 22, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 5, 21, 13, 52, 41, 47, DateTimeKind.Local).AddTicks(8753) });
        }
    }
}
