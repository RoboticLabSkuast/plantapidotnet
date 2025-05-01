using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_observationEntity_phenologicalEntities_phenologicalEntity_Id",
                table: "observationEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_phenologicalEntities_phenologicalStageEntities_phenological~",
                table: "phenologicalEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phenologicalStageEntities",
                table: "phenologicalStageEntities");

            migrationBuilder.RenameTable(
                name: "phenologicalStageEntities",
                newName: "phenologicalStageEntity");

            migrationBuilder.RenameColumn(
                name: "PhenologicalEntity_Id",
                table: "phenologicalEntities",
                newName: "phenologicalEntities_Id");

            migrationBuilder.RenameColumn(
                name: "phenologicalEntity_Id",
                table: "observationEntity",
                newName: "phenologicalEntities_Id");

            migrationBuilder.RenameIndex(
                name: "IX_observationEntity_phenologicalEntity_Id",
                table: "observationEntity",
                newName: "IX_observationEntity_phenologicalEntities_Id");

            migrationBuilder.RenameColumn(
                name: "stage",
                table: "phenologicalStageEntity",
                newName: "stageName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phenologicalStageEntity",
                table: "phenologicalStageEntity",
                column: "phenologicalStageEntity_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_observationEntity_phenologicalEntities_phenologicalEntities~",
                table: "observationEntity",
                column: "phenologicalEntities_Id",
                principalTable: "phenologicalEntities",
                principalColumn: "phenologicalEntities_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_phenologicalEntities_phenologicalStageEntity_phenologicalSt~",
                table: "phenologicalEntities",
                column: "phenologicalStageEntity_Id",
                principalTable: "phenologicalStageEntity",
                principalColumn: "phenologicalStageEntity_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_observationEntity_phenologicalEntities_phenologicalEntities~",
                table: "observationEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_phenologicalEntities_phenologicalStageEntity_phenologicalSt~",
                table: "phenologicalEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phenologicalStageEntity",
                table: "phenologicalStageEntity");

            migrationBuilder.RenameTable(
                name: "phenologicalStageEntity",
                newName: "phenologicalStageEntities");

            migrationBuilder.RenameColumn(
                name: "phenologicalEntities_Id",
                table: "phenologicalEntities",
                newName: "PhenologicalEntity_Id");

            migrationBuilder.RenameColumn(
                name: "phenologicalEntities_Id",
                table: "observationEntity",
                newName: "phenologicalEntity_Id");

            migrationBuilder.RenameIndex(
                name: "IX_observationEntity_phenologicalEntities_Id",
                table: "observationEntity",
                newName: "IX_observationEntity_phenologicalEntity_Id");

            migrationBuilder.RenameColumn(
                name: "stageName",
                table: "phenologicalStageEntities",
                newName: "stage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phenologicalStageEntities",
                table: "phenologicalStageEntities",
                column: "phenologicalStageEntity_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_observationEntity_phenologicalEntities_phenologicalEntity_Id",
                table: "observationEntity",
                column: "phenologicalEntity_Id",
                principalTable: "phenologicalEntities",
                principalColumn: "PhenologicalEntity_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_phenologicalEntities_phenologicalStageEntities_phenological~",
                table: "phenologicalEntities",
                column: "phenologicalStageEntity_Id",
                principalTable: "phenologicalStageEntities",
                principalColumn: "phenologicalStageEntity_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
