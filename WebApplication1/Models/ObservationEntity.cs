using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ObservationEntity : BaseEntity
    {
        [Key]
        public int observation_id { get; set; } // Unique identifier for the observation
        public int crop_id { get; set; } // Foreign key to Crops
       public int variety_id { get; set; }
        public int rootstock_id { get; set; }
        public int stage_id { get; set; } // Foreign key to Stages
        public DateTime observedAt { get; set; }
        public string notes { get; set; } // Additional notes about the observation

    }
}
