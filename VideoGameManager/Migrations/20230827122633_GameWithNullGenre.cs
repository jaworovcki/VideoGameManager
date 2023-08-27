using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGameManager.Migrations
{
    /// <inheritdoc />
    public partial class GameWithNullGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameGenres_GenreId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Games",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameGenres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "GameGenres",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_GameGenres_GenreId",
                table: "Games");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_GameGenres_GenreId",
                table: "Games",
                column: "GenreId",
                principalTable: "GameGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
