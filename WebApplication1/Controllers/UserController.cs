using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.DtoModels;
using WebApplication1.Models;
using WebApplication1.old;
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
    public IActionResult Register([FromBody] ExpertDto user)
    {
        if (_context.expertEntity.Any(u => u.username == user.username))
            
           
        return Ok(new { Status = "Fail", Message = "Username already exists." });
        ExpertEntity newUser = new ExpertEntity
        {
            username = user.username,
            role = user.role,
            name = user.name,
            email = user.email,
            phone = user.phone,

            year = user.year,
            department = user.department,
            password = user.password, // In a real application, hash the password before storing it
            bio = user.bio
        };
        _context.expertEntity.Add(newUser);
        _context.SaveChanges();

        return  Ok(new { Status = "Success", Message = "User registered successfully." });
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginUserClass loginRequest)
    {
        var user = _context.expertEntity.FirstOrDefault(u => u.username == loginRequest.username);
        if (user == null || !(loginRequest.password == user.password))
        {
         
           return Unauthorized(new { Status = "Fail",User="" });
        }
        ExpertDto expert = new ExpertDto { 
            expert_id= user.expert_id,
            username =user.username,
            role = user.role,
            name = user.name,
            password="",
            email = user.email,
            phone = user.phone,
           year= user.year,
            department=user.department,
            bio = user.bio
        };
        return Ok(new {  Status = "Success" ,User= expert });
    }
    [HttpGet("getAllUsers")]
    public IActionResult GetAllUsers()
    {
        var users = _context.expertEntity.ToList(); // This retrieves all users from the database
        if (users == null || users.Count == 0)
        {
            return NotFound(new { Status = "Fail", Message = "No users found" });
        }

        return Ok(new { Status = "Success", Users = users });
    }


}