using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class InputThread : ThreadAC
    {
        private Board board;
        private Form? form;
        private string direction;

        public InputThread(Board board)
        {
            this.board = board;
            form = Application.OpenForms[0];
            direction = "";
        }

        //Not sure how to do yet
        protected override void doJob()
        {
            if (direction.Equals("")) return;
            board.moveCurrentShape(direction);
            direction = "";
        }

        private void App_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                case Keys.Left:
                    direction = "left";
                    Console.WriteLine("Left");
                    break;
                case Keys.S:
                case Keys.Down:
                    direction = "down";
                    Console.WriteLine("Down");
                    break;
                case Keys.D:
                case Keys.Right:
                    direction = "right";
                    Console.WriteLine("Right");
                    break;

            }
        }
    }
}
