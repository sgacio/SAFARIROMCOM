using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SAFARIROMCOM.Migrations
{
    public partial class AddedNewColumnLastTimeSeen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastTimeSeen",
                table: "Trip",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastTimeSeen",
                table: "Trip");
        }
    }
}
