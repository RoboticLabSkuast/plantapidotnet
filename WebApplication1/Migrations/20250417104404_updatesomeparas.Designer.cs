﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250417104404_updatesomeparas")]
    partial class updatesomeparas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Models.Tree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CanopySize")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("GPSCoordinates")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OrchardName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ownership")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlantAge")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlantSource")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PlantStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RootstockType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RowColumnPosition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SpacingBetweenPlants")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TreeHeight")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TreeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TrunkDiameter")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("Variety")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("agroclimatezone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Trees");
                });

            modelBuilder.Entity("WebApplication1.Models.TreeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BlossomDensity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("DiseasePhotoPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DiseaseSeverity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("FertilizerApplicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FertilizerQuantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FertilizerType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FruitQualityParameters")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FruitSetPercentage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GrowthObservations")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("HarvestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("InputsApplied")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NutrientDeficiencySymptoms")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ObservedDisease")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PestIncidence")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PestSeverity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("PesticideApplicationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("PesticideQuantity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PesticideType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhenologicalStage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StageDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TreatmentApplied")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TreeId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("WeatherDamageReports")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("YieldPerTree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TreeDatas");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("departement")
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .HasColumnType("text");

                    b.Property<string>("semester")
                        .HasColumnType("text");

                    b.Property<string>("yearofstudy")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
