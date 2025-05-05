using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DiseasesEntity : BaseEntity
    {
      
        public int disease_id { get; set; }
        public int diseaseName_id { get; set; }
        public DiseaseNameEntity? diseaseName { get; set; } // Navigation property to DiseaseNameEntity
        public int level { get; set; } // Severity level of the disease


    }
    public class DiseaseNameEntity : BaseEntity
    {
        public int diseaseName_id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }

    }
}
