using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdateUserConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b2e238c-6a03-4944-a6dc-e8edbc0fcf83", "AQAAAAEAACcQAAAAEIunqnV64N0M1L/tnZpzMaF5I2l0oX0L+dZieI+W048UI+4XuxxYRGOrPf1Lm31Bsg==", "df001a56-329f-41cb-9645-1ed302c95d57" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6442), new DateTime(2024, 5, 20, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6500) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6506), new DateTime(2024, 5, 19, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6513) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 21, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6519), new DateTime(2024, 5, 18, 19, 0, 53, 107, DateTimeKind.Local).AddTicks(6519) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1640e630-7325-4710-8679-2243f3266e36", "AQAAAAEAACcQAAAAECanUmHfsittOS8DD/5XkF2lxbgZKRUxt9ON7hjYS5Ia1fxSS866qRUUK/xu5lQStw==", "e7302e35-a504-4d17-a6e5-8d365650c60e" });

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
    }
}
