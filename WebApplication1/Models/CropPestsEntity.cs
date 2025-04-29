namespace WebApplication1.Models
{
    public class CropPestsEntity:BaseEntity
    {
        public int crop_id { get; set; } // Foreign key to Crops
        public int pest_id { get; set; } // Foreign key to Pests
    public PestsEntity? Pest { get; set; } // Navigation property to Pests
        public CropEntity? Crop { get; set; } // Navigation property to Crops
    }
}
