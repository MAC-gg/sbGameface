using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sbGameface.Data.Migrations
{
    /// <inheritdoc />
    public partial class GameStatChange2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportCol",
                table: "GameStat",
                newName: "StatName");

            migrationBuilder.RenameColumn(
                name: "LongName",
                table: "GameStat",
                newName: "StatDesc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StatName",
                table: "GameStat",
                newName: "ReportCol");

            migrationBuilder.RenameColumn(
                name: "StatDesc",
                table: "GameStat",
                newName: "LongName");
        }
    }
}
