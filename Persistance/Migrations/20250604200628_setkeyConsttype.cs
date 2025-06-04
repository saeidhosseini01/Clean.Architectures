using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class setkeyConsttype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConstTypeIds",
                schema: "CNT",
                table: "Const");

            migrationBuilder.AddColumn<string>(
                name: "Key",
                schema: "CNT",
                table: "ConstType",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ConstTypeId",
                schema: "CNT",
                table: "Const",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                schema: "CNT",
                table: "ConstType");

            migrationBuilder.DropColumn(
                name: "ConstTypeId",
                schema: "CNT",
                table: "Const");

            migrationBuilder.AddColumn<string>(
                name: "ConstTypeIds",
                schema: "CNT",
                table: "Const",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
