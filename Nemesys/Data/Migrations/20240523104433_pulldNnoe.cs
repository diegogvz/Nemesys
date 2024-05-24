using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class pulldNnoe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6918), new DateTime(2024, 5, 20, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6957) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6963), new DateTime(2024, 5, 19, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6969), new DateTime(2024, 5, 18, 12, 44, 33, 352, DateTimeKind.Local).AddTicks(6969) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(587), new DateTime(2024, 5, 20, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(627) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(631), new DateTime(2024, 5, 19, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(634) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(637), new DateTime(2024, 5, 18, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(639) });
        }
    }
}
