namespace WebApplication1.DtoModels
{
    public class ExpertDto
    {
        public int expert_id { get; set; }
        public required string username { get; set; } // Unique username for the expert
        public required string role { get; set; } // Role of the expert (e.g., "Agronomist", "Veterinarian")
        public required string name { get; set; }
        public string email { get; set; } = string.Empty;
        public required string phone { get; set; }
        public string address { get; set; } = string.Empty;
        public string specialization { get; set; } = string.Empty;

        public  string password { get; set; } // URL to the expert's image
        public string bio { get; set; } = string.Empty; // Short biography of the expert
    }
}
