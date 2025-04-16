namespace WebApplication1.Models
{
    public class TreeApidata
    {
        public string TreeId { get; set; }
        public int UserId { get; set; }

        // Store the image as a byte array (BLOB)
        public byte[] ImageData { get; set; }

        // Phenological Practices
        public string PhenologicalStage { get; set; } = string.Empty;
        public DateTime StageDate { get; set; }
        public string GrowthObservations { get; set; } = string.Empty;
        public int? BlossomDensity { get; set; }

        // Management Practices
        public string InputsApplied { get; set; } = string.Empty;
        public string PesticideType { get; set; } = string.Empty;
        public DateTime? PesticideApplicationDate { get; set; }
        public double? PesticideQuantity { get; set; }
        public string FertilizerType { get; set; } = string.Empty;
        public DateTime? FertilizerApplicationDate { get; set; }
        public double? FertilizerQuantity { get; set; }

        // Health and Disease Monitoring
        public string ObservedDisease { get; set; } = string.Empty;
        public string DiseaseSeverity { get; set; } = string.Empty;
        public string DiseasePhotoPath { get; set; } = string.Empty;
        public string PestIncidence { get; set; } = string.Empty;
        public string PestSeverity { get; set; } = string.Empty;
        public string TreatmentApplied { get; set; } = string.Empty;
        public string NutrientDeficiencySymptoms { get; set; } = string.Empty;
        public string WeatherDamageReports { get; set; } = string.Empty;

        // Yield and Productivity
        public double? FruitSetPercentage { get; set; }
        public DateTime? HarvestDate { get; set; }
        public double? YieldPerTree { get; set; }
        public string FruitQualityParameters { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
    }
}
