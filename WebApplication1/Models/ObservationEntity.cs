using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class ObservationEntity : BaseEntity
    {
       
        public int observationEntity_Id { get; set; }
        public string? ImagePath { get; set; }



        public int crop_id { get; set; }
     
        public CropEntity? crop { get; set; }


       
        public int yieldandProductivityEntity_Id { get; set; }
       
        public YieldandProductivityEntity? yieldandProductivityEntity { get; set; }


      
        public int phenologicalEntities_Id { get; set; }
     
        public PhenologicalEntities? phenologicalEntities { get; set; }

      
        public int managementPraticesEntity_Id { get; set; }

      
        public ManagementPraticesEntity? managementPraticesEntity { get; set; }



      
        public int healthandDiseaseEntity_Id { get; set; }
     
        public HealthandDiseaseEntity? healthandDiseaseEntity { get; set; }
    }
}
