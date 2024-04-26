namespace Tetrix.src.Director
{
    public class NormalGameDirector : GameDirectorAC
    {
        private Label scoreValueLabel;
        private Label timerValueLabel;

        public NormalGameDirector(Label scoreValueLabel, Label timerValueLabel)
        {
            this.scoreValueLabel = scoreValueLabel;
            this.timerValueLabel = timerValueLabel;
        }

        public override Game build(string gameMode)
        {
            gameBuilder.newGame(gameMode);
            gameBuilder.addBoard(50, 15);
            gameBuilder.addTimer(timerValueLabel);
            gameBuilder.addScore(scoreValueLabel);
            return gameBuilder.getGame();
        }
    }
}
