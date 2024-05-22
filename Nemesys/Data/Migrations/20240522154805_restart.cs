using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class restart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 22, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 21, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                column: "DateOfReport",
                value: new DateTime(2024, 5, 20, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4112));
        }
    }
}
