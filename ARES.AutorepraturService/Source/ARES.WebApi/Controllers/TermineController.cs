
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using Microsoft.EntityFrameworkCore;
using ARES.Businesslogik.Interface;
using ARES.Businesslogik.Models;
namespace ARES.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TermineController : ControllerBase
    {
        private readonly ITerminService _terminService;

        public TermineController(ITerminService terminService)
        {
            _terminService = terminService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Termin>> GetTermin(int id)
        {
            var termin = await _terminService.GetTerminByIdAsync(id);
            if (termin == null)
            {
                return NotFound();
            }
            return Ok(termin);
        }

        [HttpPost]
        public async Task<ActionResult<Termin>> PostTermin(Termin termin)
        {
            await _terminService.AddTerminAsync(termin);
            return CreatedAtAction(nameof(GetTermin), new { id = termin.Id }, termin);
        }
    }



}
