using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    internal class HardGameMode : GameModeAC
    {
        public HardGameMode(GameEnvironmentIF gameEnvironment) : base(gameEnvironment)
        {
        }

        public override void setMode()
        {
            GameSettings gameSettings = new GameSettings();

            gameSettings.setMinFallingSpeed(3);
            gameSettings.setMaxFallingSpeed(1);
            gameSettings.setMaxStackHeight(10);
            gameSettings.setRampUp(15);
            gameSettings.setPointMultiplier(2);
            gameSettings.setShapeBuilder(new NonContiguousShapeBuilder());

            getGameEnvironment().setGameSettings(gameSettings);
        }
    }
}
