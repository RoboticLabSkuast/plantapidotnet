namespace WebApplication1.Models
{
    public abstract class BaseEntity
    {

            public DateTime createdOn { get; set; }= DateTime.UtcNow;
            public DateTime updatedOn { get; set; }  = DateTime.UtcNow;


    }
}
