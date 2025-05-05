namespace WebApplication1.Models
{
    public class InsectsEntity : BaseEntity
    {
        public int insect_id { get; set; } // Unique identifier for the insect
        public string? name { get; set; }
        public string? description { get; set; }
        public int level { get; set; }
    }
}
