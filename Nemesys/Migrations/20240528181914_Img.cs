using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class Img : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a428217d-55da-45a5-9687-910534178a5a", "AQAAAAEAACcQAAAAEOT2oMv84JwzLcnvB2TiHG1oFsRQAVK7OJdKQbxK2QyBHM7lA8bavMOsbmODR1xhiQ==", "3e78002f-5197-4ce6-abb4-4a770e0fccef" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 28, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7611), new DateTime(2024, 5, 25, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 5, 24, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7662) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7662), new DateTime(2024, 5, 23, 20, 19, 13, 667, DateTimeKind.Local).AddTicks(7668) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
