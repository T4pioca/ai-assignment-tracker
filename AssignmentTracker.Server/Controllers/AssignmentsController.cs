using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssignmentTracker.Server.Data;
using AssignmentTracker.Server.Models;

namespace AssignmentTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssignmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AssignmentsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/assignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignment>>> GetAssignments()
        {
            return await _context.Assignments.OrderBy(a => a.DueDate).ToListAsync();
        }

        // GET: api/assignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignment>> GetAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null) return NotFound();
            return assignment;
        }

        // POST: api/assignments
        [HttpPost]
        public async Task<ActionResult<Assignment>> CreateAssignment(Assignment assignment)
        {
            _context.Assignments.Add(assignment);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetAssignment), new { id = assignment.Id }, assignment);
        }

        // PUT: api/assignments/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAssignment(int id, Assignment assignment)
        {
            if (id != assignment.Id) return BadRequest();
            _context.Entry(assignment).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/assignments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignment(int id)
        {
            var assignment = await _context.Assignments.FindAsync(id);
            if (assignment == null) return NotFound();
            _context.Assignments.Remove(assignment);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}