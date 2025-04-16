using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
       
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; } // Store hashed passwords
        public string? Email { get; set; }
        public string? role { get; set; }
        public string? PhoneNumber { get; set; }
        public string? departement { get; set; }
        public string? semester { get; set; }
        public string? yearofstudy { get; set; }
         public DateTime CreatedDate { get; set; }= DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;
       
      
    }
}
