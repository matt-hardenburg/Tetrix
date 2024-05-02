using System.Xml.Linq;

namespace Tetrix.src.Threads
{
    public class GraphicsThread : ThreadAC
    {
        private Game game;
        Panel boardPanel;
        Label gameOverLabel;
        Button returnToMainMenuButton;

        public GraphicsThread(Game game, Panel boardPanel, Label gameOverLabel, Button returnToMainMenuButton)
        {
            this.game = game;
            this.boardPanel = boardPanel;
            this.gameOverLabel = gameOverLabel;
            this.returnToMainMenuButton = returnToMainMenuButton;
        }

        protected override void doJob()
        {
            game.draw();
        }

        protected override void shutDown()
        {
            if (boardPanel.InvokeRequired)
            {
                boardPanel.Invoke((MethodInvoker) (() => { boardPanel.Visible = false; }));
            }
            if (gameOverLabel.InvokeRequired)
            {
                gameOverLabel.Invoke((MethodInvoker)(() => { gameOverLabel.Visible = true; }));
            }
            if (returnToMainMenuButton.InvokeRequired)
            {
                returnToMainMenuButton.Invoke((MethodInvoker)(() => { returnToMainMenuButton.Visible = true; }));
            }
            base.shutDown();
        }
    }
}
