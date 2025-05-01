using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class PhenologicalEntities : BaseEntity
    {
     
        public int phenologicalEntities_Id { get; set; }

       
      
        public DateTime StageDate { get; set; }
        public int growthScale { get; set; }
        public int blossomDensity { get; set; }



        public int phenologicalStageEntity_Id { get; set; }


        public PhenologicalStageEntity? phenlogicalStageEntity { get; set; }

    }
}
