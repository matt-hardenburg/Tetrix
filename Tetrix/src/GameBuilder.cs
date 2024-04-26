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

        public void addScore(Label scoreValueLabel)
        {
            Score score = new Score(game.getGameSettings(), scoreValueLabel);
            game.getGameComponents().Add(score);
            foreach (GameElementIF component in game.getGameComponents())
                if (component is ObservableIF observableComponent)
                    observableComponent.addObserver(score);
        }

        public void addTimer(Label timervalueLabel)
        {
            game.getGameComponents().Add(new Components.Timer(timervalueLabel));
        }

        public void newGame(string gameMode)
        {
            game = new Game(gameMode);
        }
    }
}
