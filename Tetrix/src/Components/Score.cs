using Tetrix.src.Settings;
using Tetrix.src.Observer;

namespace Tetrix.src.Components
{
    public class Score : GameElementIF, ObserverIF
    {
        private uint currentScore;
        private ReadOnlyGameSettingsIF gameSettings;

        public Score(ReadOnlyGameSettingsIF gameSettings)
        {
            currentScore = 0;
            this.gameSettings = gameSettings;
        }

        public void draw()
        {
            throw new NotImplementedException();
        }

        public uint getCurrentScore()
        {
            return currentScore;
        }

        public void setCurrentScore(uint currentScore)
        {
            this.currentScore = currentScore;
        }

        public void notify(Board.Events _event)
        {
            switch (_event)
            {
                case Board.Events.LineCleared:
                    currentScore += (uint)(100 * gameSettings.getPointMultiplier());
                    break;
            }
        }
    }
}
