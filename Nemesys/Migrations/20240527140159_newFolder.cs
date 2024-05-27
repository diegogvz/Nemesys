using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class newFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97f8af03-3894-4bcb-9272-a10a817dea3a", "AQAAAAEAACcQAAAAEPTiBB2pFjJQxCesPbxjGA0SyK+1BnA7GIBO9TR+4Mm1+tDB/h8dTQiUg0+bcY5lrg==", "ce670a10-c618-478a-8a27-de1ec5dfa8ab" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 5, 24, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8878), new DateTime(2024, 5, 23, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8885), new DateTime(2024, 5, 22, 16, 1, 59, 26, DateTimeKind.Local).AddTicks(8885) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79db28b6-34c5-49b0-b2d3-29f11a7fc1d6", "AQAAAAEAACcQAAAAEBpFYp+JGp4je/NUUTf5fCCkUocrHrVYQ8yb7YD2DcGcnJyFPs/gjvjm5zAJzWgFLA==", "154f9863-0e3f-4cc9-9f93-f05864ffe106" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2754), new DateTime(2024, 5, 24, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2809), new DateTime(2024, 5, 23, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2814), new DateTime(2024, 5, 22, 10, 2, 38, 617, DateTimeKind.Local).AddTicks(2816) });
        }
    }
}
