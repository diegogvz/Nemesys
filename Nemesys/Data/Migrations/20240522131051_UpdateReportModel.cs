using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdateReportModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 22, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4067), "C:\\Users\\34722\\Pictures\\501_maradona.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4112), "C:\\Users\\34722\\Pictures\\501_maradona.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 20, 15, 10, 50, 932, DateTimeKind.Local).AddTicks(4112), "C:\\Users\\34722\\Pictures\\501_maradona.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 22, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6895), "https://example.com/image1.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 21, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6946), "https://example.com/image2.jpg" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "ImageUrl" },
                values: new object[] { new DateTime(2024, 5, 20, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6952), "https://example.com/image3.jpg" });
        }
    }
}
