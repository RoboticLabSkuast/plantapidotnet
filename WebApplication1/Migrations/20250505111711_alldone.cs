using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alldone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cropsEntity",
                columns: table => new
                {
                    crop_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    qrcodeTree = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cropsEntity", x => x.crop_id);
                });

            migrationBuilder.CreateTable(
                name: "diseaseNameEntities",
                columns: table => new
                {
                    diseaseName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diseaseNameEntities", x => x.diseaseName_id);
                });

            migrationBuilder.CreateTable(
                name: "disorderNameEntities",
                columns: table => new
                {
                    disorderName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disorderNameEntities", x => x.disorderName_id);
                });

            migrationBuilder.CreateTable(
                name: "expertEntity",
                columns: table => new
                {
                    expert_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    username = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    year = table.Column<string>(type: "text", nullable: false),
                    department = table.Column<string>(type: "text", nullable: false),
                    bio = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expertEntity", x => x.expert_id);
                });

            migrationBuilder.CreateTable(
                name: "fertilizerNameEntities",
                columns: table => new
                {
                    fertilizerName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fertilizerNameEntities", x => x.fertilizerName_id);
                });

            migrationBuilder.CreateTable(
                name: "insectNameEntities",
                columns: table => new
                {
                    insectName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insectNameEntities", x => x.insectName_id);
                });

            migrationBuilder.CreateTable(
                name: "microNutrientNameEntities",
                columns: table => new
                {
                    microNutrientName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_microNutrientNameEntities", x => x.microNutrientName_id);
                });

            migrationBuilder.CreateTable(
                name: "phenologicalStageEntity",
                columns: table => new
                {
                    phenologicalStageEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stageName = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phenologicalStageEntity", x => x.phenologicalStageEntity_Id);
                });

            migrationBuilder.CreateTable(
                name: "rootstocksEntity",
                columns: table => new
                {
                    rootstock_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rootstocksEntity", x => x.rootstock_id);
                });

            migrationBuilder.CreateTable(
                name: "varietiesEntity",
                columns: table => new
                {
                    variety_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_varietiesEntity", x => x.variety_id);
                });

            migrationBuilder.CreateTable(
                name: "weedControlNameEntities",
                columns: table => new
                {
                    weedControlName_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weedControlNameEntities", x => x.weedControlName_id);
                });

            migrationBuilder.CreateTable(
                name: "yieldandProductivityEntities",
                columns: table => new
                {
                    yieldandProductivityEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fruitSetPercent = table.Column<int>(type: "integer", nullable: false),
                    harvestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    yieldAmount = table.Column<int>(type: "integer", nullable: false),
                    FruitQuality = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yieldandProductivityEntities", x => x.yieldandProductivityEntity_Id);
                });

            migrationBuilder.CreateTable(
                name: "diseasesEntities",
                columns: table => new
                {
                    disease_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    diseaseName_id = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diseasesEntities", x => x.disease_id);
                    table.ForeignKey(
                        name: "FK_diseasesEntities_diseaseNameEntities_diseaseName_id",
                        column: x => x.diseaseName_id,
                        principalTable: "diseaseNameEntities",
                        principalColumn: "diseaseName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "disorderEntities",
                columns: table => new
                {
                    disorder_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    disorderName_id = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disorderEntities", x => x.disorder_id);
                    table.ForeignKey(
                        name: "FK_disorderEntities_disorderNameEntities_disorderName_id",
                        column: x => x.disorderName_id,
                        principalTable: "disorderNameEntities",
                        principalColumn: "disorderName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "fertilizerEntities",
                columns: table => new
                {
                    fertilizer_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fertilizerName_id = table.Column<int>(type: "integer", nullable: false),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    fertilizerDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fertilizerEntities", x => x.fertilizer_id);
                    table.ForeignKey(
                        name: "FK_fertilizerEntities_fertilizerNameEntities_fertilizerName_id",
                        column: x => x.fertilizerName_id,
                        principalTable: "fertilizerNameEntities",
                        principalColumn: "fertilizerName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "insectsEntities",
                columns: table => new
                {
                    insect_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    insectName_id = table.Column<int>(type: "integer", nullable: false),
                    level = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insectsEntities", x => x.insect_id);
                    table.ForeignKey(
                        name: "FK_insectsEntities_insectNameEntities_insectName_id",
                        column: x => x.insectName_id,
                        principalTable: "insectNameEntities",
                        principalColumn: "insectName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "microNutrientsEntities",
                columns: table => new
                {
                    micro_nutrient_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    microNutrientName_id = table.Column<int>(type: "integer", nullable: false),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    microNutrientDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_microNutrientsEntities", x => x.micro_nutrient_id);
                    table.ForeignKey(
                        name: "FK_microNutrientsEntities_microNutrientNameEntities_microNutri~",
                        column: x => x.microNutrientName_id,
                        principalTable: "microNutrientNameEntities",
                        principalColumn: "microNutrientName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phenologicalEntities",
                columns: table => new
                {
                    phenologicalEntities_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StageDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    growthScale = table.Column<int>(type: "integer", nullable: false),
                    blossomDensity = table.Column<int>(type: "integer", nullable: false),
                    phenologicalStageEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phenologicalEntities", x => x.phenologicalEntities_Id);
                    table.ForeignKey(
                        name: "FK_phenologicalEntities_phenologicalStageEntity_phenologicalSt~",
                        column: x => x.phenologicalStageEntity_Id,
                        principalTable: "phenologicalStageEntity",
                        principalColumn: "phenologicalStageEntity_Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    table.ForeignKey(
                        name: "FK_treesTables_cropsEntity_crop_id",
                        column: x => x.crop_id,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_treesTables_expertEntity_expert_id",
                        column: x => x.expert_id,
                        principalTable: "expertEntity",
                        principalColumn: "expert_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_treesTables_rootstocksEntity_rootstock_id",
                        column: x => x.rootstock_id,
                        principalTable: "rootstocksEntity",
                        principalColumn: "rootstock_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_treesTables_varietiesEntity_variety_id",
                        column: x => x.variety_id,
                        principalTable: "varietiesEntity",
                        principalColumn: "variety_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "weedControlEntities",
                columns: table => new
                {
                    weed_control_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    weedControlName_id = table.Column<int>(type: "integer", nullable: false),
                    amountUsed = table.Column<int>(type: "integer", nullable: false),
                    weedControlDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weedControlEntities", x => x.weed_control_id);
                    table.ForeignKey(
                        name: "FK_weedControlEntities_weedControlNameEntities_weedControlName~",
                        column: x => x.weedControlName_id,
                        principalTable: "weedControlNameEntities",
                        principalColumn: "weedControlName_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "healthandEntity",
                columns: table => new
                {
                    healthandDiseaseEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    disease_id = table.Column<int>(type: "integer", nullable: false),
                    insect_id = table.Column<int>(type: "integer", nullable: false),
                    disorder_id = table.Column<int>(type: "integer", nullable: false),
                    NurientDefiency = table.Column<string>(type: "text", nullable: false),
                    DamageReport = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthandEntity", x => x.healthandDiseaseEntity_Id);
                    table.ForeignKey(
                        name: "FK_healthandEntity_diseasesEntities_disease_id",
                        column: x => x.disease_id,
                        principalTable: "diseasesEntities",
                        principalColumn: "disease_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthandEntity_disorderEntities_disorder_id",
                        column: x => x.disorder_id,
                        principalTable: "disorderEntities",
                        principalColumn: "disorder_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_healthandEntity_insectsEntities_insect_id",
                        column: x => x.insect_id,
                        principalTable: "insectsEntities",
                        principalColumn: "insect_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "managementPraticesEntities",
                columns: table => new
                {
                    managementPraticesEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fertilizer_id = table.Column<int>(type: "integer", nullable: false),
                    micro_nutrient_id = table.Column<int>(type: "integer", nullable: false),
                    weed_control_id = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managementPraticesEntities", x => x.managementPraticesEntity_Id);
                    table.ForeignKey(
                        name: "FK_managementPraticesEntities_fertilizerEntities_fertilizer_id",
                        column: x => x.fertilizer_id,
                        principalTable: "fertilizerEntities",
                        principalColumn: "fertilizer_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_managementPraticesEntities_microNutrientsEntities_micro_nut~",
                        column: x => x.micro_nutrient_id,
                        principalTable: "microNutrientsEntities",
                        principalColumn: "micro_nutrient_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_managementPraticesEntities_weedControlEntities_weed_control~",
                        column: x => x.weed_control_id,
                        principalTable: "weedControlEntities",
                        principalColumn: "weed_control_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "observationEntity",
                columns: table => new
                {
                    observationEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    yieldandProductivityEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    phenologicalEntities_Id = table.Column<int>(type: "integer", nullable: false),
                    managementPraticesEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    healthandDiseaseEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationEntity", x => x.observationEntity_Id);
                    table.ForeignKey(
                        name: "FK_observationEntity_cropsEntity_crop_id",
                        column: x => x.crop_id,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_observationEntity_healthandEntity_healthandDiseaseEntity_Id",
                        column: x => x.healthandDiseaseEntity_Id,
                        principalTable: "healthandEntity",
                        principalColumn: "healthandDiseaseEntity_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_observationEntity_managementPraticesEntities_managementPrat~",
                        column: x => x.managementPraticesEntity_Id,
                        principalTable: "managementPraticesEntities",
                        principalColumn: "managementPraticesEntity_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_observationEntity_phenologicalEntities_phenologicalEntities~",
                        column: x => x.phenologicalEntities_Id,
                        principalTable: "phenologicalEntities",
                        principalColumn: "phenologicalEntities_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_observationEntity_yieldandProductivityEntities_yieldandProd~",
                        column: x => x.yieldandProductivityEntity_Id,
                        principalTable: "yieldandProductivityEntities",
                        principalColumn: "yieldandProductivityEntity_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_diseasesEntities_diseaseName_id",
                table: "diseasesEntities",
                column: "diseaseName_id");

            migrationBuilder.CreateIndex(
                name: "IX_disorderEntities_disorderName_id",
                table: "disorderEntities",
                column: "disorderName_id");

            migrationBuilder.CreateIndex(
                name: "IX_fertilizerEntities_fertilizerName_id",
                table: "fertilizerEntities",
                column: "fertilizerName_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_disease_id",
                table: "healthandEntity",
                column: "disease_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_disorder_id",
                table: "healthandEntity",
                column: "disorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_healthandEntity_insect_id",
                table: "healthandEntity",
                column: "insect_id");

            migrationBuilder.CreateIndex(
                name: "IX_insectsEntities_insectName_id",
                table: "insectsEntities",
                column: "insectName_id");

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
                name: "IX_microNutrientsEntities_microNutrientName_id",
                table: "microNutrientsEntities",
                column: "microNutrientName_id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_crop_id",
                table: "observationEntity",
                column: "crop_id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_healthandDiseaseEntity_Id",
                table: "observationEntity",
                column: "healthandDiseaseEntity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_managementPraticesEntity_Id",
                table: "observationEntity",
                column: "managementPraticesEntity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_phenologicalEntities_Id",
                table: "observationEntity",
                column: "phenologicalEntities_Id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_yieldandProductivityEntity_Id",
                table: "observationEntity",
                column: "yieldandProductivityEntity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_phenologicalEntities_phenologicalStageEntity_Id",
                table: "phenologicalEntities",
                column: "phenologicalStageEntity_Id");

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
                name: "IX_weedControlEntities_weedControlName_id",
                table: "weedControlEntities",
                column: "weedControlName_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "observationEntity");

            migrationBuilder.DropTable(
                name: "treesTables");

            migrationBuilder.DropTable(
                name: "healthandEntity");

            migrationBuilder.DropTable(
                name: "managementPraticesEntities");

            migrationBuilder.DropTable(
                name: "phenologicalEntities");

            migrationBuilder.DropTable(
                name: "yieldandProductivityEntities");

            migrationBuilder.DropTable(
                name: "cropsEntity");

            migrationBuilder.DropTable(
                name: "expertEntity");

            migrationBuilder.DropTable(
                name: "rootstocksEntity");

            migrationBuilder.DropTable(
                name: "varietiesEntity");

            migrationBuilder.DropTable(
                name: "diseasesEntities");

            migrationBuilder.DropTable(
                name: "disorderEntities");

            migrationBuilder.DropTable(
                name: "insectsEntities");

            migrationBuilder.DropTable(
                name: "fertilizerEntities");

            migrationBuilder.DropTable(
                name: "microNutrientsEntities");

            migrationBuilder.DropTable(
                name: "weedControlEntities");

            migrationBuilder.DropTable(
                name: "phenologicalStageEntity");

            migrationBuilder.DropTable(
                name: "diseaseNameEntities");

            migrationBuilder.DropTable(
                name: "disorderNameEntities");

            migrationBuilder.DropTable(
                name: "insectNameEntities");

            migrationBuilder.DropTable(
                name: "fertilizerNameEntities");

            migrationBuilder.DropTable(
                name: "microNutrientNameEntities");

            migrationBuilder.DropTable(
                name: "weedControlNameEntities");
        }
    }
}
