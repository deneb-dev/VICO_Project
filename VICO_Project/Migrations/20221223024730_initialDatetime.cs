using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VICO_Project.Migrations
{
    public partial class initialDatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Akhir_Libur",
                table: "Cutis",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Awal_Libur",
                table: "Cutis",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Akhir_Libur",
                table: "Cutis");

            migrationBuilder.DropColumn(
                name: "Awal_Libur",
                table: "Cutis");
        }
    }
}
