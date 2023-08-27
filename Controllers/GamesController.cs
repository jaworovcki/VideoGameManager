using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VideoGameManager.DataAccess;

namespace VideoGameManager.Controllers
{
    [ApiController]
    [Route("api/games")]
    public class GamesController : ControllerBase
    {
        private readonly VideoGameDataContext _context;

        public GamesController(VideoGameDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Game>>> GetAllGames()
        {
            return await _context.Games
                .AsNoTracking()
                .ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<Game>> AddGame([FromBody] Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();

            return game;

        }
    }
}
