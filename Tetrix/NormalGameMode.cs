using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class NormalGameMode : GameModeAC
    {
        public NormalGameMode(GameEnvironmentIF gameEnvironment) : base(gameEnvironment)
        {
        }

        public override void setMode()
        {
            getGameEnvironment().setGameSettings(new GameSettings());
        }
    }
}
