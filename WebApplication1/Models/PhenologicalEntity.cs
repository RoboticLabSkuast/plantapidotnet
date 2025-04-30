using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class PhenologicalEntity : BaseEntity
    {
     
        public int PhenologicalEntity_Id { get; set; }

       
        public int phenologicalStageEntity_Id { get; set; }

    
        public PhenologicalStageEntity? PhenlogicalStageEntity { get; set; }
        public DateTime StageDate { get; set; }
        public int growthScale { get; set; }
        public int blossomDensity { get; set; }
   
    }
}
