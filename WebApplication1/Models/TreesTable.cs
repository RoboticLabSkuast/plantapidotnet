using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class TreesTable : BaseEntity
    {
       
        public int id { get; set; }
       
        public int expert_id { get; set; }
   
        public ExpertEntity? expert { get; set; }
       
        public int crop_id { get; set; }
 
        public CropEntity? crop { get; set; }
       
        public int variety_id { get; set; }
    
        public VarietiesEntity? variety { get; set; }
      
        public int rootstock_id { get; set; }
      
        public RootstocksEntity? rootstock { get; set; }
        public string agroClimaticZone { get; set; } = string.Empty;
        public DateTime graftingAge { get; set; }
        public int plantAge { get; set; }
        public string location { get; set; } = string.Empty;
        public string latitude { get; set; } = string.Empty;
        public string longitude { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string row { get; set; } = string.Empty;
        public string coloum { get; set; } = string.Empty;
        public string plantStatus { get; set; } = string.Empty;
    }
}
