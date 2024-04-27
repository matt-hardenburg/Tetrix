using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class InputThread : ThreadAC
    {
        private Board board;
        private string direction;
        private string rotation;

        public InputThread(Board board)
        {
            this.board = board;
            direction = "";
            rotation = "";
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

            if (!rotation.Equals(""))
            {
                board.rotateCurrentShape(rotation);
                rotation = "";
            }

        }

        public void setDirection(string direction)
        {
            this.direction = direction;
        }

        public void setRotation(string rotation)
        {
            this.rotation = rotation;
        }
    }
}
