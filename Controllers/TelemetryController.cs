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















        // GET: api/Telemetry/GetSavingsByProject
        [HttpGet("GetSavingsByProject")]
        public async Task<ActionResult<SavingsResult>> GetSavingsByProject(
            [FromQuery] Guid projectId,
            [FromQuery] DateTime startDate,
            [FromQuery] DateTime endDate)
        {
            // Validate date range
            if (startDate > endDate)
            {
                return BadRequest("Start date cannot be after end date.");
            }

            // Retrieve Process IDs for the given ProjectId
            var processIds = await _context.Processes
                .Where(p => p.ProjectId == projectId)
                .Select(p => p.ProcessId)
                .ToListAsync();

            // Check if there are any processes for the given project
            if (!processIds.Any())
            {
                return NotFound("No processes found for the specified project.");
            }

            // Retrieve JobTelemetry entries based on Process IDs and date range
            var telemetryEntries = await _context.JobTelemetries
                .Where(t => processIds.Contains(Guid.Parse(t.ProccesId ?? string.Empty))
                            && t.EntryDate >= startDate
                            && t.EntryDate <= endDate)
                .ToListAsync();

            // Check if there are any telemetry entries for the given parameters
            if (!telemetryEntries.Any())
            {
                return NotFound("No telemetry entries found for the specified project and date range.");
            }

            // Calculate total human time and cost saved
            var totalHumanTime = telemetryEntries.Sum(t => t.HumanTime ?? 0);
            var totalCostSaved = CalculateCostSaved(telemetryEntries);

            return Ok(new SavingsResult
            {
                TotalHumanTime = totalHumanTime,
                TotalCostSaved = totalCostSaved
            });
        }

        // Helper method to calculate cost saved
        private decimal CalculateCostSaved(IEnumerable<JobTelemetry> telemetryEntries)
        {
            // Example calculation logic, modify as needed
            return telemetryEntries.Sum(t => (decimal)(t.HumanTime ?? 0) * 0.5m); // Replace with actual cost calculation
        }





    }




    // Define SavingsResult
    public class SavingsResult
    {
        public int TotalHumanTime { get; set; }
        public decimal TotalCostSaved { get; set; }
    }


}
