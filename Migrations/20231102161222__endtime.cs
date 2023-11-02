using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseCatalog.Migrations
{
    /// <inheritdoc />
    public partial class _endtime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeOnly>(
                name: "EndTIme",
                table: "Course",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeOnly(0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTIme",
                table: "Course");
        }
    }
}
