using datacapture.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.DtoModels;
using WebApplication1.Models;
using WebApplication1.old;

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
            rootstockName = tree.rootstock.name,
            qrcodeTreeId = qrcodeTreeDt

        };




        return Ok(new { Trees = treeGetDto });
    }
    [HttpGet("getregisteredtrees")]
    public IActionResult GetRegisteredTrees()
    {
        var trees = _context.treesTables.Include(t => t.crop)
            .Select(t => new RegisterTreeGetapi
            {
                qrcodeTree = t.crop.qrcodeTree,
                Variety = t.variety.name,
                //  Location = t.Location,
                Region = t.location,
                CropName = t.crop.name,

            })

            .ToList();

        return Ok(new { Status = "Success", Trees = trees });
    }

    [HttpPost("treedataupload")]
    public async Task<IActionResult> AddTreeDataAsync([FromBody] UploadClass treeApidata)
    {
        var crop = _context.treesTables
     .Include(u => u.crop)
     .FirstOrDefault(u => u.crop.qrcodeTree == treeApidata.qrcodeTreeId)?
     .crop;


        if (crop == null)
        {
            return Ok(new { Status = "Fail", Message = "Invalid Tree ID." });
        }


        var uploadsFolder = Path.Combine(_env.WebRootPath, "uploads");


        if (!Directory.Exists(uploadsFolder))
            Directory.CreateDirectory(uploadsFolder);

        var imagePath = await SaveImageAsync(treeApidata.ImageData, treeApidata.qrcodeTreeId);
        ///--------------------pheno--------------
        var phenologicalStage = _context.phenologicalEntities
            .Include(s => s.phenlogicalStageEntity)
      .FirstOrDefault(s => s.phenlogicalStageEntity.stageName == treeApidata.phenological.stageName)?.phenlogicalStageEntity;

        if (phenologicalStage == null)
        {
            phenologicalStage = new PhenologicalStageEntity
            {
                stageName = treeApidata.phenological.stageName
            };
            _context.phenologicalStageEntity.Add(phenologicalStage);
       
        }


        var phenologicalEntity = new PhenologicalEntities
        {
            phenologicalStageEntity_Id = phenologicalStage.phenologicalStageEntity_Id,
            phenlogicalStageEntity = phenologicalStage,
            StageDate = treeApidata.phenological.StageDate.ToUniversalTime(),
            growthScale = treeApidata.phenological.growthScale,
            blossomDensity = treeApidata.phenological.blossomDensity
        };
        _context.phenologicalEntities.Add(phenologicalEntity);

       //-----------------health----------------------------
        var diseaseName = _context.diseaseNameEntities
            .FirstOrDefault(s => s.name == treeApidata.healthandDisease.ObservedDisease);
        if (diseaseName == null)
        {
            diseaseName = new DiseaseNameEntity
            {
                name = treeApidata.healthandDisease.ObservedDisease
            };
            _context.diseaseNameEntities.Add(diseaseName);
        }

        
         var   diseasesEntity = new DiseasesEntity
            {
                diseaseName=diseaseName,
                level = treeApidata.healthandDisease.ObservedDiseaseLevel
            };
            _context.diseasesEntities.Add(diseasesEntity);


        var insectName = _context.insectNameEntities
            .FirstOrDefault(s => s.name == treeApidata.healthandDisease.Insects);


        if (insectName == null)
            insectName = new InsectNameEntity
            {
                name = treeApidata.healthandDisease.Insects
            };
        
            var insectsEntity = new InsectsEntity
            {
                insectName=insectName,
                level = treeApidata.healthandDisease.InsectsLevel
            };
            _context.insectsEntities.Add(insectsEntity);

        

        var disorderName=_context.disorderNameEntities
            .FirstOrDefault(s=>s.name == treeApidata.healthandDisease.PhysiologicalDisorder);
        if (disorderName == null)
        {
            disorderName = new DisorderNameEntity
            {
                name = treeApidata.healthandDisease.PhysiologicalDisorder
            };
        }


       
        
           var  disorderEntity = new DisorderEntity
            {
               disorderName=disorderName,
                level = treeApidata.healthandDisease.PhysiologicalDisorderLevel
            };
            _context.disorderEntities.Add(disorderEntity);

        
     



        var healthandEntity = new HealthandDiseaseEntity
        {
            PlantHealth = treeApidata.healthandDisease.planthealth,
            Diseases = diseasesEntity,

            Insects = insectsEntity,

            Disorder = disorderEntity,

            NurientDefiency = treeApidata.healthandDisease.NurientDefiency,
            DamageReport = treeApidata.healthandDisease.DamageReport
        };

        _context.healthandEntity.Add(healthandEntity);
      

        var fertilizerName=_context.fertilizerNameEntities
            .FirstOrDefault(s=>s.name == treeApidata.managementPractices.fertilizer);

        if (fertilizerName == null)
        {
            fertilizerName = new FertilizerNameEntity
            {
                name = treeApidata.managementPractices.fertilizer
            };
        }

        
          var  fertilizerEntity = new FertilizerEntity
            {
               fertilizerName=fertilizerName,
                amountUsed = treeApidata.managementPractices.fertilizerAmount,
                fertilizerDateTime = treeApidata.managementPractices.fertilizerDateTime.ToUniversalTime()
            };
            _context.fertilizerEntities.Add(fertilizerEntity);


        var micronutrientName = _context.microNutrientNameEntities
            .FirstOrDefault(s => s.name == treeApidata.managementPractices.micronutrients);

        if (micronutrientName == null)
        {
            micronutrientName = new MicroNutrientNameEntity
            {
                name = treeApidata.managementPractices.micronutrients
            };
        }
          var  micronutrientEntity = new MicroNutrientsEntity
            {
                microNutrientName = micronutrientName,
                amountUsed = treeApidata.managementPractices.micronutrientsAmount,
                microNutrientDateTime = treeApidata.managementPractices.micronutrientsDateTime.ToUniversalTime()
            };
            _context.microNutrientsEntities.Add(micronutrientEntity);
          
        

    var weedControlName = _context.weedControlNameEntities
        .FirstOrDefault(s => s.name == treeApidata.managementPractices.weedControl);

      if (weedControlName == null)
        {
            weedControlName = new WeedControlNameEntity
            {
                name = treeApidata.managementPractices.weedControl
            };
        }
      var weedControlEntity=new WeedControlEnity { 
                weedControlName= weedControlName,
                amountUsed = treeApidata.managementPractices.weedControlAmount,
                weedControlDateTime = treeApidata.managementPractices.weedControlDateTime.ToUniversalTime()
            };
            _context.weedControlEntities.Add(weedControlEntity);
         
        


        var managementEntity = new ManagementPraticesEntity
        {
            Fertilizer = fertilizerEntity,

            MicroNutrient = micronutrientEntity,
            WeedControl = weedControlEntity


        };
    


        _context.managementPraticesEntities.Add(managementEntity);
   



        var yieldEntity = new YieldandProductivityEntity
        {
            fruitSetPercent = treeApidata.yieldandProductivity.fruitSetPercent,
            harvestDate = treeApidata.yieldandProductivity.harvestDate.ToUniversalTime(),
            yieldAmount = treeApidata.yieldandProductivity.yieldAmount,
            FruitQuality = treeApidata.yieldandProductivity.FruitQuality
        };
        _context.yieldandProductivityEntities.Add(yieldEntity);
        

        // 5. Create main ObservationEntity
        var observation = new ObservationEntity
        {
         //   crop_id = crop.crop_id,
            crop = crop,
            ImagePath= imagePath,
          //  phenologicalEntities_Id = phenologicalEntity.phenologicalEntities_Id,
            phenologicalEntities = phenologicalEntity,
          //  healthandDiseaseEntity_Id = healthandEntity.healthandDiseaseEntity_Id,
            healthandDiseaseEntity = healthandEntity,
         //   managementPraticesEntity_Id = managementEntity.managementPraticesEntity_Id,
            managementPraticesEntity = managementEntity,
         //   yieldandProductivityEntity_Id = yieldEntity.yieldandProductivityEntity_Id,
            yieldandProductivityEntity = yieldEntity
        };
        _context.observationEntity.Add(observation);
        await _context.SaveChangesAsync();

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
  /*   [HttpGet("gettreeanddata/{treeId}")]
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