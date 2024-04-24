using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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
            foreach (ObservableIF observableComponent in game.getGameComponents())
            {
                observableComponent.addObserver(score);
            }
        }

        public void addTimer()
        {
            game.getGameComponents().Add(new Timer());
        }

        public void newGame(string gameMode)
        {
            game = new Game(gameMode);
        }
    }
}
