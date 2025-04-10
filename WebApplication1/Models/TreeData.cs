namespace WebApplication1.Models
{
    public class TreeData
    {
        public int Id { get; set; }
        public string ImageName { get; set; }
        public string Base64Image { get; set; }
        public string Stage { get; set; }
        public int UploadedByUserId { get; set; } // Foreign key to User
        public User UploadedByUser { get; set; } // Navigation property
    }
}
