using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class TreeController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public TreeController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost("treeregistration")]
    public IActionResult RegisterTree([FromBody] Tree tree)
    { 
        if (!_context.Users.Any(u => u.Id == tree.UserId))
            return Ok(new { Status = "Fail", Message = "Invalid user ID." });

        if (_context.Trees.Any(u => u.TreeId == tree.TreeId))
        {
            return Ok(new { Status = "Fail", Message = "Tree ID already exists." });
        }

        _context.Trees.Add(tree);
        _context.SaveChanges();

        return Ok(new { Status = "Success", Message = "Tree registered successfully." });
    }
}
