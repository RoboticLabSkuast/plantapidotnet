
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.old;
namespace WebApplication1.Data
{


    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<TreesTable> treesTables { get; set; }
        public DbSet<CropEntity> cropsEntity { get; set; }
        public DbSet<VarietiesEntity> varietiesEntity { get; set; }
        public DbSet<RootstocksEntity> rootstocksEntity { get; set; }
        public DbSet<PhenologicalStagesEntity> phenologicalStagesEntity { get; set; }
        public DbSet<PestsEntity> pestsEntity { get; set; }
        public DbSet<PhenologicalStagesEntity> phenologicalStages { get; set; }
        public DbSet<DiseasesEntity> diseasesEntities { get; set; }
        public DbSet<ExpertEntity> expertEntity { get; set; }
        public DbSet<CropPestsEntity> cropPestsEntity { get; set; }
        public DbSet<CropDisorderEntity> cropDisorderEntities { get; set; }
        public DbSet<CropDiseasesEntity> cropDiseasesEntities { get; set; }
        public DbSet<ObservationEntity> observationEntity { get; set; }
        public DbSet<ObservationPestEntity> observationPestEntity { get; set; }
        public DbSet<ObservationDisorderEntity> observationDisorderEntity { get; set; }
        public DbSet<ObservationDiseaseEntity> observationDiseaseEntity { get; set; }
      



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ObservationDiseaseEntity>()
                .HasKey(od => new { od.observation_id, od.disease_id});
            modelBuilder.Entity<ObservationDisorderEntity>()
               .HasKey(od => new { od.observation_id, od.disorder_id    });
            modelBuilder.Entity<ObservationPestEntity>()
               .HasKey(od => new { od.observation_id, od.pest_id});
            modelBuilder.Entity<CropDiseasesEntity>()
             .HasKey(od => new { od.crop_id, od.disease_id });
            modelBuilder.Entity<CropDisorderEntity>()
             .HasKey(od => new { od.crop_id, od.disorder_id });
            modelBuilder.Entity<CropEntity>()
             .HasKey(od => new { od.crop_id});
            modelBuilder.Entity<CropPestsEntity>()
              .HasKey(od => new { od.crop_id,od.pest_id });
            modelBuilder.Entity<DiseasesEntity>()
             .HasKey(od => new { od.disease_id});
            modelBuilder.Entity<ObservationEntity>()
                .HasKey(od => new { od.observation_id });
            modelBuilder.Entity<PhenologicalStagesEntity>()
            .HasKey(od => new { od.stage_id });
                        modelBuilder.Entity<RootstocksEntity>()
            .HasKey(od => new { od.rootstock_id });
                        modelBuilder.Entity<VarietiesEntity>()
            .HasKey(od => new { od.variety_id });
            modelBuilder.Entity<TreesTable>(entity =>
            {
                entity.HasKey(t => t.id);

                entity.HasOne(t => t.expert)
                      .WithMany()
                      .HasForeignKey(t => t.expert_id)
                      .OnDelete(DeleteBehavior.Restrict); // Optional: prevents cascade delete

                entity.HasOne(t => t.crop)
                      .WithMany()
                      .HasForeignKey(t => t.crop_id)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(t => t.variety)
                      .WithMany()
                      .HasForeignKey(t => t.variety_id)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(t => t.rootstock)
                      .WithMany()
                      .HasForeignKey(t => t.rootstock_id)
                      .OnDelete(DeleteBehavior.Restrict);
            });


        }
    }

}
/*

dotnet ef migrations add alldone

 dotnet ef database update

 * */