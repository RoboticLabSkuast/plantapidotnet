using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class CropDiseasesEntity : BaseEntity
    {
      
        public int disease_id { get; set; }
       
        public int crop_id { get; set; } // Foreign key to Crops
        
        public DiseasesEntity? Disease { get; set; } // Navigation property to Diseases
        public CropEntity? Crop { get; set; } // Navigation property to Crops

    }
}
