using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PhysiologicalDisorderEntity : BaseEntity
    {
        [Key]
        public int disorder_id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
