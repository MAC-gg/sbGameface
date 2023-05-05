using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sbGameface.Data.Migrations
{
    /// <inheritdoc />
    public partial class GameQChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullQ",
                table: "GameQ",
                newName: "ReportCol");

            migrationBuilder.RenameColumn(
                name: "ColumnHead",
                table: "GameQ",
                newName: "Q");

            migrationBuilder.AddColumn<int>(
                name: "TeamSize",
                table: "Game",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeamSize",
                table: "Game");

            migrationBuilder.RenameColumn(
                name: "ReportCol",
                table: "GameQ",
                newName: "FullQ");

            migrationBuilder.RenameColumn(
                name: "Q",
                table: "GameQ",
                newName: "ColumnHead");
        }
    }
}
