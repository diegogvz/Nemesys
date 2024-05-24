using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdateUserConfig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb973edf-1dba-471b-9a98-f264c4999618", false, "AQAAAAEAACcQAAAAEC/xgJ8CXP/mNE5jB+bZNJMZsyHGVix9WD7x2+J/34LCPwF5nwLWASB2X4r6RycnQA==", "e4787923-bdae-48c9-a5b4-f7c208bd3768" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b86b14-080d-445f-a8b9-ff41cf8456a9", true, "AQAAAAEAACcQAAAAEJLAZ0Urq88YR97Ebr/0MezCdbhbzvAgZzaS5jtqqptgSWpMmLsCDBVZWy+5JyefCA==", "a0429ce8-b47c-400a-8cca-477b327bd0ae" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7891), new DateTime(2024, 5, 20, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7955) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7961), new DateTime(2024, 5, 19, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7974), new DateTime(2024, 5, 18, 22, 8, 57, 407, DateTimeKind.Local).AddTicks(7980) });
        }
    }
}
