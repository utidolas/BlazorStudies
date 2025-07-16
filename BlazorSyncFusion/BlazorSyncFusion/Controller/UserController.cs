using BlazorSyncFusion.Data;
using BlazorSyncFusion.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BlazorSyncFusion.Controller 
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        // Constructor to inject the ApplicationDbContext
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if(_context.Users == null)
            {
                return NotFound("Tabela de usuários não encontrada.");
            }
            return await _context.Users.ToListAsync();
        }

    }
}
