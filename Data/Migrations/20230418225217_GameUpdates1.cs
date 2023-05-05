using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sbGameface.Data.Migrations
{
    /// <inheritdoc />
    public partial class GameUpdates1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ColumnHead",
                table: "GameStat",
                newName: "ReportCol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReportCol",
                table: "GameStat",
                newName: "ColumnHead");
        }
    }
}
