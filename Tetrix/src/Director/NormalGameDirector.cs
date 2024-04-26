namespace Tetrix.src.Director
{
    public class NormalGameDirector : GameDirectorAC
    {
        private Label scoreValueLabel;
        private Label timerValueLabel;
        private Panel boardPanel;

        public NormalGameDirector(Label scoreValueLabel, Label timerValueLabel, Panel boardPanel)
        {
            this.scoreValueLabel = scoreValueLabel;
            this.timerValueLabel = timerValueLabel;
            this.boardPanel = boardPanel;
        }

        public override Game build(string gameMode)
        {
            gameBuilder.newGame(gameMode);
            gameBuilder.addBoard(50, 15, boardPanel);
            gameBuilder.addTimer(timerValueLabel);
            gameBuilder.addScore(scoreValueLabel);
            return gameBuilder.getGame();
        }
    }
}
