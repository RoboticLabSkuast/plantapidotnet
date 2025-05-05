using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldonesd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fertilizer",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "fertilizerDateTime",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "micronutrients",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "micronutrientsDateTime",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "weedControl",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "weedControlDateTime",
                table: "managementPraticesEntities");

            migrationBuilder.DropColumn(
                name: "Insects",
                table: "healthandEntity");

            migrationBuilder.DropColumn(
                name: "ObservedDisease",
                table: "healthandEntity");

            migrationBuilder.DropColumn(
                name: "PhysiologicalDisorder",
                table: "healthandEntity");

            migrationBuilder.RenameColumn(
                name: "weedControlAmount",
                table: "managementPraticesEntities",
                newName: "weed_control_id");

            migrationBuilder.RenameColumn(
                name: "micronutrientsAmount",
                table: "managementPraticesEntities",
                newName: "micro_nutrient_id");

            migrationBuilder.RenameColumn(
                name: "fertilizerAmount",
                table: "managementPraticesEntities",
                newName: "fertilizer_id");

            migrationBuilder.RenameColumn(
                name: "PhysiologicalDisorderLevel",
                table: "healthandEntity",
                newName: "physiological_disorder_id");

            migrationBuilder.RenameColumn(
                name: "ObservedDiseaseLevel",
                table: "healthandEntity",
                newName: "insect_id");

            migrationBuilder.RenameColumn(
                name: "InsectsLevel",
                table: "healthandEntity",
                newName: "disease_id");

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

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "diseasesEntities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "diseasesEntities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "level",
                table: "diseasesEntities",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DisorderEntity",
                columns: table => new
                {
                    disorder_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisorderEntity", x => x.disorder_id);
                });

            migrationBuilder.CreateTable(
                name: "FertilizerEntity",
                columns: table => new
                {
                    fertilizer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    fertilizerDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FertilizerEntity", x => x.fertilizer_id);
                });

            migrationBuilder.CreateTable(
                name: "InsectsEntity",
                columns: table => new
                {
                    insect_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsectsEntity", x => x.insect_id);
                });

            migrationBuilder.CreateTable(
                name: "MicroNutrientsEntity",
                columns: table => new
                {
                    micro_nutrient_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    microNutrientDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MicroNutrientsEntity", x => x.micro_nutrient_id);
                });

            migrationBuilder.CreateTable(
                name: "WeedControlEnity",
                columns: table => new
                {
                    weed_control_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    weedControlDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeedControlEnity", x => x.weed_control_id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "DisorderEntity");

            migrationBuilder.DropTable(
                name: "FertilizerEntity");

            migrationBuilder.DropTable(
                name: "InsectsEntity");

            migrationBuilder.DropTable(
                name: "MicroNutrientsEntity");

            migrationBuilder.DropTable(
                name: "WeedControlEnity");

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

            migrationBuilder.DropColumn(
                name: "level",
                table: "diseasesEntities");

            migrationBuilder.RenameColumn(
                name: "weed_control_id",
                table: "managementPraticesEntities",
                newName: "weedControlAmount");

            migrationBuilder.RenameColumn(
                name: "micro_nutrient_id",
                table: "managementPraticesEntities",
                newName: "micronutrientsAmount");

            migrationBuilder.RenameColumn(
                name: "fertilizer_id",
                table: "managementPraticesEntities",
                newName: "fertilizerAmount");

            migrationBuilder.RenameColumn(
                name: "physiological_disorder_id",
                table: "healthandEntity",
                newName: "PhysiologicalDisorderLevel");

            migrationBuilder.RenameColumn(
                name: "insect_id",
                table: "healthandEntity",
                newName: "ObservedDiseaseLevel");

            migrationBuilder.RenameColumn(
                name: "disease_id",
                table: "healthandEntity",
                newName: "InsectsLevel");

            migrationBuilder.AddColumn<string>(
                name: "fertilizer",
                table: "managementPraticesEntities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "fertilizerDateTime",
                table: "managementPraticesEntities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "micronutrients",
                table: "managementPraticesEntities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "micronutrientsDateTime",
                table: "managementPraticesEntities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "weedControl",
                table: "managementPraticesEntities",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "weedControlDateTime",
                table: "managementPraticesEntities",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Insects",
                table: "healthandEntity",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ObservedDisease",
                table: "healthandEntity",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhysiologicalDisorder",
                table: "healthandEntity",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "diseasesEntities",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "diseasesEntities",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
