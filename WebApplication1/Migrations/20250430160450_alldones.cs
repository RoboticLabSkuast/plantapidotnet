using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldones : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_observationEntity_PhenologicalEntity_phenologicalEntity_Id",
                table: "observationEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PhenologicalEntity_phenlogicalStageEntities_phenologicalSta~",
                table: "PhenologicalEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PhenologicalEntity",
                table: "PhenologicalEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_phenlogicalStageEntities",
                table: "phenlogicalStageEntities");

            migrationBuilder.RenameTable(
                name: "PhenologicalEntity",
                newName: "phenologicalEntities");

            migrationBuilder.RenameTable(
                name: "phenlogicalStageEntities",
                newName: "phenologicalStageEntities");

            migrationBuilder.RenameIndex(
                name: "IX_PhenologicalEntity_phenologicalStageEntity_Id",
                table: "phenologicalEntities",
                newName: "IX_phenologicalEntities_phenologicalStageEntity_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phenologicalEntities",
                table: "phenologicalEntities",
                column: "PhenologicalEntity_Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_phenologicalEntities",
                table: "phenologicalEntities");

            migrationBuilder.RenameTable(
                name: "phenologicalStageEntities",
                newName: "phenlogicalStageEntities");

            migrationBuilder.RenameTable(
                name: "phenologicalEntities",
                newName: "PhenologicalEntity");

            migrationBuilder.RenameIndex(
                name: "IX_phenologicalEntities_phenologicalStageEntity_Id",
                table: "PhenologicalEntity",
                newName: "IX_PhenologicalEntity_phenologicalStageEntity_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_phenlogicalStageEntities",
                table: "phenlogicalStageEntities",
                column: "phenologicalStageEntity_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PhenologicalEntity",
                table: "PhenologicalEntity",
                column: "PhenologicalEntity_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_observationEntity_PhenologicalEntity_phenologicalEntity_Id",
                table: "observationEntity",
                column: "phenologicalEntity_Id",
                principalTable: "PhenologicalEntity",
                principalColumn: "PhenologicalEntity_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PhenologicalEntity_phenlogicalStageEntities_phenologicalSta~",
                table: "PhenologicalEntity",
                column: "phenologicalStageEntity_Id",
                principalTable: "phenlogicalStageEntities",
                principalColumn: "phenologicalStageEntity_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
