using Microsoft.AspNetCore.Mvc;
using RESTwithVue.Data;
using RESTwithVue.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace RESTwithVue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
       private readonly AppDbContext _context;

       public PlayersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Players.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> PostData(Player player)
        {
            _context.Players.Add(player);
            await _context.SaveChangesAsync();
            return Ok(player);
        }
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var player = _context.Players.Find(id);
            if (player == null) return NotFound();

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
