using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class ContinueAddInvestigation2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5122af45-ca91-4b86-b0c7-f53b3f92b17c", "AQAAAAEAACcQAAAAEOoOMJ0j9Q6ws5nURd1HNwWgtv4K6w9NkM+PDW1O/pw8JfIOSUSJ7CMcFi69aZIavw==", "7c654663-fa55-457d-8577-aea703aaf0ac" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 5, 23, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6721), new DateTime(2024, 5, 22, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6733), new DateTime(2024, 5, 21, 12, 4, 53, 870, DateTimeKind.Local).AddTicks(6733) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73787cb6-9f10-4edb-912b-24cf93d23cd2", "AQAAAAEAACcQAAAAELkdU78htNUsYKC5kpjh8EgH+OUxX9Xtc9i7qUGgtkVrHvHg8zHFh8M27lQr58AdZw==", "677fafc4-41ce-43db-b780-24e3d56fc591" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3856), new DateTime(2024, 5, 23, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3907) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3913), new DateTime(2024, 5, 22, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 5, 21, 12, 1, 40, 882, DateTimeKind.Local).AddTicks(3926) });
        }
    }
}
