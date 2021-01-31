using BubbleGumApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BubbleGumApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BubbleGumsController : ControllerBase
    {
        private BubbleGumContext _context;
        public BubbleGumsController(BubbleGumContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetBubbleGums()
        {
            return Ok(await _context.bubbleGums.ToArrayAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetBubbleGum(int id)
        {
            var bubbleGum = await _context.bubbleGums.FindAsync(id);

            if(bubbleGum == null) 
            {
                return NotFound();
            }

            return Ok(bubbleGum);
        }

        [HttpPost]
        public async Task<IActionResult> PostBubbleGum([FromBody] BubbleGum bubbleGum)
        {
            _context.bubbleGums.Add(bubbleGum);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBubbleGum", new { id = bubbleGum.Id }, bubbleGum);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutBubbleGum(int id, [FromBody] BubbleGum bubbleGum)
        {
            _context.Entry(bubbleGum).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            //return NoContent();
            return CreatedAtAction("GetBubbleGum", new { id = bubbleGum.Id }, bubbleGum);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<BubbleGum>> DeleteBubbleGum(int id)
        {
            var bubbleGum = await _context.bubbleGums.FindAsync(id);

            if (bubbleGum == null)
            {
                return NotFound();
            }

            _context.Remove(bubbleGum);
            await _context.SaveChangesAsync();

            return bubbleGum;
        }
    }
}
