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
            Thread.Sleep(50);
            game.draw();
        }

        //Finish this
        protected override void shutDown()
        {
            if (Terminator.isNormalShutdown())
            {
                boardPanel.Invoke((MethodInvoker)(() => { boardPanel.Visible = false; }));
                gameOverLabel.Invoke((MethodInvoker)(() => { gameOverLabel.Visible = true; }));
                returnToMainMenuButton.Invoke((MethodInvoker)(() => { returnToMainMenuButton.Visible = true; }));
            }
            else returnToMainMenuButton.Invoke((MethodInvoker)(() => { returnToMainMenuButton.PerformClick(); }));

            base.shutDown();
        }
    }
}
