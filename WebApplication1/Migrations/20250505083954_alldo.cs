using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_DisorderEntity_disorder_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_InsectsEntity_insect_id",
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_WeedControlEnity",
                table: "WeedControlEnity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MicroNutrientsEntity",
                table: "MicroNutrientsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InsectsEntity",
                table: "InsectsEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FertilizerEntity",
                table: "FertilizerEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisorderEntity",
                table: "DisorderEntity");

            migrationBuilder.RenameTable(
                name: "WeedControlEnity",
                newName: "weedControlEntities");

            migrationBuilder.RenameTable(
                name: "MicroNutrientsEntity",
                newName: "microNutrientsEntities");

            migrationBuilder.RenameTable(
                name: "InsectsEntity",
                newName: "insectsEntities");

            migrationBuilder.RenameTable(
                name: "FertilizerEntity",
                newName: "fertilizerEntities");

            migrationBuilder.RenameTable(
                name: "DisorderEntity",
                newName: "disorderEntities");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weedControlEntities",
                table: "weedControlEntities",
                column: "weed_control_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_microNutrientsEntities",
                table: "microNutrientsEntities",
                column: "micro_nutrient_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_insectsEntities",
                table: "insectsEntities",
                column: "insect_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_fertilizerEntities",
                table: "fertilizerEntities",
                column: "fertilizer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_disorderEntities",
                table: "disorderEntities",
                column: "disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_disorderEntities_disorder_id",
                table: "healthandEntity",
                column: "disorder_id",
                principalTable: "disorderEntities",
                principalColumn: "disorder_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_insectsEntities_insect_id",
                table: "healthandEntity",
                column: "insect_id",
                principalTable: "insectsEntities",
                principalColumn: "insect_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_fertilizerEntities_fertilizer_id",
                table: "managementPraticesEntities",
                column: "fertilizer_id",
                principalTable: "fertilizerEntities",
                principalColumn: "fertilizer_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_microNutrientsEntities_micro_nut~",
                table: "managementPraticesEntities",
                column: "micro_nutrient_id",
                principalTable: "microNutrientsEntities",
                principalColumn: "micro_nutrient_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_managementPraticesEntities_weedControlEntities_weed_control~",
                table: "managementPraticesEntities",
                column: "weed_control_id",
                principalTable: "weedControlEntities",
                principalColumn: "weed_control_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_disorderEntities_disorder_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_healthandEntity_insectsEntities_insect_id",
                table: "healthandEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_fertilizerEntities_fertilizer_id",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_microNutrientsEntities_micro_nut~",
                table: "managementPraticesEntities");

            migrationBuilder.DropForeignKey(
                name: "FK_managementPraticesEntities_weedControlEntities_weed_control~",
                table: "managementPraticesEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_weedControlEntities",
                table: "weedControlEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_microNutrientsEntities",
                table: "microNutrientsEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_insectsEntities",
                table: "insectsEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_fertilizerEntities",
                table: "fertilizerEntities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_disorderEntities",
                table: "disorderEntities");

            migrationBuilder.RenameTable(
                name: "weedControlEntities",
                newName: "WeedControlEnity");

            migrationBuilder.RenameTable(
                name: "microNutrientsEntities",
                newName: "MicroNutrientsEntity");

            migrationBuilder.RenameTable(
                name: "insectsEntities",
                newName: "InsectsEntity");

            migrationBuilder.RenameTable(
                name: "fertilizerEntities",
                newName: "FertilizerEntity");

            migrationBuilder.RenameTable(
                name: "disorderEntities",
                newName: "DisorderEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WeedControlEnity",
                table: "WeedControlEnity",
                column: "weed_control_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MicroNutrientsEntity",
                table: "MicroNutrientsEntity",
                column: "micro_nutrient_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InsectsEntity",
                table: "InsectsEntity",
                column: "insect_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FertilizerEntity",
                table: "FertilizerEntity",
                column: "fertilizer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisorderEntity",
                table: "DisorderEntity",
                column: "disorder_id");

            migrationBuilder.AddForeignKey(
                name: "FK_healthandEntity_DisorderEntity_disorder_id",
                table: "healthandEntity",
                column: "disorder_id",
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
    }
}
