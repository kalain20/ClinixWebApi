using ClinixWebApi.Context;
using ClinixWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClinixWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalisationController : ControllerBase
    {
        private AppDbContext _context;

        public LocalisationController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Localization>> GetLocalisation()
        {
            return await _context.Localizations.ToListAsync();
        }

        [HttpGet("GetLocalizationById/{Id}")]
        public async Task<IActionResult> GetLocalizationById(int Id)
        {
            var localizations = await _context.Localizations.FindAsync(Id);
            return localizations == null ? BadRequest() : Ok(localizations);

        }

        [HttpPost("Location")]
        public async Task<IActionResult> RegisterLocation([FromBody] Localization localizations)
        {
            if (localizations == null)
                return BadRequest();
            await _context.Localizations.AddAsync(localizations);
            await _context.SaveChangesAsync();

            return Ok(new
                {
                    Message = "Location registered"
                }
                
                );
        }
    }
}
