using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class InputThread : ThreadAC
    {
        private Board board;
        private string direction;

        public InputThread(Board board)
        {
            this.board = board;
            direction = "";
        }

        //Not sure how to do yet
        protected override void doJob()
        {
            //System.Diagnostics.Debug.WriteLine("Direction: " + direction + "\n");
            if (!direction.Equals(""))
            {
                board.moveCurrentShape(direction);
                direction = "";
            }
        }

        public void setDirection(string direction)
        {
            this.direction = direction;
        }
    }
}
