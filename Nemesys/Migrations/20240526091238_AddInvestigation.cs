using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nemesys.Migrations
{
    public partial class AddInvestigation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigations",
                columns: table => new
                {
                    InvestigationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReportID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfAction = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InvestigatorDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvestigatorEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvestigatorPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigations", x => x.InvestigationID);
                    table.ForeignKey(
                        name: "FK_Investigations_Reports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "Reports",
                        principalColumn: "ReportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dfc6215-bd91-480a-9baa-900694453f57", "AQAAAAEAACcQAAAAEHebV3yqZ3DY6dJNEo7QvRdau5Z7bhjNgAVhWAw5l+qBiTsjCmkY5XQIbN+Lt6C7Ew==", "e4d17ba6-1fa7-48e8-a25d-5c6a27f02d69" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2418), new DateTime(2024, 5, 23, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 25, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2476), new DateTime(2024, 5, 22, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2488), new DateTime(2024, 5, 21, 11, 12, 37, 913, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.CreateIndex(
                name: "IX_Investigations_ReportID",
                table: "Investigations",
                column: "ReportID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63dec3e6-61d7-4216-8e7a-df6e60c53539", "AQAAAAEAACcQAAAAEB8id/5/v6oKqJzOyxGi2aDYVfUyFqSJLaarZO7eIvvGC7H4xq8gCTl2pcRrRAI7Mw==", "7c7928fa-09d8-4645-a68a-dc7be4737a3a" });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 1,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 24, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5091), new DateTime(2024, 5, 21, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 2,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 23, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 5, 20, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5135) });

            migrationBuilder.UpdateData(
                table: "Reports",
                keyColumn: "ReportID",
                keyValue: 3,
                columns: new[] { "DateOfReport", "HazardDateTime" },
                values: new object[] { new DateTime(2024, 5, 22, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 5, 19, 18, 51, 42, 784, DateTimeKind.Local).AddTicks(5142) });
        }
    }
}
