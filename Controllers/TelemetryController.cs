using CMPG323_PROJECT2_39990966.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMPG323_PROJECT2_39990966.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TelemetryController : ControllerBase
    {
        private readonly NWUTechTrendsContext _context;

        public TelemetryController(NWUTechTrendsContext context)
        {
            _context = context;
        }

        // GET: api/Telemetry
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobTelemetry>>> GetAllTelemetry()
        {
            return await _context.JobTelemetries.ToListAsync();
        }

        // GET: api/Telemetry/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<JobTelemetry>> GetTelemetry(int id)
        {
            var telemetry = await _context.JobTelemetries.FindAsync(id);

            if (telemetry == null)
            {
                return NotFound();
            }

            return telemetry;
        }

        // POST: api/Telemetry
        [HttpPost]
        public async Task<ActionResult<JobTelemetry>> PostTelemetry(JobTelemetry telemetry)
        {
            _context.JobTelemetries.Add(telemetry);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTelemetry), new { id = telemetry.Id }, telemetry);
        }

        // PATCH: api/Telemetry/{id}
        [HttpPatch("{id}")]
        public async Task<IActionResult> PatchTelemetry(int id, JobTelemetry telemetry)
        {
            if (id != telemetry.Id)
            {
                return BadRequest();
            }

            _context.Entry(telemetry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TelemetryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Telemetry/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTelemetry(int id)
        {
            var telemetry = await _context.JobTelemetries.FindAsync(id);
            if (telemetry == null)
            {
                return NotFound();
            }

            _context.JobTelemetries.Remove(telemetry);
            await _context.SaveChangesAsync();

            return NoContent();
        }



        // Private method to check if telemetry exists
        private bool TelemetryExists(int id)
        {
            return _context.JobTelemetries.Any(e => e.Id == id);
        }
    }

    // Define SavingsDto
    public class SavingsDto
    {
        public int TotalTimeSaved { get; set; }
        public decimal TotalCostSaved { get; set; }
    }
}
