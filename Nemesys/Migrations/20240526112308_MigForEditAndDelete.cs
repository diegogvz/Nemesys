using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class MigForEditAndDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "311ea512-0ccf-418a-a249-f991b63d3a4d", "AQAAAAEAACcQAAAAEH/OIaT9jELXKoUlTCud95AHntID7OI0PEwqvNZ1S/MRRLbxuyqvk98p0lO7yaI2EQ==", "df1944a9-cf98-4169-bea0-2e421cab56be" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2171), new DateTime(2024, 5, 23, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2241), new DateTime(2024, 5, 22, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2254), new DateTime(2024, 5, 21, 13, 23, 7, 550, DateTimeKind.Local).AddTicks(2260) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
