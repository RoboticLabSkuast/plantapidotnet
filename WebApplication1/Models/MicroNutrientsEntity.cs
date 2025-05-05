namespace WebApplication1.Models
{
    public class MicroNutrientsEntity : BaseEntity
    {
        public int micro_nutrient_id { get; set; } // Unique identifier for the micro nutrient
        public int microNutrientName_id { get; set; } // Foreign key to MicroNutrientNameEntity
        public MicroNutrientNameEntity? microNutrientName { get; set; } // Navigation property to MicroNutrientNameEntity
        public int amountUsed { get; set; }
        public DateTime microNutrientDateTime { get; set; } // Date and time when the micro nutrient was used
    }
    public class MicroNutrientNameEntity : BaseEntity
    {
        public int microNutrientName_id { get; set; } // Unique identifier for the micro nutrient name
        public string? name { get; set; } // Name of the micro nutrient
        public string? description { get; set; } // Description of the micro nutrient
    }
}
