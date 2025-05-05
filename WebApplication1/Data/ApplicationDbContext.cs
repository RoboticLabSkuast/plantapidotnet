
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
        public DbSet<PhenologicalStageEntity> phenologicalStageEntity { get; set; }
        public DbSet<YieldandProductivityEntity> yieldandProductivityEntities { get; set; }
        public DbSet<PhenologicalEntities> phenologicalEntities { get; set; }
        public DbSet<DisorderEntity> disorderEntities { get; set; }
        public DbSet<FertilizerEntity> fertilizerEntities { get; set; }
        public DbSet<InsectsEntity> insectsEntities { get; set; }
        public DbSet<MicroNutrientsEntity> microNutrientsEntities { get; set; }
        public DbSet<WeedControlEnity> weedControlEntities { get; set; }    
        





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
            modelBuilder.Entity<DisorderEntity>()
               .HasKey(od => od.disorder_id);
            modelBuilder.Entity<FertilizerEntity>()
           .HasKey(od => od.fertilizer_id);
            modelBuilder.Entity<InsectsEntity>()
                .HasKey(od => od.insect_id);
            modelBuilder.Entity<MicroNutrientsEntity>()
             .HasKey(od => od.micro_nutrient_id);
            modelBuilder.Entity<WeedControlEnity>()
           .HasKey(od => od.weed_control_id);





            modelBuilder.Entity<HealthandDiseaseEntity>(entity =>
            {
            entity.HasKey(t => t.healthandDiseaseEntity_Id);
                entity.HasOne(t => t.Diseases)
                  .WithMany()
                  .HasForeignKey(t => t.disease_id);
                entity.HasOne(t => t.Insects)
                .WithMany()
                .HasForeignKey(t => t.insect_id);

                entity.HasOne(t => t.Disorder)
               .WithMany()
                .HasForeignKey(t => t.disorder_id);
            });
            


            modelBuilder.Entity<PhenologicalEntities>(entity =>
            {
                entity.HasKey(t=>t.phenologicalEntities_Id);


                entity.HasOne(t=>t.phenlogicalStageEntity)
                .WithMany().
                HasForeignKey(e=>e.phenologicalStageEntity_Id);
                

            });



            modelBuilder.Entity<ManagementPraticesEntity>(entity=>
            {
                entity.HasKey(t => t.managementPraticesEntity_Id);

                entity.HasOne(t => t.Fertilizer)
                      .WithMany()
                      .HasForeignKey(t => t.fertilizer_id);

                entity.HasOne(t => t.MicroNutrient)
                      .WithMany()
                      .HasForeignKey(t => t.micro_nutrient_id);

                entity.HasOne(t => t.WeedControl)
                .WithMany()
                .HasForeignKey(t => t.weed_control_id);

            });
               








            modelBuilder.Entity<YieldandProductivityEntity>()

                 .HasKey(t => t.yieldandProductivityEntity_Id);






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
                entity.HasOne(e => e.phenologicalEntities)
                      .WithMany()
                      .HasForeignKey(e => e.phenologicalEntities_Id)
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