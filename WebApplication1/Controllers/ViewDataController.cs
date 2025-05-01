using datacapture.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplication1.Data;
using WebApplication1.DtoModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewDataController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IConfiguration _configuration; // Add this line
        public ViewDataController(ApplicationDbContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration; // Inject IConfiguration
        }



        [HttpGet("gettreedata")]
        public IActionResult GetTreeData([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var observations = _context.observationEntity
                .Include(o => o.crop)
                .Include(o => o.phenologicalEntities).ThenInclude(p => p.phenlogicalStageEntity)
                .Include(o => o.healthandDiseaseEntity)
                .Include(o => o.managementPraticesEntity)
                .Include(o => o.yieldandProductivityEntity)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(o => new TreeObservationDto
                {
                    qrcodeTreeId = o.crop.qrcodeTree,
                    ImagePath = o.ImagePath, // assumes image file is saved using Tree ID
                    phenological = new Phenological
                    {
                        stageName = o.phenologicalEntities.phenlogicalStageEntity.stageName,
                        StageDate = o.phenologicalEntities.StageDate,
                        growthScale = o.phenologicalEntities.growthScale,
                        blossomDensity = o.phenologicalEntities.blossomDensity
                    },
                    healthandDisease = new HealthandDisease
                    {
                        ObservedDisease = o.healthandDiseaseEntity.ObservedDisease,
                        ObservedDiseaseLevel = o.healthandDiseaseEntity.ObservedDiseaseLevel,
                        Insects = o.healthandDiseaseEntity.Insects,
                        InsectsLevel = o.healthandDiseaseEntity.InsectsLevel,
                        PhysiologicalDisorder = o.healthandDiseaseEntity.PhysiologicalDisorder,
                        PhysiologicalDisorderLevel = o.healthandDiseaseEntity.PhysiologicalDisorderLevel,
                        NurientDefiency = o.healthandDiseaseEntity.NurientDefiency,
                        DamageReport = o.healthandDiseaseEntity.DamageReport
                    },
                    managementPractices = new ManagementPractices
                    {
                        fertilizer = o.managementPraticesEntity.fertilizer,
                        fertilizerDateTime = o.managementPraticesEntity.fertilizerDateTime,
                        fertilizerAmount = o.managementPraticesEntity.fertilizerAmount,
                        micronutrients = o.managementPraticesEntity.micronutrients,
                        micronutrientsDateTime = o.managementPraticesEntity.micronutrientsDateTime,
                        micronutrientsAmount = o.managementPraticesEntity.micronutrientsAmount,
                        weedControl = o.managementPraticesEntity.weedControl,
                        weedControlDateTime = o.managementPraticesEntity.weedControlDateTime,
                        weedControlAmount = o.managementPraticesEntity.weedControlAmount
                    },
                    yieldandProductivity = new YieldandProductivity
                    {
                        fruitSetPercent = o.yieldandProductivityEntity.fruitSetPercent,
                        harvestDate = o.yieldandProductivityEntity.harvestDate,
                        yieldAmount = o.yieldandProductivityEntity.yieldAmount,
                        FruitQuality = o.yieldandProductivityEntity.FruitQuality
                    }
                })
                .ToList();

            return Ok(new
            {
                Status = "Success",
                Data = observations,
                PageNumber = pageNumber,
                PageSize = pageSize
            });
        }



    }
}
