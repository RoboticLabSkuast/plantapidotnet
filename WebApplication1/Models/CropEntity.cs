using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CropEntity : BaseEntity
    {
       
        public int crop_id { get; set; }
       
        public string qrcodeTree { get; set; } = string.Empty;
        public string name { get; set; }


    }
}
