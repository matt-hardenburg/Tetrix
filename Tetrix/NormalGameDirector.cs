using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class NormalGameDirector : GameDirectorAC
    {
        public override Game build(string gameMode)
        {
            gameBuilder.newGame(gameMode);
            gameBuilder.addBoard(50, 15);
            gameBuilder.addTimer();
            gameBuilder.addScore();
            return gameBuilder.getGame();
        }
    }
}
