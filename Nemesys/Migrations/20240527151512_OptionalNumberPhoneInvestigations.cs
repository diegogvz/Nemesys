using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class OptionalNumberPhoneInvestigations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvestigatorPhone",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2183f049-89b2-41f1-a577-8072b1231316", "AQAAAAEAACcQAAAAELG5xfsJGWQZZ4yM6hCnVwqG0DFDO3zAw9KWIXPPaNLzXunWhp3pjtoeL1nRKMGRQg==", "9cf1953e-de95-4c09-8b8e-21ad3f3eefb1" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(5910), new DateTime(2024, 5, 24, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 5, 23, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(6001), new DateTime(2024, 5, 22, 17, 15, 11, 705, DateTimeKind.Local).AddTicks(6006) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvestigatorPhone",
                table: "Investigations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
