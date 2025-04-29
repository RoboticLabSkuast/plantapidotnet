using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class VarietiesEntity : BaseEntity
    {
        [Key]
        public int variety_id { get; set; }
        public string name { get; set; }
        public int crop_id { get; set; } // Foreign key to Crops
        public CropEntity? Crop { get; set; } // Navigation property to Crops

    }
}
