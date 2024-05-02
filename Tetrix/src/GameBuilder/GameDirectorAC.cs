namespace Tetrix.src.Director
{
    public abstract class GameDirectorAC
    {
        protected GameBuilder gameBuilder;

        public GameDirectorAC()
        {
            gameBuilder = new GameBuilder();
        }

        public abstract Game build(string gameMode);
    }
}
