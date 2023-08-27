using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VideoGameManager.DataAccess
{
    public class GameGenre
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Game> Games { get; set; } = new();
    }

    public class Game
    {
        public int Id { get; set; }

        [MaxLength(250)]
        [Required]
        public string Name { get; set; } = string.Empty;

        public GameGenre? Genre { get; set; }

        public int PersonalRating { get; set; }
    }
}
