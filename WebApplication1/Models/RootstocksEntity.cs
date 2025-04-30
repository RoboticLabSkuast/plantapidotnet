using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class RootstocksEntity : BaseEntity
    {

        public int rootstock_id { get; set; }
        public string name { get; set; }

    }
}
