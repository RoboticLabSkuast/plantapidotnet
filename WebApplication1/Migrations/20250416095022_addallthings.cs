using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class addallthings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeDatas_Users_UploadedByUserId",
                table: "TreeDatas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trees",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_TreeDatas_UploadedByUserId",
                table: "TreeDatas");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "PlantingDate",
                table: "Trees",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "GraftingDate",
                table: "Trees",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "UploadedByUserId",
                table: "TreeDatas",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Stage",
                table: "TreeDatas",
                newName: "WeatherDamageReports");

            migrationBuilder.RenameColumn(
                name: "ImageName",
                table: "TreeDatas",
                newName: "TreeId");

            migrationBuilder.RenameColumn(
                name: "Base64Image",
                table: "TreeDatas",
                newName: "TreatmentApplied");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Users",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "departement",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "role",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "semester",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "yearofstudy",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Trees",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "agroclimatezone",
                table: "Trees",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BlossomDensity",
                table: "TreeDatas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "DiseasePhotoPath",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DiseaseSeverity",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "FertilizerApplicationDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FertilizerQuantity",
                table: "TreeDatas",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FertilizerType",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FruitQualityParameters",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "FruitSetPercentage",
                table: "TreeDatas",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GrowthObservations",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "HarvestDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InputsApplied",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NutrientDeficiencySymptoms",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ObservedDisease",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PestIncidence",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PestSeverity",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "PesticideApplicationDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "PesticideQuantity",
                table: "TreeDatas",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PesticideType",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhenologicalStage",
                table: "TreeDatas",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "StageDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "TreeDatas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "YieldPerTree",
                table: "TreeDatas",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trees",
                table: "Trees",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Trees",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "departement",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "semester",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "yearofstudy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "agroclimatezone",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "BlossomDensity",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "DiseasePhotoPath",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "DiseaseSeverity",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "FertilizerApplicationDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "FertilizerQuantity",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "FertilizerType",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "FruitQualityParameters",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "FruitSetPercentage",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "GrowthObservations",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "HarvestDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "InputsApplied",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "NutrientDeficiencySymptoms",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "ObservedDisease",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PestIncidence",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PestSeverity",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PesticideApplicationDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PesticideQuantity",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PesticideType",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "PhenologicalStage",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "StageDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "TreeDatas");

            migrationBuilder.DropColumn(
                name: "YieldPerTree",
                table: "TreeDatas");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Trees",
                newName: "PlantingDate");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Trees",
                newName: "GraftingDate");

            migrationBuilder.RenameColumn(
                name: "WeatherDamageReports",
                table: "TreeDatas",
                newName: "Stage");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TreeDatas",
                newName: "UploadedByUserId");

            migrationBuilder.RenameColumn(
                name: "TreeId",
                table: "TreeDatas",
                newName: "ImageName");

            migrationBuilder.RenameColumn(
                name: "TreatmentApplied",
                table: "TreeDatas",
                newName: "Base64Image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trees",
                table: "Trees",
                column: "TreeId");

            migrationBuilder.CreateIndex(
                name: "IX_TreeDatas_UploadedByUserId",
                table: "TreeDatas",
                column: "UploadedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeDatas_Users_UploadedByUserId",
                table: "TreeDatas",
                column: "UploadedByUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
