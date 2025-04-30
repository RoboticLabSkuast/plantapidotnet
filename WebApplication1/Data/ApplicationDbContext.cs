
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

        public DbSet<DiseasesEntity> diseasesEntities { get; set; }
        public DbSet<ExpertEntity> expertEntity { get; set; }
        public DbSet<ObservationEntity> observationEntity { get; set; }

        public DbSet<HealthandDiseaseEntity> healthandEntity { get; set; }
        public DbSet<ManagementPraticesEntity>  managementPraticesEntities { get; set; }
        public DbSet<PhenologicalStageEntity> phenlogicalStageEntities { get; set; }
        public DbSet<YieldandProductivityEntity> yieldandProductivityEntities { get; set; }
 



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
             modelBuilder.Entity<CropEntity>()
              .HasKey(od => od.crop_id);
             modelBuilder.Entity<DiseasesEntity>()
              .HasKey(od =>od.disease_id); 
             modelBuilder.Entity<RootstocksEntity>()
             .HasKey(od =>od.rootstock_id );
              modelBuilder.Entity<VarietiesEntity>()
             .HasKey(od =>  od.variety_id );
            modelBuilder.Entity<ExpertEntity>()
                .HasKey(od =>  od.expert_id);
            modelBuilder.Entity<PhenologicalStageEntity>()
                .HasKey(od =>od.phenologicalStageEntity_Id);
            modelBuilder.Entity<HealthandDiseaseEntity>()
                .HasKey(od => od.healthandDiseaseEntity_Id);


            modelBuilder.Entity<PhenologicalEntity>(entity =>
            {
                entity.HasKey(t=>t.PhenologicalEntity_Id);
                entity.HasOne(t=>t.PhenlogicalStageEntity)
                .WithMany().
                HasForeignKey(e=>e.phenologicalStageEntity_Id);
                

            });
               


            modelBuilder.Entity<YieldandProductivityEntity>()
                .HasKey(od =>od.yieldandProductivityEntity_Id);
            modelBuilder.Entity<ManagementPraticesEntity>()
                .HasKey(od =>od.managementPraticesEntity_Id);
            modelBuilder.Entity<ObservationEntity>(entity =>
            {
              

                entity.HasKey(e => e.observationEntity_Id);

                // Crop relationship
                entity.HasOne(e => e.crop)
                      .WithMany()
                      .HasForeignKey(e => e.crop_id)
                      .OnDelete(DeleteBehavior.Restrict);

                // Yield and Productivity relationship
                entity.HasOne(e => e.yieldandProductivityEntity)
                      .WithMany()
                      .HasForeignKey(e => e.yieldandProductivityEntity_Id)
                      .OnDelete(DeleteBehavior.Restrict);

                // Phenological relationship
                entity.HasOne(e => e.phenologicalEntity)
                      .WithMany()
                      .HasForeignKey(e => e.phenologicalEntity_Id)
                      .OnDelete(DeleteBehavior.Restrict);

                // Management Practices relationship
                entity.HasOne(e => e.managementPraticesEntity)
                      .WithMany()
                      .HasForeignKey(e => e.managementPraticesEntity_Id)
                      .OnDelete(DeleteBehavior.Restrict);

                // Health and Disease relationship
                entity.HasOne(e => e.healthandDiseaseEntity)
                      .WithMany()
                      .HasForeignKey(e => e.healthandDiseaseEntity_Id)
                      .OnDelete(DeleteBehavior.Restrict);
            });



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