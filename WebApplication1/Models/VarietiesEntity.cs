using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class VarietiesEntity : BaseEntity
    {

        public int variety_id { get; set; }
        public string name { get; set; }
    }
}
