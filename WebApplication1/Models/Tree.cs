namespace WebApplication1.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; } // Foreign key to User
        public User User { get; set; } // Navigation property
    }
}
