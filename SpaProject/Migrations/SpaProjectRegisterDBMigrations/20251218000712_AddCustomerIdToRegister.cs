using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpaProject.Migrations.SpaProjectRegisterDBMigrations
{
    /// <inheritdoc />
    public partial class AddCustomerIdToRegister : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Register",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Register");
        }
    }
}
