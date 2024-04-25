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
