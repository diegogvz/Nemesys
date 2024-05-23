using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class UpdateReportModelWithNewFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Reports",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HazardDateTime",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "HazardType",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "Description", "HazardDateTime", "HazardType", "Location", "Status" },
                values: new object[] { new DateTime(2024, 5, 23, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(587), "Content of Report 1", new DateTime(2024, 5, 20, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(627), "Unsafe Act", "Building A", "Open" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "Description", "HazardDateTime", "HazardType", "Location", "Status" },
                values: new object[] { new DateTime(2024, 5, 22, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(631), "Content of Report 2", new DateTime(2024, 5, 19, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(634), "Unsafe Condition", "Building B", "Closed" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "Description", "HazardDateTime", "HazardType", "Location", "Status" },
                values: new object[] { new DateTime(2024, 5, 21, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(637), "Content of Report 3", new DateTime(2024, 5, 18, 12, 36, 10, 585, DateTimeKind.Local).AddTicks(639), "Unsafe Equipment", "Building C", "In Progress" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HazardDateTime",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "HazardType",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Reports",
                newName: "Content");

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "Content", "DateOfReport" },
                values: new object[] { "Content of Report 1", new DateTime(2024, 5, 23, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "Content", "DateOfReport" },
                values: new object[] { "Content of Report 2", new DateTime(2024, 5, 22, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "Content", "DateOfReport" },
                values: new object[] { "Content of Report 3", new DateTime(2024, 5, 21, 11, 20, 44, 775, DateTimeKind.Local).AddTicks(3989) });
        }
    }
}
