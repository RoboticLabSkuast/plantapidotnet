using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RegisterTreeGetapi : BaseEntity
    {
        [Key]
        public string TreeId { get; set; }
            public string Variety { get; set; }
            public string Location { get; set; }
            public string Region { get; set; }
            public string OrchardName { get; set; }
        

    }
}
