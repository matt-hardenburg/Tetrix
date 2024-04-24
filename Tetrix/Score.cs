using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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

        public void notify(int eventNum)
        {
            switch (eventNum)
            {
                case (int)Board.Events.LineCleared:
                    currentScore += (uint) (100 * gameSettings.getPointMultiplier());
                    break;
            }
        }
    }
}
