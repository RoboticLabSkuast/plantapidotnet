using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                name: "diseasesEntities",
                columns: table => new
                {
                    disease_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diseasesEntities", x => x.disease_id);
                });

            migrationBuilder.CreateTable(
                name: "expertEntity",
                columns: table => new
                {
                    expert_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(type: "text", nullable: false),
                    role = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    specialization = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    bio = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_expertEntity", x => x.expert_id);
                });

            migrationBuilder.CreateTable(
                name: "healthandEntity",
                columns: table => new
                {
                    healthandDiseaseEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ObservedDisease = table.Column<string>(type: "text", nullable: false),
                    ObservedDiseaseLevel = table.Column<int>(type: "integer", nullable: false),
                    Insects = table.Column<string>(type: "text", nullable: false),
                    InsectsLevel = table.Column<int>(type: "integer", nullable: false),
                    PhysiologicalDisorder = table.Column<string>(type: "text", nullable: false),
                    PhysiologicalDisorderLevel = table.Column<int>(type: "integer", nullable: false),
                    NurientDefiency = table.Column<string>(type: "text", nullable: false),
                    DamageReport = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_healthandEntity", x => x.healthandDiseaseEntity_Id);
                });

            migrationBuilder.CreateTable(
                name: "managementPraticesEntities",
                columns: table => new
                {
                    managementPraticesEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fertilizer = table.Column<string>(type: "text", nullable: false),
                    fertilizerDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    fertilizerAmount = table.Column<int>(type: "integer", nullable: false),
                    micronutrients = table.Column<string>(type: "text", nullable: false),
                    micronutrientsDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    micronutrientsAmount = table.Column<int>(type: "integer", nullable: false),
                    weedControl = table.Column<string>(type: "text", nullable: false),
                    weedControlDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    weedControlAmount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_managementPraticesEntities", x => x.managementPraticesEntity_Id);
                });

            migrationBuilder.CreateTable(
                name: "phenlogicalStageEntities",
                columns: table => new
                {
                    phenologicalStageEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    stage = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phenlogicalStageEntities", x => x.phenologicalStageEntity_Id);
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
                name: "yieldandProductivityEntities",
                columns: table => new
                {
                    yieldandProductivityEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fruitSetPercent = table.Column<int>(type: "integer", nullable: false),
                    harvestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    yieldAmount = table.Column<int>(type: "integer", nullable: false),
                    FruitQuality = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_yieldandProductivityEntities", x => x.yieldandProductivityEntity_Id);
                });

            migrationBuilder.CreateTable(
                name: "PhenologicalEntity",
                columns: table => new
                {
                    PhenologicalEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    phenologicalStageEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    StageDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    growthScale = table.Column<int>(type: "integer", nullable: false),
                    blossomDensity = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhenologicalEntity", x => x.PhenologicalEntity_Id);
                    table.ForeignKey(
                        name: "FK_PhenologicalEntity_phenlogicalStageEntities_phenologicalSta~",
                        column: x => x.phenologicalStageEntity_Id,
                        principalTable: "phenlogicalStageEntities",
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
                name: "observationEntity",
                columns: table => new
                {
                    observationEntity_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    yieldandProductivityEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    phenologicalEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    managementPraticesEntity_Id = table.Column<int>(type: "integer", nullable: false),
                    healthandDiseaseEntity_Id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationEntity", x => x.observationEntity_Id);
                    table.ForeignKey(
                        name: "FK_observationEntity_PhenologicalEntity_phenologicalEntity_Id",
                        column: x => x.phenologicalEntity_Id,
                        principalTable: "PhenologicalEntity",
                        principalColumn: "PhenologicalEntity_Id",
                        onDelete: ReferentialAction.Restrict);
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
                        name: "FK_observationEntity_yieldandProductivityEntities_yieldandProd~",
                        column: x => x.yieldandProductivityEntity_Id,
                        principalTable: "yieldandProductivityEntities",
                        principalColumn: "yieldandProductivityEntity_Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_observationEntity_phenologicalEntity_Id",
                table: "observationEntity",
                column: "phenologicalEntity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_observationEntity_yieldandProductivityEntity_Id",
                table: "observationEntity",
                column: "yieldandProductivityEntity_Id");

            migrationBuilder.CreateIndex(
                name: "IX_PhenologicalEntity_phenologicalStageEntity_Id",
                table: "PhenologicalEntity",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "diseasesEntities");

            migrationBuilder.DropTable(
                name: "observationEntity");

            migrationBuilder.DropTable(
                name: "treesTables");

            migrationBuilder.DropTable(
                name: "PhenologicalEntity");

            migrationBuilder.DropTable(
                name: "healthandEntity");

            migrationBuilder.DropTable(
                name: "managementPraticesEntities");

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
                name: "phenlogicalStageEntities");
        }
    }
}
