using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RetroTapes.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "film",
                schema: "dbo",
                columns: table => new
                {
                    film_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_year = table.Column<int>(type: "int", nullable: true),
                    language_id = table.Column<byte>(type: "tinyint", nullable: false),
                    original_language_id = table.Column<byte>(type: "tinyint", nullable: true),
                    rental_duration = table.Column<byte>(type: "tinyint", nullable: false),
                    rental_rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    length = table.Column<int>(type: "int", nullable: true),
                    replacement_cost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    rating = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    last_update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    special_features = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    fulltext = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_film", x => x.film_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "film",
                schema: "dbo");
        }
    }
}
