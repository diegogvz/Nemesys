using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class nullImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1dcdd5f8-7ad6-4c43-b867-8e03fb01a87f", "AQAAAAEAACcQAAAAEHYo4a0ldqdaRyNoHi4HPjL4Iv2JVYxHblpQoHFw2DBsIQTX93CK8pS7KIwQJlQhyw==", "e9d90f0f-e591-4ef0-a572-52c4f7d044cd" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 28, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(304), new DateTime(2024, 5, 25, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(367) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(374), new DateTime(2024, 5, 24, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(393), new DateTime(2024, 5, 23, 19, 53, 28, 186, DateTimeKind.Local).AddTicks(393) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Reports",
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
                values: new object[] { "33a6aebe-5ea7-4d3b-a2a7-469c8e50de2e", "AQAAAAEAACcQAAAAEJd6MmPdidGlwTTU+RuB2Uwc2ntaaRUPoBwOG1jEMObNkqVa5oQ60a/lDpZNga/f5w==", "6d42fc3a-d3b9-43ba-a898-609c65e443d0" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8226), new DateTime(2024, 5, 24, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8283), new DateTime(2024, 5, 23, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8290) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 5, 22, 19, 8, 13, 5, DateTimeKind.Local).AddTicks(8290) });
        }
    }
}
