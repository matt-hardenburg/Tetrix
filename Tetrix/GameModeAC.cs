using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public abstract class GameModeAC
    {
        private GameEnvironmentIF gameEnvironment;

        public GameModeAC(GameEnvironmentIF gameEnvironment)
        {
            this.gameEnvironment = gameEnvironment;
        }

        public abstract void setMode();

        public GameEnvironmentIF getGameEnvironment()
        {
            return gameEnvironment;
        }
    }
}
