using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class testt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abab7dbe-1a47-4480-be71-6b84471b8491", "AQAAAAEAACcQAAAAEC9Ha+4nkSxUUjZgtty0iNiEgdqcfETJBCFXXI5pPNXeJApVJgX003n9hAnIBt29Hg==", "63b8ce5f-788a-4f90-896c-a84fd80ddf67" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 30, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4271), new DateTime(2024, 5, 27, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 29, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 5, 26, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 28, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4348), new DateTime(2024, 5, 25, 16, 49, 24, 916, DateTimeKind.Local).AddTicks(4354) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
