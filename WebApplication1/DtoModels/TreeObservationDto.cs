using datacapture.model;

namespace WebApplication1.DtoModels
{
    public class TreeObservationDto
    {
        public string qrcodeTreeId { get; set; }
        public string ImagePath { get; set; }

        public Phenological phenological { get; set; }
        public HealthandDisease healthandDisease { get; set; }
        public ManagementPractices managementPractices { get; set; }
        public YieldandProductivity yieldandProductivity { get; set; }
    }

}
