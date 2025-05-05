using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ManagementPraticesEntity : BaseEntity
    {

        public int managementPraticesEntity_Id { get; set; }
        public int fertilizer_id { get; set; } // Unique identifier for the fertilizer
        public FertilizerEntity? Fertilizer { get; set; } // Navigation property to the FertilizerEntity


        public int micro_nutrient_id { get; set; } // Unique identifier for the micro nutrient
        public MicroNutrientsEntity? MicroNutrient { get; set; } // Navigation property to the MicroNutrientsEntity
        public int weed_control_id { get; set; } // Unique identifier for the weed control
        public WeedControlEnity? WeedControl { get; set; } // Navigation property to the WeedControlEnity





    }
}
