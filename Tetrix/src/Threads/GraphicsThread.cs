namespace Tetrix.src.Threads
{
    public class GraphicsThread : ThreadAC
    {
        private Game game;
        Panel boardPanel;
        Label gameOverLabel;
        Button returnToMainMenuButton;

        public GraphicsThread(Game game, Panel boardPanel, Label gameOverLabel, Button returnButton)
        {
            this.game = game;
            this.boardPanel = boardPanel;
            this.gameOverLabel = gameOverLabel;
            this.returnToMainMenuButton = returnButton;
        }

        protected override void doJob()
        {
            Thread.Sleep(250);
            game.draw();
        }

        //Finish this
        protected override void shutDown()
        {
            if(Terminator.isNormalShutdown())
            {
                boardPanel.Visible = false;
                gameOverLabel.Visible = true;
                returnToMainMenuButton.Visible = true;
            }

            returnToMainMenuButton.PerformClick();

            base.shutDown();
        }
    }
}
