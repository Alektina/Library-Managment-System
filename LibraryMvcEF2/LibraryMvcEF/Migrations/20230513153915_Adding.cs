using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryMvcEF.Migrations
{
    /// <inheritdoc />
    public partial class Adding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 39, 14, 893, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 39, 14, 893, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 39, 14, 893, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 39, 14, 893, DateTimeKind.Local).AddTicks(8140));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 1,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 23, 52, 829, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 2,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 23, 52, 829, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 3,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 23, 52, 829, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Loans",
                keyColumn: "Id",
                keyValue: 4,
                column: "LoanPeriod",
                value: new DateTime(2023, 5, 13, 17, 23, 52, 829, DateTimeKind.Local).AddTicks(3790));
        }
    }
}
