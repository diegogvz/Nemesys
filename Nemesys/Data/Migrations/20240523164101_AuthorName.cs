using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class AuthorName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "AuthorName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "Diego", "1640e630-7325-4710-8679-2243f3266e36", "AQAAAAEAACcQAAAAECanUmHfsittOS8DD/5XkF2lxbgZKRUxt9ON7hjYS5Ia1fxSS866qRUUK/xu5lQStw==", "e7302e35-a504-4d17-a6e5-8d365650c60e" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5063), new DateTime(2024, 5, 20, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5133), new DateTime(2024, 5, 19, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5146), new DateTime(2024, 5, 18, 18, 41, 0, 480, DateTimeKind.Local).AddTicks(5152) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ac5e2ae-b946-4eeb-aef9-3f3e69b881a4", "AQAAAAEAACcQAAAAEPVwvYE+QM+cSGxzR86jvmuFII83s+iwB3vx/NUpvrJQbL5Cac/La0iTPXjU2NC1pw==", "352af0a7-cb16-4ee7-9487-0b7c6b0a10a0" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9671), new DateTime(2024, 5, 20, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9773), new DateTime(2024, 5, 19, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9779) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9793), new DateTime(2024, 5, 18, 17, 57, 40, 75, DateTimeKind.Local).AddTicks(9831) });
        }
    }
}
