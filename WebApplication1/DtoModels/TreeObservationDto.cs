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

        public PhenologicalEntities? phenological { get; set; }
        public HealthandDiseaseEntity? healthandDisease { get; set; }
        public ManagementPraticesEntity? managementPractices { get; set; }
        public YieldandProductivityEntity? yieldandProductivity { get; set; }
    }

}
