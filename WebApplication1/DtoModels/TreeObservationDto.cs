using datacapture.model;
using WebApplication1.Models;

namespace WebApplication1.DtoModels
{
    public class TreeObservationDto
    {
        public string qrcodeTreeId { get; set; }
        public string ImagePath { get; set; }
        public CropEntity crop { get; set; }
       public VarietiesEntity variety { get; set; }
       public RootstocksEntity rootstock { get; set; }

        public Phenological phenological { get; set; }
        public HealthandDisease healthandDisease { get; set; }
        public ManagementPractices managementPractices { get; set; }
        public YieldandProductivity yieldandProductivity { get; set; }
    }

}
