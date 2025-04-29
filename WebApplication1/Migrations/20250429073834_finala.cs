using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class finala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_cropDisorderEntities_disorder_id",
                table: "cropDisorderEntities");

            migrationBuilder.DropIndex(
                name: "IX_cropDiseasesEntities_disease_id",
                table: "cropDiseasesEntities");

            migrationBuilder.AddColumn<string>(
                name: "qrcodeTree",
                table: "cropsEntity",
                type: "text",
                nullable: false,
                defaultValue: "");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "qrcodeTree",
                table: "cropsEntity");

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
        }
    }
}
