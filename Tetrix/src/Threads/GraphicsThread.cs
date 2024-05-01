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
            Thread.Sleep(50);
            game.draw();
        }

        protected override void shutDown()
        {
            //Fix here 
            System.Diagnostics.Debug.WriteLine("there");
            if (boardPanel.InvokeRequired)
            {
                System.Diagnostics.Debug.WriteLine("yay");
                boardPanel.Invoke((System.Action) (() => { boardPanel.Visible = false; }));
            }

            System.Diagnostics.Debug.WriteLine("yay2");
            gameOverLabel.Invoke((MethodInvoker)(() => { gameOverLabel.Visible = true; }));
            returnToMainMenuButton.Invoke((MethodInvoker)(() => { returnToMainMenuButton.Visible = true; }));
            System.Diagnostics.Debug.WriteLine("here");
            base.shutDown();
        }
    }
}
