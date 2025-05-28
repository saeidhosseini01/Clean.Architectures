using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class setschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.EnsureSchema(
                name: "CNT");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.RenameTable(
                name: "Const",
                newName: "Const",
                newSchema: "CNT");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users",
                newSchema: "auth");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                schema: "auth",
                table: "Users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                schema: "auth",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Const",
                schema: "CNT",
                newName: "Const");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "auth",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");
        }
    }
}
