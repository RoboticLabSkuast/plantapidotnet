using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterTreeGetapi : BaseEntity
    {
       
        public string qrcodeTree { get; set; }=string.Empty;
         public string Variety { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string CropName { get; set; } = string.Empty;


    }
}
