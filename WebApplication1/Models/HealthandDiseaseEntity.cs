using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class HealthandDiseaseEntity
    {
      
        public int healthandDiseaseEntity_Id { get; set; }
        public string ObservedDisease { get; set; } = string.Empty;
        public int ObservedDiseaseLevel { get; set; }
        public string Insects { get; set; } = string.Empty;
        public int InsectsLevel { get; set; }
        public string PhysiologicalDisorder { get; set; } = string.Empty;
        public int PhysiologicalDisorderLevel { get; set; }
        public string NurientDefiency { get; set; } = string.Empty;
        public string DamageReport { get; set; } = string.Empty;


    }
}
