using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
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
            
            return BadRequest("Username already exists.");

        // Hash the password (assuming you've implemented a hashing method)
        user.PasswordHash = HashPassword(user.PasswordHash);

        _context.Users.Add(user);
        _context.SaveChanges();

        return Ok("User registered successfully.");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User loginRequest)
    {
        var user = _context.Users.FirstOrDefault(u => u.Username == loginRequest.Username);
        if (user == null || !VerifyPassword(loginRequest.PasswordHash, user.PasswordHash))
        {
         
           return Unauthorized(new { Status = "fail" });
        }
       // var token = GenerateJwtToken(user);
        
        return Ok(new {  Status = "success" });
    }

  /*  private string GenerateJwtToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.Username)
        };

        var token = new JwtSecurityToken(
            issuer: _configuration["Jwt:Issuer"],
            audience: _configuration["Jwt:Audience"],
            claims: claims,
            expires: DateTime.Now.AddHours(1),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }*/

    // Example methods for password hashing and verification
    private string HashPassword(string password)
    {
        // Implement your hashing logic here (e.g., PBKDF2 or SHA256)
        return password; // Replace with actual hashing logic
    }

    private bool VerifyPassword(string inputPassword, string storedHash)
    {
        // Implement your verification logic here
        return inputPassword == storedHash; // Replace with actual verification logic
    }
}