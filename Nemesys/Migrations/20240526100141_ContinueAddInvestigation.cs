using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class ContinueAddInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dfc6215-bd91-480a-9baa-900694453f57", "AQAAAAEAACcQAAAAEHebV3yqZ3DY6dJNEo7QvRdau5Z7bhjNgAVhWAw5l+qBiTsjCmkY5XQIbN+Lt6C7Ew==", "e4d17ba6-1fa7-48e8-a25d-5c6a27f02d69" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2418), new DateTime(2024, 5, 23, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 5, 22, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2488), new DateTime(2024, 5, 21, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2488) });
        }
    }
}
