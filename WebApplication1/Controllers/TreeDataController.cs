using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DtoModels;
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
    [HttpGet("getTreeData")]
    public IActionResult GetTreeAndData(string qrcodeTreeDt)
    {
         var tree = _context.treesTables.Include(t => t.crop)
            .Include(t => t.variety)
            .Include(t => t.rootstock)
            .FirstOrDefault(t => t.crop.qrcodeTree == qrcodeTreeDt);
            if (tree == null)
            {
                return NotFound(new { Status = "Fail", Message = "Tree not found." });
            }
            TreeGetDto treeGetDto = new TreeGetDto
            {
                name = tree.crop.name,
                varietyName = tree.variety.name,
                rootstockName = tree.rootstock.name
            };
        
       


        return Ok(new { Status = "Success", Trees = treeGetDto });
    }

    /* [HttpPost("treedataupload")]
     public async Task<IActionResult> AddTreeDataAsync([FromBody] TreeApidata treeApidata)
     {
         if (!_context.expertEntity.Any(u => u.expert_id == treeApidata.UserId))
         {
             return Ok(new { Status = "Fail", Message = "Invalid user ID." });
         }
         if (!_context.expertEntity.Any(u => u == treeApidata.TreeId))
         {
             return Ok(new { Status = "Fail", Message = "Invalid Tree ID." });
         }


         var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");


         if (!Directory.Exists(uploadsFolder))
             Directory.CreateDirectory(uploadsFolder);

         var imagePath = await SaveImageAsync(treeApidata.ImageData,treeApidata.TreeId);

         // Map the received data to the database entity (you can handle this part separately)
         var entity = new TreeData
         {
             ImagePath = imagePath,
             UserId = treeApidata.UserId,
             TreeId = treeApidata.TreeId,
             PhenologicalStage = treeApidata.PhenologicalStage,
            StageDate = treeApidata.StageDate.ToUniversalTime(),
             GrowthObservations = treeApidata.GrowthObservations,
             BlossomDensity = treeApidata.BlossomDensity,
             InputsApplied = treeApidata.InputsApplied,
             PesticideType = treeApidata.PesticideType,
            PesticideApplicationDate = treeApidata.PesticideApplicationDate.ToUniversalTime(),
             PesticideQuantity = treeApidata.PesticideQuantity,
             FertilizerType = treeApidata.FertilizerType,
             FertilizerApplicationDate = treeApidata.FertilizerApplicationDate.ToUniversalTime(),
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
               HarvestDate = treeApidata.HarvestDate.ToUniversalTime(),
             YieldPerTree = treeApidata.YieldPerTree,
             FruitQualityParameters = treeApidata.FruitQualityParameters
         };
         _context.TreeDatas.Add(entity);
         _context.SaveChanges();

         return Ok(new { Status = "Success", Message = "Tree data added successfully." });
     }
     private async Task<string> SaveImageAsync(byte[] imageData,string treeid)
     {
         var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");

         if (!Directory.Exists(uploadsFolder))
             Directory.CreateDirectory(uploadsFolder);


         var fileName = $"{treeid}_{Guid.NewGuid()}.jpg"; // You can change the extension based on the image format
         var filePath = Path.Combine(uploadsFolder, fileName);

         await System.IO.File.WriteAllBytesAsync(filePath, imageData);

         // Return relative path (you can return full path if needed)
         return Path.Combine("uploads", fileName).Replace("\\", "/");
     }
     [HttpGet("gettreeanddata/{treeId}")]
     public IActionResult GetTreeAndData(string treeId)
     {
         var tree = _context.Trees.FirstOrDefault(t => t.TreeId == treeId);
         if (tree == null)
         {
             return NotFound(new { Status = "Fail", Message = "Tree not found." });
         }

         var treeDataList = _context.TreeDatas
             .Where(td => td.TreeId == treeId)
             .OrderByDescending(td => td.StageDate)
             .ToList();
         foreach (var treeData in treeDataList)
         {
             treeData.ImagePath = ConvertImagePathToBase64(treeData.ImagePath);
         }
         var result = new TreeGetApi
         {
             Tree = tree,
             TreeDataList = treeDataList
         };

         return Ok(new { Status = "Success", Trees = result });
     }
     [HttpGet("getregisteredtrees")]
     public IActionResult GetRegisteredTrees()
     {
         var trees = _context.Trees
             .Select(t => new RegisterTreeGetapi
             {
                 TreeId = t.TreeId,
                 Variety = t.Variety,
                 Location = t.Location,
                 Region = t.Region,
                 OrchardName = t.OrchardName
             })
             .OrderBy(t => t.TreeId)
             .ToList();

         return Ok(new { Status = "Success", Trees= trees });
     }

     private string ConvertImagePathToBase64(string imagePath)
     {
         if (string.IsNullOrEmpty(imagePath)) return string.Empty;

         var fullPath = Path.Combine(_env.WebRootPath, imagePath.TrimStart('/').Replace("/", Path.DirectorySeparatorChar.ToString()));

         if (!System.IO.File.Exists(fullPath)) return string.Empty;

         var imageBytes = System.IO.File.ReadAllBytes(fullPath);
         return Convert.ToBase64String(imageBytes);
     }

     */

}