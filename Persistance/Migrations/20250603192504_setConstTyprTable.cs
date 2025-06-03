using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Architecture.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class setConstTyprTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AUTH");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "auth",
                newName: "Users",
                newSchema: "AUTH");

            migrationBuilder.CreateTable(
                name: "ConstType",
                schema: "CNT",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TypeTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstType",
                schema: "CNT");

            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.RenameTable(
                name: "Users",
                schema: "AUTH",
                newName: "Users",
                newSchema: "auth");
        }
    }
}
