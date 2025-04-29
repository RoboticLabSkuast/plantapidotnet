using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PestsEntity : BaseEntity
    {
        [Key]
        public int pest_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

    }
}
