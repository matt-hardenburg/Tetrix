using Tetrix.src;

namespace Tetrix.src.Modes
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
