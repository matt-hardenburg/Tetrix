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

        void GameElementIF.draw()
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

        void ObserverIF.notify(int eventNum)
        {
            switch (eventNum)
            {
                case (int)Board.Events.LineCleared:
                    currentScore += 100;
                    break;
            }
        }
    }
}
