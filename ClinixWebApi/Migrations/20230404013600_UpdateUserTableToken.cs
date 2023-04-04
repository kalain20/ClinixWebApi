using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinixWebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTableToken : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Token",
                table: "users");
        }
    }
}
