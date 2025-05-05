using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldonesj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_DisorderEntity_physiological_disorder_id",
                table: "healthandEntity");

            migrationBuilder.RenameColumn(
                name: "physiological_disorder_id",
                table: "healthandEntity",
                newName: "disorder_id");

            migrationBuilder.RenameIndex(
                name: "IX_healthandEntity_physiological_disorder_id",
                table: "healthandEntity",
                newName: "IX_healthandEntity_disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_DisorderEntity_disorder_id",
                table: "healthandEntity",
                column: "disorder_id",
                principalTable: "DisorderEntity",
                principalColumn: "disorder_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_DisorderEntity_disorder_id",
                table: "healthandEntity");

            migrationBuilder.RenameColumn(
                name: "disorder_id",
                table: "healthandEntity",
                newName: "physiological_disorder_id");

            migrationBuilder.RenameIndex(
                name: "IX_healthandEntity_disorder_id",
                table: "healthandEntity",
                newName: "IX_healthandEntity_physiological_disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_DisorderEntity_physiological_disorder_id",
                table: "healthandEntity",
                column: "physiological_disorder_id",
                principalTable: "DisorderEntity",
                principalColumn: "disorder_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
