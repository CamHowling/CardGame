using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CardGame.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePileModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Is_Discard_Pile",
                table: "Pile",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Is_Draw_Pile",
                table: "Pile",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Is_Discard_Pile",
                table: "Pile");

            migrationBuilder.DropColumn(
                name: "Is_Draw_Pile",
                table: "Pile");
        }
    }
}
