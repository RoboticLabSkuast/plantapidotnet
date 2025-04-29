namespace WebApplication1.Models
{
    public class ObservationPestEntity : BaseEntity
    {
        public int observation_id { get; set; } // Foreign key to Observations
        public int pest_id { get; set; } // Foreign key to Pests
        public ObservationEntity? Observation { get; set; } // Navigation property to Observations
        public PestsEntity? Pest { get; set; } // Navigation property to Pests

    }
}
