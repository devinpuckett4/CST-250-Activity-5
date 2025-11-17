
// GameLogic.cs
// Business logic for game mechanics.
// Author: Devin Puckett

using WhackAMole.Models;

namespace WhackAMole.BusinessLogicLayer
{
    public class GameLogic
    {
        public void UpdateScore(GameModel model, int points)
        {
            model.Score += points;
     
        }

        public void UpdateMisses(GameModel model)
        {
            model.Misses++;
            // Penalty: e.g., if Misses > 5, end game.
        }

        public bool CheckEndGame(TimeSpan timeElapsed, GameModel model)
        {
            if (timeElapsed.TotalSeconds >= 60 || model.Misses >= 10)
            {
                return true;
            }
            return false;
        }

        public void UpdateLevel(TimeSpan timeElapsed, GameModel model)
        {
            if (timeElapsed.TotalSeconds > 40) model.Level = 3;
            else if (timeElapsed.TotalSeconds > 20) model.Level = 2;
        }
    }
}