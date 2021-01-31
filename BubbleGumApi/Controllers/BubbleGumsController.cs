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
        public IActionResult PutBubbleGum(int id, [FromBody] string value)
        {
            return NotFound("Not implemented");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBubbleGum(int id)
        {
            return NotFound("Not implemented");
        }
    }
}
