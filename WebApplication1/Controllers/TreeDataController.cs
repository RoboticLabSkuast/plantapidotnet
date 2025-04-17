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

    [HttpPost("treedataupload")]
    public async Task<IActionResult> AddTreeDataAsync([FromBody] TreeApidata treeApidata)
    {
        if (!_context.Users.Any(u => u.Id == treeApidata.UserId))
        {
            return Ok(new { Status = "fail", Message = "Invalid user ID." });
        }
        if (!_context.Trees.Any(u => u.TreeId == treeApidata.TreeId))
        {
            return Ok(new { Status = "fail", Message = "Invalid Tree ID." });
        }


  /*      var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");


        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);
  */
        var imagePath = "a";//await SaveImageAsync(treeApidata.ImageData);

        // Map the received data to the database entity (you can handle this part separately)
        var entity = new TreeData
        {
            ImagePath = imagePath,
            UserId = treeApidata.UserId,
            TreeId = treeApidata.TreeId,
            PhenologicalStage = treeApidata.PhenologicalStage,
            StageDate = treeApidata.StageDate,
            GrowthObservations = treeApidata.GrowthObservations,
            BlossomDensity = treeApidata.BlossomDensity,
            InputsApplied = treeApidata.InputsApplied,
            PesticideType = treeApidata.PesticideType,
            PesticideApplicationDate = treeApidata.PesticideApplicationDate,
            PesticideQuantity = treeApidata.PesticideQuantity,
            FertilizerType = treeApidata.FertilizerType,
            FertilizerApplicationDate = treeApidata.FertilizerApplicationDate,
            FertilizerQuantity = treeApidata.FertilizerQuantity,
            ObservedDisease = treeApidata.ObservedDisease,
            DiseaseSeverity = treeApidata.DiseaseSeverity,
            DiseasePhotoPath = treeApidata.DiseasePhotoPath,
            PestIncidence = treeApidata.PestIncidence,
            PestSeverity = treeApidata.PestSeverity,
            TreatmentApplied = treeApidata.TreatmentApplied,
            NutrientDeficiencySymptoms = treeApidata.NutrientDeficiencySymptoms,
            WeatherDamageReports = treeApidata.WeatherDamageReports,
            FruitSetPercentage = treeApidata.FruitSetPercentage,
            HarvestDate = treeApidata.HarvestDate,
            YieldPerTree = treeApidata.YieldPerTree,
            FruitQualityParameters = treeApidata.FruitQualityParameters,
         
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow,
        };
        _context.TreeDatas.Add(entity);
        _context.SaveChanges();

        return Ok(new { Status = "sucess", Message = "Tree data added successfully." });
    }
    private async Task<string> SaveImageAsync(byte[] imageData)
    {
        var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");

        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        var fileName = $"{Guid.NewGuid()}.jpg"; // You can change the extension based on the image format
        var filePath = Path.Combine(uploadsFolder, fileName);

        await System.IO.File.WriteAllBytesAsync(filePath, imageData);

        // Return relative path (you can return full path if needed)
        return Path.Combine("uploads", fileName).Replace("\\", "/");
    }
}