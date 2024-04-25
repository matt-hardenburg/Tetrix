namespace Tetrix.src.Director
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
