namespace WebApplication1.Models
{
    public class DisorderEntity : BaseEntity
    {
        public int disorder_id { get; set; } // Unique identifier for the disorder
        public int disorderName_id { get; set; } // Foreign key to DisorderNameEntity
        public DisorderNameEntity? disorderName { get; set; } // Navigation property to DisorderNameEntity
        public int level { get; set; }

    }
    public  class DisorderNameEntity : BaseEntity
    {
        public int disorderName_id { get; set; } // Unique identifier for the disorder name
        public string? name { get; set; } // Name of the disorder
        public string? description { get; set; } // Description of the disorder
    }
}
