using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class setChema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConstTypeId",
                table: "Const",
                newName: "ConstTypeIds");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ConstTypeIds",
                table: "Const",
                newName: "ConstTypeId");
        }
    }
}
