namespace WebApplication1.DtoModels
{
    public class ExpertDto
    {
        public int expert_id { get; set; }
        public required string name { get; set; }
        public required string username { get; set; } // Unique username for the expert

        public required string password { get; set; }
        public string email { get; set; } = string.Empty;
        public required string role { get; set; } // Role of the expert (e.g., "Agronomist", "Veterinarian")


        public string phone { get; set; } = string.Empty;
        public string year { get; set; } = string.Empty;//department
        public string department { get; set; } = string.Empty;


        public string bio { get; set; } = string.Empty; // Short biography of the expert

    }
}
