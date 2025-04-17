using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
namespace WebApplication1.Controllers;
[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration; // Add this line

    public UserController(ApplicationDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration; // Inject IConfiguration
    }

    [HttpPost("register")]
    public IActionResult Register([FromBody] User user)
    {
        if (_context.Users.Any(u => u.Username == user.Username))
            
           
        return Ok(new { Status = "Fail", Message = "Username already exists." });

        _context.Users.Add(user);
        _context.SaveChanges();

        return  Ok(new { Status = "Success", Message = "User registered successfully." });
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User loginRequest)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == loginRequest.Username);
        if (user == null || !(loginRequest.Password == user.Password))
        {
         
           return Unauthorized(new { Status = "Fail",User="" });
        }
       
        return Ok(new {  Status = "Success" ,User=user});
    }

}