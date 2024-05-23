using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 23, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 22, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 21, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3989));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 22, 17, 48, 5, 377, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 21, 17, 48, 5, 377, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 20, 17, 48, 5, 377, DateTimeKind.Local).AddTicks(4595));
        }
    }
}
