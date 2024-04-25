using Tetrix.src.Components;
using Tetrix.src.Observer;

namespace Tetrix.src
{
    public class GameBuilder
    {
        private Game game;

        public Game getGame()
        {
            return game;
        }

        public void addBoard(int gridHeight, int gridWidth)
        {
            Board board = new Board(gridHeight, gridWidth);
            board.addObserver(game);
            game.getGameComponents().Add(board);
        }

        public void addScore()
        {
            Score score = new Score(game.getGameSettings());
            game.getGameComponents().Add(score);
            foreach (GameElementIF component in game.getGameComponents())
                if (component is ObservableIF observableComponent)
                    observableComponent.addObserver(score);
        }

        public void addTimer()
        {
            game.getGameComponents().Add(new Components.Timer());
        }

        public void newGame(string gameMode)
        {
            game = new Game(gameMode);
        }
    }
}
