using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class justToCOnfirm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
