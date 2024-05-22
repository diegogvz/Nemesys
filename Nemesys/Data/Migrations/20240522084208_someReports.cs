using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Data.Migrations
{
    public partial class someReports : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeOfHazard",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "TypeOfHazard",
                table: "Reports",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Reports",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "ReporterEmail",
                table: "Reports",
                newName: "Content");

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportID", "Content", "DateOfReport", "ImageUrl", "Title", "Upvotes" },
                values: new object[] { 1, "Content of Report 1", new DateTime(2024, 5, 22, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6895), "https://example.com/image1.jpg", "Report 1", 5 });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportID", "Content", "DateOfReport", "ImageUrl", "Title", "Upvotes" },
                values: new object[] { 2, "Content of Report 2", new DateTime(2024, 5, 21, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6946), "https://example.com/image2.jpg", "Report 2", 10 });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "ReportID", "Content", "DateOfReport", "ImageUrl", "Title", "Upvotes" },
                values: new object[] { 3, "Content of Report 3", new DateTime(2024, 5, 20, 10, 42, 7, 894, DateTimeKind.Local).AddTicks(6952), "https://example.com/image3.jpg", "Report 3", 7 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Reports",
                newName: "TypeOfHazard");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Reports",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Reports",
                newName: "ReporterEmail");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeOfHazard",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
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
        }
    }
}
