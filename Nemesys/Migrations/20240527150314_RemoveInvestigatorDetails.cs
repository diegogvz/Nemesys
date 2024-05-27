using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class RemoveInvestigatorDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvestigatorDetails",
                table: "Investigations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21eb8778-df49-4247-8a45-0f482030de02", "AQAAAAEAACcQAAAAEOe7VqlD/2rfpAf3tPYNZr+oO6oht7VmHWEe75HQglyqIWepZimT6x4GM+HYXkmQdw==", "8f60c113-af38-4a55-a5ad-4841dcc0d929" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5250), new DateTime(2024, 5, 24, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5461) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5513), new DateTime(2024, 5, 23, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5520) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5530), new DateTime(2024, 5, 22, 17, 3, 13, 860, DateTimeKind.Local).AddTicks(5536) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InvestigatorDetails",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
