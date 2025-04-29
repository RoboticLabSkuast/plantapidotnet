using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class CropDisorderEntity : BaseEntity
    {
        public int crop_id { get; set; } // Foreign key to Crops
       
        public int disorder_id { get; set; } // Foreign key to Disorders
        public PhysiologicalDisorderEntity? Disorder { get; set; } // Navigation property to Disorders
        public CropEntity? Crop { get; set; } // Navigation property to Crops
    }
}
