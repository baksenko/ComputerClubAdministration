using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastrucutre.Migrations
{
    /// <inheritdoc />
    public partial class NormFieldsNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "category",
                table: "WorkStations",
                newName: "Category");

            migrationBuilder.RenameColumn(
                name: "telephone",
                table: "Users",
                newName: "Telephone");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Category",
                table: "WorkStations",
                newName: "category");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Users",
                newName: "telephone");
        }
    }
}
