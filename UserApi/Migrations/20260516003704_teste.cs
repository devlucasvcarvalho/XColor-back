using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserApi.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedAt",
                table: "Usuarios",
                newName: "DataCriacao");

            migrationBuilder.RenameColumn(
                name: "PasswordSalt",
                table: "Usuarios",
                newName: "SenhaSalt");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Usuarios",
                newName: "SenhaHash");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Usuarios",
                newName: "Usuario");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Usuarios",
                newName: "Token");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Usuarios",
                newName: "DataAlteracao");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "Usuario",
                table: "Usuarios",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Token",
                table: "Usuarios",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "SenhaSalt",
                table: "Usuarios",
                newName: "PasswordSalt");

            migrationBuilder.RenameColumn(
                name: "SenhaHash",
                table: "Usuarios",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "DataCriacao",
                table: "Usuarios",
                newName: "UpdatedAt");

            migrationBuilder.RenameColumn(
                name: "DataAlteracao",
                table: "Usuarios",
                newName: "CreatedAt");
        }
    }
}
