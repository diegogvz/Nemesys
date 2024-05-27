using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class fromPull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
