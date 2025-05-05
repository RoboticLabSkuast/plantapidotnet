namespace WebApplication1.Models
{
    public class InsectsEntity : BaseEntity
    {
        public int insect_id { get; set; } // Unique identifier for the insect
        public int insectName_id { get; set; } // Foreign key to InsectNameEntity
        public InsectNameEntity? insectName { get; set; } // Navigation property to InsectNameEntity
        public int level { get; set; }
    }
    public class InsectNameEntity : BaseEntity
    {
        public int insectName_id { get; set; } // Unique identifier for the insect name
        public string? name { get; set; } // Name of the insect
        public string? description { get; set; } // Description of the insect
    }
}
