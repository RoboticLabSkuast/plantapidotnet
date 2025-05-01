using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.DtoModels;
using WebApplication1.Models;
using WebApplication1.old;
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
    public async Task<IActionResult> RegisterTree([FromBody] TreeDto tree)
    {
        CropEntity cropEntity;
        var expertExists = _context.expertEntity.Any(e => e.expert_id == tree.expert_id);
        if (!expertExists)
        {
            return Ok(new { Status = "Fail", Message = "Expert ID does not exist." });
        }

        if (tree == null)
        {
            return Ok(new { Status = "Fail", Message = "Tree data is missing." });
        }

        if (_context.cropsEntity.Any(u => u.qrcodeTree == tree.qrcodeTree))
        {
            return Ok(new { Status = "Fail", Message = "Tree ID already exists." });
        }

         cropEntity = new CropEntity
        {
            qrcodeTree = tree.qrcodeTree,
            name = tree.name,
        };

        _context.cropsEntity.Add(cropEntity);
        await _context.SaveChangesAsync();


        var variety = await _context.varietiesEntity.FirstOrDefaultAsync(v => v.name == tree.varietyName);
        if (variety == null) { 
            variety=new VarietiesEntity { name = tree.varietyName };
            _context.varietiesEntity.Add(variety);
            await _context.SaveChangesAsync();
        }
        var rootstock = await _context.rootstocksEntity.FirstOrDefaultAsync(v => v.name == tree.rootstockName);
        if (rootstock == null)
        {
            rootstock = new RootstocksEntity { name = tree.rootstockName };
            _context.rootstocksEntity.Add(rootstock);
           await  _context.SaveChangesAsync();
        }


        TreesTable crop = new TreesTable
        { expert_id=tree.expert_id,
            crop_id = cropEntity.crop_id,
            variety_id = variety.variety_id,
            rootstock_id = rootstock.rootstock_id,
            agroClimaticZone = tree.agroClimaticZone,
            graftingAge = tree.graftingAge,
            plantAge = tree.plantAge,
            location = tree.location,
            latitude = tree.latitude,
            longitude = tree.longitude,
            region = tree.region,
            row = tree.row,
            coloum = tree.coloum,
            plantStatus = tree.plantStatus,


        };

          _context.treesTables.Add(crop);

        _context.SaveChanges();

        return Ok(new { Status = "Success", Message = "Tree registered successfully." });
    }



}
