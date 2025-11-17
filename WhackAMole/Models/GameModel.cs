
// GameModel.cs
// Model for game state (score, misses, level).
namespace WhackAMole.Models
{
    public class GameModel
    {
        public int Score { get; set; } = 0;
        public int Misses { get; set; } = 0;
        public int Level { get; set; } = 1;
        public DateTime Date { get; set; } = DateTime.Now;
        // TODO: Add PlayerName if doing high scores.
    }
}