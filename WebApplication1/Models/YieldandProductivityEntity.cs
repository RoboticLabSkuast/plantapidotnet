using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class YieldandProductivityEntity : BaseEntity
    {
       
        public int yieldandProductivityEntity_Id { get; set; }
        public int fruitSetPercent { get; set; }
        public DateTime harvestDate { get; set; }
        public int yieldAmount { get; set; }
        public int FruitQuality { get; set; }
    }
}
