using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PhenologicalStageEntity : BaseEntity //stores only stages
    {
       
        public int phenologicalStageEntity_Id { get; set; }
        public string stageName { get; set; }
    }
}
