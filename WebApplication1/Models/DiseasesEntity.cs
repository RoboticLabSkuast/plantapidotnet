using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class DiseasesEntity : BaseEntity
    {
      
        public int disease_id { get; set; }
        public string? name { get; set; }
        public string? description { get; set; }
        public int level { get; set; } // Severity level of the disease


    }
}
