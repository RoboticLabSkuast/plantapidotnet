namespace WebApplication1.Models
{
    public class FertilizerEntity : BaseEntity
    {
        public int fertilizer_id { get; set; } // Unique identifier for the fertilizer
        public string? name { get; set; } // Name of the fertilizer
        public string? description { get; set; } // Description of the fertilizer
        public int amountUsed { get; set; } // Amount of fertilizer used
        public DateTime fertilizerDateTime { get; set; }
    }
}
