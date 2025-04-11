using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class AddWhateverYouChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trees_Users_UserId",
                table: "Trees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trees",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_Trees_UserId",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Trees");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Trees",
                newName: "Variety");

            migrationBuilder.AddColumn<string>(
                name: "TreeId",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CanopySize",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GPSCoordinates",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "GraftingDate",
                table: "Trees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OrchardName",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Ownership",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlantAge",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlantSource",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlantStatus",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlantingDate",
                table: "Trees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RootstockType",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RowColumnPosition",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SpacingBetweenPlants",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TreeHeight",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TrunkDiameter",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trees",
                table: "Trees",
                column: "TreeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trees",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "TreeId",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "CanopySize",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "GPSCoordinates",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "GraftingDate",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "OrchardName",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "Ownership",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "PlantAge",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "PlantSource",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "PlantStatus",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "PlantingDate",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "RootstockType",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "RowColumnPosition",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "SpacingBetweenPlants",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "TreeHeight",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "TrunkDiameter",
                table: "Trees");

            migrationBuilder.RenameColumn(
                name: "Variety",
                table: "Trees",
                newName: "Name");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Trees",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trees",
                table: "Trees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Trees_UserId",
                table: "Trees",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trees_Users_UserId",
                table: "Trees",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
