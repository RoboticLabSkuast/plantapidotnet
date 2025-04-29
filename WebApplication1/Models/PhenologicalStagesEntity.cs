using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PhenologicalStagesEntity : BaseEntity
    {
        [Key]
        public int stage_id { get; set; }
        public int crop_id { get; set; } // Foreign key to Crops
    public string stage_code { get; set; }
        public string description { get; set; }
        public int group_number { get; set; }
    }
}
