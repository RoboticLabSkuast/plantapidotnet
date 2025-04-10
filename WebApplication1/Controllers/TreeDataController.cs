using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
namespace  WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TreeDataController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IWebHostEnvironment _env;

    public TreeDataController(ApplicationDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    [HttpPost]
    public IActionResult AddTreeData([FromBody] TreeData treeData)
    {
        if (!_context.Users.Any(u => u.Id == treeData.UploadedByUserId))
            return BadRequest("Invalid user ID.");

        // Save image to upload folder
        var imagePath = Path.Combine(_env.WebRootPath, "uploads", treeData.ImageName);
        var imageBytes = Convert.FromBase64String(treeData.Base64Image);
        System.IO.File.WriteAllBytes(imagePath, imageBytes);

        _context.TreeDatas.Add(treeData);
        _context.SaveChanges();

        return Ok("Tree data added successfully.");
    }
}