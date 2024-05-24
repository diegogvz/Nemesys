using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdatePullNoe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3dc4c0-2744-4e90-8108-c6505bb0cf9b", "AQAAAAEAACcQAAAAELn9+Y/ULU1CZZhiP/t1+3J0xADRhlByj6jrGekqKDnDOi/eC4ONuZ9qWNBx+IB15A==", "23b7c664-01c7-4fb6-8f03-376cee42b2df" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 5, 21, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1092) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1103), new DateTime(2024, 5, 20, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1115), new DateTime(2024, 5, 19, 11, 20, 45, 571, DateTimeKind.Local).AddTicks(1120) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb973edf-1dba-471b-9a98-f264c4999618", "AQAAAAEAACcQAAAAEC/xgJ8CXP/mNE5jB+bZNJMZsyHGVix9WD7x2+J/34LCPwF5nwLWASB2X4r6RycnQA==", "e4787923-bdae-48c9-a5b4-f7c208bd3768" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8021), new DateTime(2024, 5, 20, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8072), new DateTime(2024, 5, 19, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8078), new DateTime(2024, 5, 18, 23, 3, 4, 450, DateTimeKind.Local).AddTicks(8084) });
        }
    }
}
