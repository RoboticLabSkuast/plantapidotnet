using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class HealthandDiseaseEntity : BaseEntity
    {
      
        public int healthandDiseaseEntity_Id { get; set; }

        public int disease_id { get; set; } // Unique identifier for the disease
        public DiseasesEntity? Diseases { get; set; } // Navigation property to the DiseasesEntity


        public int insect_id { get; set; } // Unique identifier for the insect
        public InsectsEntity? Insects { get; set; } // Navigation property to the InsectsEntity


        public int disorder_id { get; set; } // Unique identifier for the physiological disorder
        public DisorderEntity? Disorder { get; set; } // Navigation property to the DisorderEntity 
        
        


      
        public string NurientDefiency { get; set; } = string.Empty;
        public string DamageReport { get; set; } = string.Empty;
        public int PlantHealth { get;  set; }
    }
}
