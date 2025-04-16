namespace WebApplication1.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public int UserId { get; set; } 
        public required string TreeId { get; set; }
        public string Variety { get; set; }=string.Empty;
        public string RootstockType { get; set; } = string.Empty;
        public string PlantAge { get; set; } = string.Empty; // Numeric value as string
        public string Location { get; set; } = string.Empty;
        public string agroclimatezone { get; set; } = string.Empty; // Numeric value as string
        public string GPSCoordinates { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string OrchardName { get; set; } = string.Empty;
        public string RowColumnPosition { get; set; } = string.Empty;
        public string Ownership { get; set; } = string.Empty;
        public string PlantSource { get; set; } = string.Empty;
        public string PlantStatus { get; set; } = string.Empty;
        public string CanopySize { get; set; } = string.Empty; // Numeric value as string
        public string TreeHeight { get; set; } = string.Empty;  // Numeric value as string
        public string TrunkDiameter { get; set; } = string.Empty; // Numeric value as string
        public string SpacingBetweenPlants { get; set; } = string.Empty; // Numeric value as string

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    }
}
