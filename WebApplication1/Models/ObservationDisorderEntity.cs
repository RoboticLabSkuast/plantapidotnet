namespace WebApplication1.Models
{
    public class ObservationDisorderEntity : BaseEntity
    {
        public int observation_id { get; set; } // Foreign key to Observations
        public int disorder_id { get; set; } // Foreign key to Disorders
        public ObservationEntity? Observation { get; set; } // Navigation property to Observations
        public PhysiologicalDisorderEntity? Disorder { get; set; } // Navigation property to Disorders

    }
}
