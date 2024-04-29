using Tetrix.src.Settings;
using Tetrix.src.Components.Shape;

namespace Tetrix.src.Modes
{
    public class HardGameMode : GameModeAC
    {
        public HardGameMode(GameEnvironmentIF gameEnvironment) : base(gameEnvironment) { }

        public override void setMode()
        {
            GameSettings gameSettings = new GameSettings();

            gameSettings.setMinFallingSpeed(0.5);
            gameSettings.setMaxFallingSpeed(0.1);
            gameSettings.setSpeedIncrement(0.1);
            gameSettings.setMaxStackHeight(10);
            gameSettings.setRampUp(15);
            gameSettings.setPointMultiplier(3);
            gameSettings.setShapeBuilder(new NonContiguousShapeBuilder());

            getGameEnvironment().setGameSettings(gameSettings);
        }
    }
}
