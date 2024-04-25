using Tetrix.src.Settings;

namespace Tetrix.src.Modes
{
    public class NormalGameMode : GameModeAC
    {
        public NormalGameMode(GameEnvironmentIF gameEnvironment) : base(gameEnvironment) { }

        public override void setMode()
        {
            getGameEnvironment().setGameSettings(new GameSettings());
        }
    }
}
