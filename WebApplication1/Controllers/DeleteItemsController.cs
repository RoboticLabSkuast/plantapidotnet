//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using WebApplication1.Data;
//using WebApplication1.DtoModels;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class DeleteItemsController : Controller
//    {
//        private readonly ApplicationDbContext _context;
//        private readonly IConfiguration _configuration; // Add this line
//        public DeleteItemsController(ApplicationDbContext context, IConfiguration configuration)
//        {
//            _context = context;
//            _configuration = configuration; // Inject IConfiguration
//        }
//        [HttpDelete("deleteitem")]
//        public IActionResult DeleteTreeData(
//      [FromQuery] string cropName = null,
//      [FromQuery] string variety = null,
//      [FromQuery] string rootstock = null,
//      [FromQuery] string phenology = null,
//      [FromQuery] string disease = null,
//      [FromQuery] string insect = null,
//      [FromQuery] string qrcodeTree = null
//  )
//        {
//            var query = _context.observationEntity
//                .Include(o => o.crop)
//                .Include(o => o.phenologicalEntities).ThenInclude(p => p.phenlogicalStageEntity)
//                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Diseases)
//                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Insects)
//                .Include(o => o.healthandDiseaseEntity).ThenInclude(p => p.Disorder)
//                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.MicroNutrient)
//                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.WeedControl)
//                .Include(o => o.managementPraticesEntity).ThenInclude(p => p.Fertilizer)
//                .Include(o => o.yieldandProductivityEntity)
//                .Join(_context.treesTables,
//                    o => o.crop_id,
//                    t => t.crop_id,
//                    (o, t) => new { Observation = o, Tree = t });

//            if (!string.IsNullOrEmpty(qrcodeTree))
//                query = query.Where(x => x.Tree.crop.qrcodeTree.Contains(qrcodeTree));

//            if (!string.IsNullOrEmpty(cropName))
//                query = query.Where(x => x.Observation.crop.name.Contains(cropName));

//            if (!string.IsNullOrEmpty(variety))
//                query = query.Where(x => x.Tree.variety.name.Contains(variety));

//            if (!string.IsNullOrEmpty(rootstock))
//                query = query.Where(x => x.Tree.rootstock.name.Contains(rootstock));

//            if (!string.IsNullOrEmpty(phenology))
//                query = query.Where(x => x.Observation.phenologicalEntities.phenlogicalStageEntity.stageName.Contains(phenology));

//            if (!string.IsNullOrEmpty(disease))
//                query = query.Where(x => x.Observation.healthandDiseaseEntity.Diseases.diseaseName.name.Contains(disease));

//            if (!string.IsNullOrEmpty(insect))
//                query = query.Where(x => x.Observation.healthandDiseaseEntity.Insects.insectName.name.Contains(insect));

//            var itemsToDelete = query.Select(x => x.Observation).ToList();

//            if (!itemsToDelete.Any())
//            {
//                return NotFound(new { Status = "No matching records found to delete." });
//            }

//            try
//            {
//                _context.observationEntity.RemoveRange(itemsToDelete);
//                _context.SaveChanges();

//                return Ok(new
//                {
//                    Status = "Success",
//                    DeletedCount = itemsToDelete.Count
//                });
//            }
//            catch (Exception ex)
//            {
//                return StatusCode(500, new
//                {
//                    Status = "Error",
//                    Message = $"Failed to delete records: {ex.Message}"
//                });
//            }
//        }


//    }
//}
