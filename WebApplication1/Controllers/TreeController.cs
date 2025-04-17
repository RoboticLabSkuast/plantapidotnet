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
            return BadRequest("Invalid user ID.");

        _context.Trees.Add(tree);
        _context.SaveChanges();

        return Ok("Tree registered successfully.");
    }
}
