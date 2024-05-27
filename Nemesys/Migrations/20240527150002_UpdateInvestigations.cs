using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class UpdateInvestigations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f572f056-823a-4b7d-b8b9-49d7f5f54bf4", "AQAAAAEAACcQAAAAEHbFu6mkk9sJd4GuQrPNkvieTWLONvYYAjPuodxv+uGJJjTg4/+OVZN+KCiVzUNLbA==", "04eff22b-c221-4fed-9b76-8850b0bfca36" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4212), new DateTime(2024, 5, 24, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 5, 23, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 5, 22, 17, 0, 1, 618, DateTimeKind.Local).AddTicks(4312) });
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
