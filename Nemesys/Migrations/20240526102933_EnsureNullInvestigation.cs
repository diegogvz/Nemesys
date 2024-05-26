using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class EnsureNullInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7374ded-39ef-455a-a284-4ff56bc4432b", "AQAAAAEAACcQAAAAECgPlbbyz3++WRJs6EHljurNjgg+/r7dFbesiSaGOKo6cQ5/ByNl7aZ6OXxg4xh2Sw==", "6da5c4ef-56cb-48cb-b976-bdd5f5c76394" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(1955), new DateTime(2024, 5, 23, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(2006), new DateTime(2024, 5, 22, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(2012), new DateTime(2024, 5, 21, 12, 29, 33, 36, DateTimeKind.Local).AddTicks(2019) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
