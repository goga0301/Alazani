using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alazani.Infrastructure.Repository.Migrations
{
    /// <inheritdoc />
    public partial class test22 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                schema: "AlazaniDb",
                table: "Tests");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastName",
                schema: "AlazaniDb",
                table: "Tests",
                type: "varchar",
                maxLength: 90,
                nullable: false,
                defaultValue: "");
        }
    }
}
