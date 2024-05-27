using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class OptionalNumberPhoneInvestigations2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5063e91-1353-48ce-b660-7ef705577e2a", "AQAAAAEAACcQAAAAENdmYNRxP/PlhvaxMJ+lTpW49Lqxfvjs5t/3jnWlQC+NXRm0LACHJ4vuSzTfWdXx6g==", "416d0e9e-a7b6-4541-8607-64209a6e6f49" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 27, 17, 17, 30, 87, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 5, 24, 17, 17, 30, 88, DateTimeKind.Local).AddTicks(18) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 17, 17, 30, 88, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 5, 23, 17, 17, 30, 88, DateTimeKind.Local).AddTicks(23) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 17, 17, 30, 88, DateTimeKind.Local).AddTicks(25), new DateTime(2024, 5, 22, 17, 17, 30, 88, DateTimeKind.Local).AddTicks(27) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
