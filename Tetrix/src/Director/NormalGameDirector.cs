namespace Tetrix.src.Director
{
    public class NormalGameDirector : GameDirectorAC
    {
        private Label scoreValueLabel;
        private Label timerValueLabel;
        private Panel boardPanel;
        private uint[] highScores;

        public NormalGameDirector(Label scoreValueLabel, Label timerValueLabel, Panel boardPanel, uint[] highScores)
        {
            this.scoreValueLabel = scoreValueLabel;
            this.timerValueLabel = timerValueLabel;
            this.boardPanel = boardPanel;
            this.highScores = highScores;
        }

        public override Game build(string gameMode)
        {
            gameBuilder.newGame(gameMode, highScores);
            gameBuilder.addBoard(25, 20, boardPanel);
            gameBuilder.addTimer(timerValueLabel);
            gameBuilder.addScore(scoreValueLabel);
            return gameBuilder.getGame();
        }
    }
}
