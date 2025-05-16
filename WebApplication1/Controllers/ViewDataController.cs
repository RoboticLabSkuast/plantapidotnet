using datacapture.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using WebApplication1.Data;
using WebApplication1.DtoModels;
using WebApplication1.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

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
        public IActionResult GetTreeData(
            [FromQuery] int pageNumber = 1,
            [FromQuery] int pageSize = 10,
            [FromQuery] string cropName = null,
            [FromQuery] string variety = null,
            [FromQuery] string rootstock = null,
            [FromQuery] string phenology = null,
            [FromQuery] string disease = null,
            [FromQuery] string insect = null,
            [FromQuery] string qrcodeTree = null




            )
        {
            var query = _context.observationEntity
                .Include(o => o.crop)
                .Include(o => o.phenologicalEntities).ThenInclude(p => p.phenlogicalStageEntity)
                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Diseases)
                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Insects)
                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Disorder)
                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.MicroNutrient)
                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.WeedControl)
                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.Fertilizer)
                .Include(o => o.yieldandProductivityEntity)
                
               .Join(_context.treesTables,
                o => o.crop_id,
                t => t.crop_id,
                (o, t) => new { Observation = o, Tree = t });

            if (!string.IsNullOrEmpty(qrcodeTree))
            {
                query = query.Where(x => x.Tree.crop.qrcodeTree.Contains(qrcodeTree));
            }

            if (!string.IsNullOrEmpty(cropName))
            {
                query = query.Where(x => x.Observation.crop.name.Contains(cropName));
            }

            if (!string.IsNullOrEmpty(variety))
            {
                query = query.Where(x => x.Tree.variety.name.Contains(variety));
            }
            if (!string.IsNullOrEmpty(rootstock))
                query = query.Where(x => x.Tree.rootstock.name.Contains(rootstock));

            if (!string.IsNullOrEmpty(phenology))
            {
                query = query.Where(x => x.Observation.phenologicalEntities.phenlogicalStageEntity.stageName.Contains(phenology));


            }

            if (!string.IsNullOrEmpty(disease))
            {
                query = query.Where(x => x.Observation.healthandDiseaseEntity.Diseases.diseaseName.name.Contains(disease));
            }

            if (!string.IsNullOrEmpty(insect))
            {
                query = query.Where(x => x.Observation.healthandDiseaseEntity.Insects.insectName.name.Contains(insect));
            }
            




            var result = query
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(o => new TreeObservationDto
                {
                    qrcodeTreeId = o.Observation.crop.qrcodeTree, //o.crop.qrcodeTree,
                    ImagePath = o.Observation.ImagePath ?? string.Empty, // assumes image file is saved using Tree ID



                    crop = new CropEntity
                    {
                        crop_id = o.Observation.crop.crop_id,
                        qrcodeTree = o.Observation.crop.qrcodeTree,
                        name= o.Observation.crop.name
                    },
                  variety = new VarietiesEntity
                    {
                        variety_id = o.Tree.variety_id,
                        name = o.Tree.variety.name,
                        
                    },
                    rootstock = new RootstocksEntity
                    {
                        rootstock_id = o.Tree.rootstock.rootstock_id,
                        name = o.Tree.rootstock.name
                       
                    },
                    phenological = new PhenologicalEntities
                    {
                        phenlogicalStageEntity = new PhenologicalStageEntity
                        {
                            
                            stageName = o.Observation.phenologicalEntities.phenlogicalStageEntity.stageName,
                            
                        },
                        
                        
                        StageDate = o.Observation.phenologicalEntities.StageDate,
                        growthScale = o.Observation.phenologicalEntities.growthScale,
                        blossomDensity = o.Observation.phenologicalEntities.blossomDensity
                    },
                    healthandDisease = new HealthandDiseaseEntity { 
                        Diseases=new DiseasesEntity
                        {
                            diseaseName =new DiseaseNameEntity { name = o.Observation.healthandDiseaseEntity.Diseases.diseaseName.name },
                            level = o.Observation.healthandDiseaseEntity.Diseases.level

                        },
                        Insects= new InsectsEntity
                        {
                            insectName=new InsectNameEntity { name = o.Observation.healthandDiseaseEntity.Insects.insectName.name },
                            level = o.Observation.healthandDiseaseEntity.Insects.level
                        },
                       
                        Disorder=new DisorderEntity
                        {
                            disorderName =new DisorderNameEntity { name = o.Observation.healthandDiseaseEntity.Disorder.disorderName.name },
                            level = o.Observation.healthandDiseaseEntity.Disorder.level
                        },

                       PlantHealth=o.Observation.healthandDiseaseEntity.PlantHealth,
                        NurientDefiency = o.Observation.healthandDiseaseEntity.NurientDefiency,
                        DamageReport = o.Observation.healthandDiseaseEntity.DamageReport
                    },
                   managementPractices= new ManagementPraticesEntity
                    {
                       Fertilizer=new FertilizerEntity {fertilizerName=new FertilizerNameEntity { name = o.Observation.managementPraticesEntity.Fertilizer.fertilizerName.name },
                           amountUsed = o.Observation.managementPraticesEntity.Fertilizer.amountUsed,
                       fertilizerDateTime = o.Observation.managementPraticesEntity.Fertilizer.fertilizerDateTime,
                       },
                       MicroNutrient=new MicroNutrientsEntity
                       {
                          microNutrientName= new MicroNutrientNameEntity { name = o.Observation.managementPraticesEntity.MicroNutrient.microNutrientName.name },
                           amountUsed = o.Observation.managementPraticesEntity.MicroNutrient.amountUsed,
                           microNutrientDateTime = o.Observation.managementPraticesEntity.MicroNutrient.microNutrientDateTime,
                       },
                      WeedControl = new WeedControlEnity
                      {
                         weedControlName = new WeedControlNameEntity{ name = o.Observation.managementPraticesEntity.WeedControl.weedControlName.name
                      },
                          amountUsed = o.Observation.managementPraticesEntity.WeedControl.amountUsed,
                          weedControlDateTime = o.Observation.managementPraticesEntity.WeedControl.weedControlDateTime,
                      },


                    },
                    yieldandProductivity = new YieldandProductivityEntity
                    {
                        
                        fruitSetPercent = o.Observation.yieldandProductivityEntity.fruitSetPercent,
                        harvestDate = o.Observation.yieldandProductivityEntity.harvestDate,
                        yieldAmount = o.Observation.yieldandProductivityEntity.yieldAmount,
                        FruitQuality = o.Observation.yieldandProductivityEntity.FruitQuality
                    }
                })
                .ToList();

            return Ok(new
            {
                Status = "Success",
                Data = result,
                
            });
        }

      

    }
}
