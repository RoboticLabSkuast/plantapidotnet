namespace WebApplication1.Models
{
    public class WeedControlEnity : BaseEntity
    {
        public int weed_control_id { get; set; } // Unique identifier for the weed control
        public string? name { get; set; } // Name of the weed control
        public string? description { get; set; } // Description of the weed control
        public int amountUsed { get; set; }
        public DateTime weedControlDateTime { get; set; } // Date and time when the weed control was used
    }
}
