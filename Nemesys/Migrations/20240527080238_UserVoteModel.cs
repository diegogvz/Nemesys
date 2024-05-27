using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class UserVoteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff799f8-0630-47e6-b8b2-d43c2eea58f0", "AQAAAAEAACcQAAAAEG0xI81vsUEUuyTPdMtZLrE2yuS6SyQvy+UBs3Hh/RAayZLB3tXuiNaMuSG56cQ5XA==", "47403240-e55e-4dc6-9513-979ea278b75f" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8262), new DateTime(2024, 5, 24, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8301), new DateTime(2024, 5, 23, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8302) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8305), new DateTime(2024, 5, 22, 9, 52, 0, 916, DateTimeKind.Local).AddTicks(8306) });
        }
    }
}
