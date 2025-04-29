using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreeDatas");

            migrationBuilder.DropTable(
                name: "Trees");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "cropsEntity",
                columns: table => new
                {
                    crop_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    crop_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cropsEntity", x => x.crop_id);
                    table.ForeignKey(
                        name: "FK_cropsEntity_cropsEntity_crop_id1",
                        column: x => x.crop_id1,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id");
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
                name: "observationEntity",
                columns: table => new
                {
                    observation_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    variety_id = table.Column<int>(type: "integer", nullable: false),
                    rootstock_id = table.Column<int>(type: "integer", nullable: false),
                    stage_id = table.Column<int>(type: "integer", nullable: false),
                    observedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    notes = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationEntity", x => x.observation_id);
                });

            migrationBuilder.CreateTable(
                name: "pestsEntity",
                columns: table => new
                {
                    pest_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pestsEntity", x => x.pest_id);
                });

            migrationBuilder.CreateTable(
                name: "PhenologicalStagesEntity",
                columns: table => new
                {
                    stage_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    stage_code = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    group_number = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhenologicalStagesEntity", x => x.stage_id);
                });

            migrationBuilder.CreateTable(
                name: "PhysiologicalDisorderEntity",
                columns: table => new
                {
                    disorder_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhysiologicalDisorderEntity", x => x.disorder_id);
                });

            migrationBuilder.CreateTable(
                name: "rootstocksEntity",
                columns: table => new
                {
                    rootstock_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    crop_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rootstocksEntity", x => x.rootstock_id);
                    table.ForeignKey(
                        name: "FK_rootstocksEntity_cropsEntity_crop_id1",
                        column: x => x.crop_id1,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id");
                });

            migrationBuilder.CreateTable(
                name: "varietiesEntity",
                columns: table => new
                {
                    variety_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    crop_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_varietiesEntity", x => x.variety_id);
                    table.ForeignKey(
                        name: "FK_varietiesEntity_cropsEntity_crop_id1",
                        column: x => x.crop_id1,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id");
                });

            migrationBuilder.CreateTable(
                name: "cropDiseasesEntities",
                columns: table => new
                {
                    disease_id = table.Column<int>(type: "integer", nullable: false),
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cropDiseasesEntities", x => new { x.crop_id, x.disease_id });
                    table.ForeignKey(
                        name: "FK_cropDiseasesEntities_cropsEntity_crop_id",
                        column: x => x.crop_id,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cropDiseasesEntities_diseasesEntities_disease_id",
                        column: x => x.disease_id,
                        principalTable: "diseasesEntities",
                        principalColumn: "disease_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "observationDiseaseEntity",
                columns: table => new
                {
                    observation_id = table.Column<int>(type: "integer", nullable: false),
                    disease_id = table.Column<int>(type: "integer", nullable: false),
                    observation_id1 = table.Column<int>(type: "integer", nullable: true),
                    Observationdisease_id = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationDiseaseEntity", x => new { x.observation_id, x.disease_id });
                    table.ForeignKey(
                        name: "FK_observationDiseaseEntity_diseasesEntities_disease_id",
                        column: x => x.disease_id,
                        principalTable: "diseasesEntities",
                        principalColumn: "disease_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_observationDiseaseEntity_observationDiseaseEntity_observati~",
                        columns: x => new { x.observation_id1, x.Observationdisease_id },
                        principalTable: "observationDiseaseEntity",
                        principalColumns: new[] { "observation_id", "disease_id" });
                });

            migrationBuilder.CreateTable(
                name: "cropPestsEntity",
                columns: table => new
                {
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    pest_id = table.Column<int>(type: "integer", nullable: false),
                    pest_id1 = table.Column<int>(type: "integer", nullable: true),
                    crop_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cropPestsEntity", x => new { x.crop_id, x.pest_id });
                    table.ForeignKey(
                        name: "FK_cropPestsEntity_cropsEntity_crop_id1",
                        column: x => x.crop_id1,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id");
                    table.ForeignKey(
                        name: "FK_cropPestsEntity_pestsEntity_pest_id1",
                        column: x => x.pest_id1,
                        principalTable: "pestsEntity",
                        principalColumn: "pest_id");
                });

            migrationBuilder.CreateTable(
                name: "observationPestEntity",
                columns: table => new
                {
                    observation_id = table.Column<int>(type: "integer", nullable: false),
                    pest_id = table.Column<int>(type: "integer", nullable: false),
                    observation_id1 = table.Column<int>(type: "integer", nullable: true),
                    pest_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationPestEntity", x => new { x.observation_id, x.pest_id });
                    table.ForeignKey(
                        name: "FK_observationPestEntity_observationEntity_observation_id1",
                        column: x => x.observation_id1,
                        principalTable: "observationEntity",
                        principalColumn: "observation_id");
                    table.ForeignKey(
                        name: "FK_observationPestEntity_pestsEntity_pest_id1",
                        column: x => x.pest_id1,
                        principalTable: "pestsEntity",
                        principalColumn: "pest_id");
                });

            migrationBuilder.CreateTable(
                name: "cropDisorderEntities",
                columns: table => new
                {
                    crop_id = table.Column<int>(type: "integer", nullable: false),
                    disorder_id = table.Column<int>(type: "integer", nullable: false),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cropDisorderEntities", x => new { x.crop_id, x.disorder_id });
                    table.ForeignKey(
                        name: "FK_cropDisorderEntities_PhysiologicalDisorderEntity_disorder_id",
                        column: x => x.disorder_id,
                        principalTable: "PhysiologicalDisorderEntity",
                        principalColumn: "disorder_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cropDisorderEntities_cropsEntity_crop_id",
                        column: x => x.crop_id,
                        principalTable: "cropsEntity",
                        principalColumn: "crop_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "observationDisorderEntity",
                columns: table => new
                {
                    observation_id = table.Column<int>(type: "integer", nullable: false),
                    disorder_id = table.Column<int>(type: "integer", nullable: false),
                    observation_id1 = table.Column<int>(type: "integer", nullable: true),
                    disorder_id1 = table.Column<int>(type: "integer", nullable: true),
                    createdOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedOn = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_observationDisorderEntity", x => new { x.observation_id, x.disorder_id });
                    table.ForeignKey(
                        name: "FK_observationDisorderEntity_PhysiologicalDisorderEntity_disor~",
                        column: x => x.disorder_id1,
                        principalTable: "PhysiologicalDisorderEntity",
                        principalColumn: "disorder_id");
                    table.ForeignKey(
                        name: "FK_observationDisorderEntity_observationEntity_observation_id1",
                        column: x => x.observation_id1,
                        principalTable: "observationEntity",
                        principalColumn: "observation_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_cropDiseasesEntities_disease_id",
                table: "cropDiseasesEntities",
                column: "disease_id");

            migrationBuilder.CreateIndex(
                name: "IX_cropDisorderEntities_disorder_id",
                table: "cropDisorderEntities",
                column: "disorder_id");

            migrationBuilder.CreateIndex(
                name: "IX_cropPestsEntity_crop_id1",
                table: "cropPestsEntity",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cropPestsEntity_pest_id1",
                table: "cropPestsEntity",
                column: "pest_id1");

            migrationBuilder.CreateIndex(
                name: "IX_cropsEntity_crop_id1",
                table: "cropsEntity",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_observationDiseaseEntity_disease_id",
                table: "observationDiseaseEntity",
                column: "disease_id");

            migrationBuilder.CreateIndex(
                name: "IX_observationDiseaseEntity_observation_id1_Observationdisease~",
                table: "observationDiseaseEntity",
                columns: new[] { "observation_id1", "Observationdisease_id" });

            migrationBuilder.CreateIndex(
                name: "IX_observationDisorderEntity_disorder_id1",
                table: "observationDisorderEntity",
                column: "disorder_id1");

            migrationBuilder.CreateIndex(
                name: "IX_observationDisorderEntity_observation_id1",
                table: "observationDisorderEntity",
                column: "observation_id1");

            migrationBuilder.CreateIndex(
                name: "IX_observationPestEntity_observation_id1",
                table: "observationPestEntity",
                column: "observation_id1");

            migrationBuilder.CreateIndex(
                name: "IX_observationPestEntity_pest_id1",
                table: "observationPestEntity",
                column: "pest_id1");

            migrationBuilder.CreateIndex(
                name: "IX_rootstocksEntity_crop_id1",
                table: "rootstocksEntity",
                column: "crop_id1");

            migrationBuilder.CreateIndex(
                name: "IX_varietiesEntity_crop_id1",
                table: "varietiesEntity",
                column: "crop_id1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cropDiseasesEntities");

            migrationBuilder.DropTable(
                name: "cropDisorderEntities");

            migrationBuilder.DropTable(
                name: "cropPestsEntity");

            migrationBuilder.DropTable(
                name: "expertEntity");

            migrationBuilder.DropTable(
                name: "observationDiseaseEntity");

            migrationBuilder.DropTable(
                name: "observationDisorderEntity");

            migrationBuilder.DropTable(
                name: "observationPestEntity");

            migrationBuilder.DropTable(
                name: "PhenologicalStagesEntity");

            migrationBuilder.DropTable(
                name: "rootstocksEntity");

            migrationBuilder.DropTable(
                name: "varietiesEntity");

            migrationBuilder.DropTable(
                name: "diseasesEntities");

            migrationBuilder.DropTable(
                name: "PhysiologicalDisorderEntity");

            migrationBuilder.DropTable(
                name: "observationEntity");

            migrationBuilder.DropTable(
                name: "pestsEntity");

            migrationBuilder.DropTable(
                name: "cropsEntity");

            migrationBuilder.CreateTable(
                name: "TreeDatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlossomDensity = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DiseasePhotoPath = table.Column<string>(type: "text", nullable: false),
                    DiseaseSeverity = table.Column<string>(type: "text", nullable: false),
                    FertilizerApplicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FertilizerQuantity = table.Column<string>(type: "text", nullable: false),
                    FertilizerType = table.Column<string>(type: "text", nullable: false),
                    FruitQualityParameters = table.Column<string>(type: "text", nullable: false),
                    FruitSetPercentage = table.Column<string>(type: "text", nullable: false),
                    GrowthObservations = table.Column<string>(type: "text", nullable: false),
                    HarvestDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: false),
                    InputsApplied = table.Column<string>(type: "text", nullable: false),
                    NutrientDeficiencySymptoms = table.Column<string>(type: "text", nullable: false),
                    ObservedDisease = table.Column<string>(type: "text", nullable: false),
                    PestIncidence = table.Column<string>(type: "text", nullable: false),
                    PestSeverity = table.Column<string>(type: "text", nullable: false),
                    PesticideApplicationDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PesticideQuantity = table.Column<string>(type: "text", nullable: false),
                    PesticideType = table.Column<string>(type: "text", nullable: false),
                    PhenologicalStage = table.Column<string>(type: "text", nullable: false),
                    StageDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TreatmentApplied = table.Column<string>(type: "text", nullable: false),
                    TreeId = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    WeatherDamageReports = table.Column<string>(type: "text", nullable: false),
                    YieldPerTree = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreeDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CanopySize = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    GPSCoordinates = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    OrchardName = table.Column<string>(type: "text", nullable: false),
                    Ownership = table.Column<string>(type: "text", nullable: false),
                    PlantAge = table.Column<string>(type: "text", nullable: false),
                    PlantSource = table.Column<string>(type: "text", nullable: false),
                    PlantStatus = table.Column<string>(type: "text", nullable: false),
                    Region = table.Column<string>(type: "text", nullable: false),
                    RootstockType = table.Column<string>(type: "text", nullable: false),
                    RowColumnPosition = table.Column<string>(type: "text", nullable: false),
                    SpacingBetweenPlants = table.Column<string>(type: "text", nullable: false),
                    TreeHeight = table.Column<string>(type: "text", nullable: false),
                    TreeId = table.Column<string>(type: "text", nullable: false),
                    TrunkDiameter = table.Column<string>(type: "text", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false),
                    Variety = table.Column<string>(type: "text", nullable: false),
                    agroclimatezone = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false),
                    departement = table.Column<string>(type: "text", nullable: true),
                    role = table.Column<string>(type: "text", nullable: true),
                    semester = table.Column<string>(type: "text", nullable: true),
                    yearofstudy = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
