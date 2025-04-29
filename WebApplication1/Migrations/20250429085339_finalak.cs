using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class finalak : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cropsEntity_cropsEntity_crop_id1",
                table: "cropsEntity");

            migrationBuilder.DropIndex(
                name: "IX_cropsEntity_crop_id1",
                table: "cropsEntity");

            migrationBuilder.DropColumn(
                name: "crop_id1",
                table: "cropsEntity");

            migrationBuilder.CreateTable(
                name: "treesTables",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    expert_id = table.Column<int>(type: "integer", nullable: false),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    variety_id = table.Column<int>(type: "integer", nullable: false),
                    rootstock_id = table.Column<int>(type: "integer", nullable: false),
                    agroClimaticZone = table.Column<string>(type: "text", nullable: false),
                    graftingAge = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    plantAge = table.Column<int>(type: "integer", nullable: false),
                    location = table.Column<string>(type: "text", nullable: false),
                    latitude = table.Column<string>(type: "text", nullable: false),
                    longitude = table.Column<string>(type: "text", nullable: false),
                    region = table.Column<string>(type: "text", nullable: false),
                    row = table.Column<string>(type: "text", nullable: false),
                    coloum = table.Column<string>(type: "text", nullable: false),
                    plantStatus = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treesTables", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "treesTables");

            migrationBuilder.AddColumn<int>(
                name: "crop_id1",
                table: "cropsEntity",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cropsEntity_crop_id1",
                table: "cropsEntity",
                column: "crop_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_cropsEntity_cropsEntity_crop_id1",
                table: "cropsEntity",
                column: "crop_id1",
                principalTable: "cropsEntity",
                principalColumn: "crop_id");
        }
    }
}
