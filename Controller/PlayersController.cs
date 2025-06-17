using Microsoft.AspNetCore.Mvc;
using RESTwithVue.Data;
using RESTwithVue.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
