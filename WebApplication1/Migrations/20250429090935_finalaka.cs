using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class finalaka : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "crop_id1",
                table: "treesTables",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "expert_id1",
                table: "treesTables",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "rootstock_id1",
                table: "treesTables",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "variety_id1",
                table: "treesTables",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_crop_id1",
                table: "treesTables",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_expert_id1",
                table: "treesTables",
                column: "expert_id1");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_rootstock_id1",
                table: "treesTables",
                column: "rootstock_id1");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_variety_id1",
                table: "treesTables",
                column: "variety_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_cropsEntity_crop_id1",
                table: "treesTables",
                column: "crop_id1",
                principalTable: "cropsEntity",
                principalColumn: "crop_id");

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_expertEntity_expert_id1",
                table: "treesTables",
                column: "expert_id1",
                principalTable: "expertEntity",
                principalColumn: "expert_id");

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_rootstocksEntity_rootstock_id1",
                table: "treesTables",
                column: "rootstock_id1",
                principalTable: "rootstocksEntity",
                principalColumn: "rootstock_id");

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_varietiesEntity_variety_id1",
                table: "treesTables",
                column: "variety_id1",
                principalTable: "varietiesEntity",
                principalColumn: "variety_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_cropsEntity_crop_id1",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_expertEntity_expert_id1",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_rootstocksEntity_rootstock_id1",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_varietiesEntity_variety_id1",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_crop_id1",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_expert_id1",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_rootstock_id1",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_variety_id1",
                table: "treesTables");

            migrationBuilder.DropColumn(
                name: "crop_id1",
                table: "treesTables");

            migrationBuilder.DropColumn(
                name: "expert_id1",
                table: "treesTables");

            migrationBuilder.DropColumn(
                name: "rootstock_id1",
                table: "treesTables");

            migrationBuilder.DropColumn(
                name: "variety_id1",
                table: "treesTables");
        }
    }
}
