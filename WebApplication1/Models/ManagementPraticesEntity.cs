using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ManagementPraticesEntity
    {

        public int managementPraticesEntity_Id { get; set; }
        public string fertilizer { get; set; } = string.Empty;
        public DateTime fertilizerDateTime { get; set; }
        public int fertilizerAmount { get; set; }
        public string micronutrients { get; set; } = string.Empty;
        public DateTime micronutrientsDateTime { get; set; }
        public int micronutrientsAmount { get; set; }
        public string weedControl { get; set; } = string.Empty;
        public DateTime weedControlDateTime { get; set; }
        public int weedControlAmount { get; set; }




    }
}
