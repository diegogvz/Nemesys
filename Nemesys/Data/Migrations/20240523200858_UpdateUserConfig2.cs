using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdateUserConfig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b86b14-080d-445f-a8b9-ff41cf8456a9", "AQAAAAEAACcQAAAAEJLAZ0Urq88YR97Ebr/0MezCdbhbzvAgZzaS5jtqqptgSWpMmLsCDBVZWy+5JyefCA==", "a0429ce8-b47c-400a-8cca-477b327bd0ae" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "Diego", "4b2e238c-6a03-4944-a6dc-e8edbc0fcf83", "AQAAAAEAACcQAAAAEIunqnV64N0M1L/tnZpzMaF5I2l0oX0L+dZieI+W048UI+4XuxxYRGOrPf1Lm31Bsg==", "df001a56-329f-41cb-9645-1ed302c95d57" });

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
    }
}
