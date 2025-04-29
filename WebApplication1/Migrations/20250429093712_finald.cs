using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class finald : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cropDiseasesEntities_cropsEntity_crop_id1",
                table: "cropDiseasesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDiseasesEntities_diseasesEntities_disease_id1",
                table: "cropDiseasesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDisorderEntities_PhysiologicalDisorderEntity_disorder_i~",
                table: "cropDisorderEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDisorderEntities_cropsEntity_crop_id1",
                table: "cropDisorderEntities");

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

            migrationBuilder.DropIndex(
                name: "IX_cropDisorderEntities_crop_id1",
                table: "cropDisorderEntities");

            migrationBuilder.DropIndex(
                name: "IX_cropDisorderEntities_disorder_id1",
                table: "cropDisorderEntities");

            migrationBuilder.DropIndex(
                name: "IX_cropDiseasesEntities_crop_id1",
                table: "cropDiseasesEntities");

            migrationBuilder.DropIndex(
                name: "IX_cropDiseasesEntities_disease_id1",
                table: "cropDiseasesEntities");

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

            migrationBuilder.DropColumn(
                name: "crop_id1",
                table: "cropDisorderEntities");

            migrationBuilder.DropColumn(
                name: "disorder_id1",
                table: "cropDisorderEntities");

            migrationBuilder.DropColumn(
                name: "crop_id1",
                table: "cropDiseasesEntities");

            migrationBuilder.DropColumn(
                name: "disease_id1",
                table: "cropDiseasesEntities");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_crop_id",
                table: "treesTables",
                column: "crop_id");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_expert_id",
                table: "treesTables",
                column: "expert_id");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_rootstock_id",
                table: "treesTables",
                column: "rootstock_id");

            migrationBuilder.CreateIndex(
                name: "IX_treesTables_variety_id",
                table: "treesTables",
                column: "variety_id");

            migrationBuilder.CreateIndex(
                name: "IX_cropDisorderEntities_disorder_id",
                table: "cropDisorderEntities",
                column: "disorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_cropDiseasesEntities_disease_id",
                table: "cropDiseasesEntities",
                column: "disease_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cropDiseasesEntities_cropsEntity_crop_id",
                table: "cropDiseasesEntities",
                column: "crop_id",
                principalTable: "cropsEntity",
                principalColumn: "crop_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cropDiseasesEntities_diseasesEntities_disease_id",
                table: "cropDiseasesEntities",
                column: "disease_id",
                principalTable: "diseasesEntities",
                principalColumn: "disease_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cropDisorderEntities_PhysiologicalDisorderEntity_disorder_id",
                table: "cropDisorderEntities",
                column: "disorder_id",
                principalTable: "PhysiologicalDisorderEntity",
                principalColumn: "disorder_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cropDisorderEntities_cropsEntity_crop_id",
                table: "cropDisorderEntities",
                column: "crop_id",
                principalTable: "cropsEntity",
                principalColumn: "crop_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_cropsEntity_crop_id",
                table: "treesTables",
                column: "crop_id",
                principalTable: "cropsEntity",
                principalColumn: "crop_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_expertEntity_expert_id",
                table: "treesTables",
                column: "expert_id",
                principalTable: "expertEntity",
                principalColumn: "expert_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_rootstocksEntity_rootstock_id",
                table: "treesTables",
                column: "rootstock_id",
                principalTable: "rootstocksEntity",
                principalColumn: "rootstock_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_treesTables_varietiesEntity_variety_id",
                table: "treesTables",
                column: "variety_id",
                principalTable: "varietiesEntity",
                principalColumn: "variety_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cropDiseasesEntities_cropsEntity_crop_id",
                table: "cropDiseasesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDiseasesEntities_diseasesEntities_disease_id",
                table: "cropDiseasesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDisorderEntities_PhysiologicalDisorderEntity_disorder_id",
                table: "cropDisorderEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_cropDisorderEntities_cropsEntity_crop_id",
                table: "cropDisorderEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_cropsEntity_crop_id",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_expertEntity_expert_id",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_rootstocksEntity_rootstock_id",
                table: "treesTables");

            migrationBuilder.DropForeignKey(
                name: "FK_treesTables_varietiesEntity_variety_id",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_crop_id",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_expert_id",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_rootstock_id",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_treesTables_variety_id",
                table: "treesTables");

            migrationBuilder.DropIndex(
                name: "IX_cropDisorderEntities_disorder_id",
                table: "cropDisorderEntities");

            migrationBuilder.DropIndex(
                name: "IX_cropDiseasesEntities_disease_id",
                table: "cropDiseasesEntities");

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

            migrationBuilder.AddColumn<int>(
                name: "crop_id1",
                table: "cropDisorderEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "disorder_id1",
                table: "cropDisorderEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "crop_id1",
                table: "cropDiseasesEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "disease_id1",
                table: "cropDiseasesEntities",
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

            migrationBuilder.CreateIndex(
                name: "IX_cropDisorderEntities_crop_id1",
                table: "cropDisorderEntities",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cropDisorderEntities_disorder_id1",
                table: "cropDisorderEntities",
                column: "disorder_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cropDiseasesEntities_crop_id1",
                table: "cropDiseasesEntities",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cropDiseasesEntities_disease_id1",
                table: "cropDiseasesEntities",
                column: "disease_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_cropDiseasesEntities_cropsEntity_crop_id1",
                table: "cropDiseasesEntities",
                column: "crop_id1",
                principalTable: "cropsEntity",
                principalColumn: "crop_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cropDiseasesEntities_diseasesEntities_disease_id1",
                table: "cropDiseasesEntities",
                column: "disease_id1",
                principalTable: "diseasesEntities",
                principalColumn: "disease_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cropDisorderEntities_PhysiologicalDisorderEntity_disorder_i~",
                table: "cropDisorderEntities",
                column: "disorder_id1",
                principalTable: "PhysiologicalDisorderEntity",
                principalColumn: "disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_cropDisorderEntities_cropsEntity_crop_id1",
                table: "cropDisorderEntities",
                column: "crop_id1",
                principalTable: "cropsEntity",
                principalColumn: "crop_id");

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
    }
}
