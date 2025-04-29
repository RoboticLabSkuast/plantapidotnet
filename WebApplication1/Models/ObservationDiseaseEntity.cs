namespace WebApplication1.Models
{
    public class ObservationDiseaseEntity : BaseEntity
    {
        public int observation_id { get; set; } // Foreign key to Observations
        public int disease_id { get; set; } // Foreign key to Diseases
        public ObservationDiseaseEntity? Observation { get; set; } // Navigation property to Observations
        public DiseasesEntity? Disease { get; set; } // Navigation property to Diseases

    }
}
