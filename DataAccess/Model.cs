using System.ComponentModel.DataAnnotations;

namespace VideoGameManager.DataAccess
{
    public class GameGenre
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; } = string.Empty;

        public List<Game> Games { get; set; } = new();
    }

    public class Game
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; } = string.Empty;

        public GameGenre Genre { get; set; } = null!;

        public int PersonalRating { get; set; }
    }
}
