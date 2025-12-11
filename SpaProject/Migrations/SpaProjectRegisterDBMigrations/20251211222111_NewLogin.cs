using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaProject.Migrations.SpaProjectRegisterDBMigrations
{
    /// <inheritdoc />
    public partial class NewLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Register",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Register");
        }
    }
}
