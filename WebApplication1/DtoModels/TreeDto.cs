namespace WebApplication1.DtoModels
{
    public class TreeDto
    {
        public int expert_id { get; set; }
        public string qrcodeTree { get; set; }
        public string name { get; set; } = string.Empty;
        public string varietyName { get; set; } = string.Empty;
        public string rootstockName { get; set; } = string.Empty;
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
