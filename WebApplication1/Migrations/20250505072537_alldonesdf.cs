using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldonesdf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_DisorderEntity_PhysiologicalDisorderdisorde~",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_InsectsEntity_Insectsinsect_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_diseasesEntities_Diseasesdisease_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_FertilizerEntity_fertilizer_id1",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_MicroNutrientsEntity_MicroNutrie~",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_WeedControlEnity_WeedControlweed~",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_fertilizer_id1",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_MicroNutrientmicro_nutrient_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_WeedControlweed_control_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_Diseasesdisease_id",
                table: "healthandEntity");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_Insectsinsect_id",
                table: "healthandEntity");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_PhysiologicalDisorderdisorder_id",
                table: "healthandEntity");

            migrationBuilder.DropColumn(
                name: "MicroNutrientmicro_nutrient_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "WeedControlweed_control_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "fertilizer_id1",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "Diseasesdisease_id",
                table: "healthandEntity");

            migrationBuilder.DropColumn(
                name: "Insectsinsect_id",
                table: "healthandEntity");

            migrationBuilder.DropColumn(
                name: "PhysiologicalDisorderdisorder_id",
                table: "healthandEntity");

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_fertilizer_id",
                table: "managementPraticesEntities",
                column: "fertilizer_id");

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_micro_nutrient_id",
                table: "managementPraticesEntities",
                column: "micro_nutrient_id");

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_weed_control_id",
                table: "managementPraticesEntities",
                column: "weed_control_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_disease_id",
                table: "healthandEntity",
                column: "disease_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_insect_id",
                table: "healthandEntity",
                column: "insect_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_physiological_disorder_id",
                table: "healthandEntity",
                column: "physiological_disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_DisorderEntity_physiological_disorder_id",
                table: "healthandEntity",
                column: "physiological_disorder_id",
                principalTable: "DisorderEntity",
                principalColumn: "disorder_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_InsectsEntity_insect_id",
                table: "healthandEntity",
                column: "insect_id",
                principalTable: "InsectsEntity",
                principalColumn: "insect_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_diseasesEntities_disease_id",
                table: "healthandEntity",
                column: "disease_id",
                principalTable: "diseasesEntities",
                principalColumn: "disease_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_FertilizerEntity_fertilizer_id",
                table: "managementPraticesEntities",
                column: "fertilizer_id",
                principalTable: "FertilizerEntity",
                principalColumn: "fertilizer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_MicroNutrientsEntity_micro_nutri~",
                table: "managementPraticesEntities",
                column: "micro_nutrient_id",
                principalTable: "MicroNutrientsEntity",
                principalColumn: "micro_nutrient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_WeedControlEnity_weed_control_id",
                table: "managementPraticesEntities",
                column: "weed_control_id",
                principalTable: "WeedControlEnity",
                principalColumn: "weed_control_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_DisorderEntity_physiological_disorder_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_InsectsEntity_insect_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_diseasesEntities_disease_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_FertilizerEntity_fertilizer_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_MicroNutrientsEntity_micro_nutri~",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_WeedControlEnity_weed_control_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_fertilizer_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_micro_nutrient_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_managementPraticesEntities_weed_control_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_disease_id",
                table: "healthandEntity");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_insect_id",
                table: "healthandEntity");

            migrationBuilder.DropIndex(
                name: "IX_healthandEntity_physiological_disorder_id",
                table: "healthandEntity");

            migrationBuilder.AddColumn<int>(
                name: "MicroNutrientmicro_nutrient_id",
                table: "managementPraticesEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeedControlweed_control_id",
                table: "managementPraticesEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "fertilizer_id1",
                table: "managementPraticesEntities",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Diseasesdisease_id",
                table: "healthandEntity",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Insectsinsect_id",
                table: "healthandEntity",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PhysiologicalDisorderdisorder_id",
                table: "healthandEntity",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_fertilizer_id1",
                table: "managementPraticesEntities",
                column: "fertilizer_id1");

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_MicroNutrientmicro_nutrient_id",
                table: "managementPraticesEntities",
                column: "MicroNutrientmicro_nutrient_id");

            migrationBuilder.CreateIndex(
                name: "IX_managementPraticesEntities_WeedControlweed_control_id",
                table: "managementPraticesEntities",
                column: "WeedControlweed_control_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_Diseasesdisease_id",
                table: "healthandEntity",
                column: "Diseasesdisease_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_Insectsinsect_id",
                table: "healthandEntity",
                column: "Insectsinsect_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_PhysiologicalDisorderdisorder_id",
                table: "healthandEntity",
                column: "PhysiologicalDisorderdisorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_DisorderEntity_PhysiologicalDisorderdisorde~",
                table: "healthandEntity",
                column: "PhysiologicalDisorderdisorder_id",
                principalTable: "DisorderEntity",
                principalColumn: "disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_InsectsEntity_Insectsinsect_id",
                table: "healthandEntity",
                column: "Insectsinsect_id",
                principalTable: "InsectsEntity",
                principalColumn: "insect_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_diseasesEntities_Diseasesdisease_id",
                table: "healthandEntity",
                column: "Diseasesdisease_id",
                principalTable: "diseasesEntities",
                principalColumn: "disease_id");

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_FertilizerEntity_fertilizer_id1",
                table: "managementPraticesEntities",
                column: "fertilizer_id1",
                principalTable: "FertilizerEntity",
                principalColumn: "fertilizer_id");

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_MicroNutrientsEntity_MicroNutrie~",
                table: "managementPraticesEntities",
                column: "MicroNutrientmicro_nutrient_id",
                principalTable: "MicroNutrientsEntity",
                principalColumn: "micro_nutrient_id");

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_WeedControlEnity_WeedControlweed~",
                table: "managementPraticesEntities",
                column: "WeedControlweed_control_id",
                principalTable: "WeedControlEnity",
                principalColumn: "weed_control_id");
        }
    }
}
