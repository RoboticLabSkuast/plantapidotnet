namespace WebApplication1.Models
{
    public class DisorderEntity : BaseEntity
    {
        public int disorder_id { get; set; } // Unique identifier for the disorder
        public string? name { get; set; } // Name of the disorder
        public string? description { get; set; } // Description of the disorder
        public int level { get; set; }

    }
}
