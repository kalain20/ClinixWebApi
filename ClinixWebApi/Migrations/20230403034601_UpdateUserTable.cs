using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClinixWebApi.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "nurses");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "doctors");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "beneficiary");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "nurses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "doctors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "beneficiary",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
