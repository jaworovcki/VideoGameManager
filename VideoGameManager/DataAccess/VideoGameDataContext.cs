using Microsoft.EntityFrameworkCore;

namespace VideoGameManager.DataAccess
{
    public class VideoGameDataContext : DbContext
    {
        public DbSet<Game> Games { get; set; } = null!;
        public DbSet<GameGenre> GameGenres { get; set; } = null!;

        public VideoGameDataContext(DbContextOptions<VideoGameDataContext> options)
            : base(options)
        {
        }
    }
}
