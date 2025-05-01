using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datacapture.model
{
   public class UploadClass
    {
        public string qrcodeTreeId {  get; set; } = string.Empty;
        public byte[] ImageData { get; set; }
        public Phenological phenological { get; set; }
        public HealthandDisease healthandDisease { get; set; }
        public ManagementPractices managementPractices { get; set; }
        public YieldandProductivity yieldandProductivity { get; set; }
    }
    public class Phenological
    {
        public string stageName {  get; set; }=string.Empty;
        public DateTime StageDate { get; set; }
        public int growthScale { get; set; }
        public int blossomDensity { get; set; }
    }
    public class HealthandDisease
    {
        public string ObservedDisease { get; set; } = string.Empty;
        public int ObservedDiseaseLevel { get; set; } 
        public string Insects { get; set; } = string.Empty;
        public int InsectsLevel { get; set; } 
        public string PhysiologicalDisorder { get; set; } = string.Empty;
        public int PhysiologicalDisorderLevel { get; set; } 
        public string NurientDefiency { get; set; } = string.Empty;
        public string DamageReport { get; set; } = string.Empty;


    }
    public class ManagementPractices { 
        public string fertilizer {  get; set; } = string.Empty;
        public DateTime fertilizerDateTime { get; set; }
        public int fertilizerAmount { get; set; }
        public string micronutrients { get; set; } = string.Empty;
        public DateTime micronutrientsDateTime { get; set; }
        public int micronutrientsAmount { get; set; }
        public string weedControl { get; set; } = string.Empty;
        public DateTime weedControlDateTime { get; set; }
        public int weedControlAmount { get; set; }
    }
    public class YieldandProductivity { 
        public int fruitSetPercent { get; set; }
        public DateTime harvestDate { get; set; }
        public int yieldAmount { get; set; }
        public int FruitQuality { get; set; }

    }

}
