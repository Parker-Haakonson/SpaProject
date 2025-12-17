using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaProject.Migrations.SpaProjectRegisterDBMigrations
{
    /// <inheritdoc />
    public partial class AddUserContactInfoToRegister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Register",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Register",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Register",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Register");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Register");
        }
    }
}
