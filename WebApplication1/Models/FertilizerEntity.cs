namespace WebApplication1.Models
{
    public class FertilizerEntity : BaseEntity
    {
        public int fertilizer_id { get; set; } // Unique identifier for the fertilizer
       public int fertilizerName_id { get; set; } // Foreign key to FertilizerNameEntity
        public FertilizerNameEntity? fertilizerName { get; set; } // Navigation property to FertilizerNameEntity
        public int amountUsed { get; set; } // Amount of fertilizer used
        public DateTime fertilizerDateTime { get; set; }
    }
    public class FertilizerNameEntity : BaseEntity
    {
        public int fertilizerName_id { get; set; } // Unique identifier for the fertilizer name
        public string? name { get; set; } // Name of the fertilizer
        public string? description { get; set; } // Description of the fertilizer
    }
}
