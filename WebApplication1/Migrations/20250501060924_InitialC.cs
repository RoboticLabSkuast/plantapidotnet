using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "specialization",
                table: "expertEntity",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "address",
                table: "expertEntity",
                newName: "department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "year",
                table: "expertEntity",
                newName: "specialization");

            migrationBuilder.RenameColumn(
                name: "department",
                table: "expertEntity",
                newName: "address");
        }
    }
}
