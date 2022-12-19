using Microsoft.EntityFrameworkCore.Migrations;

namespace VICO_Project.Migrations
{
    public partial class initialUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Status_StatusId",
                table: "Provinces");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropIndex(
                name: "IX_Provinces_StatusId",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Provinces");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Provinces",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Provinces");

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Provinces",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_StatusId",
                table: "Provinces",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Status_StatusId",
                table: "Provinces",
                column: "StatusId",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
