using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class InputThread : ThreadAC
    {
        private Board board;
        private string direction;
        private bool rotation;

        public InputThread(Board board)
        {
            this.board = board;
            direction = "";
            rotation = false;
        }

        protected override void doJob()
        {
            if (!direction.Equals(""))
            {
                board.moveCurrentShape(direction);
                direction = "";
            }

            if (rotation)
            {
                board.rotateCurrentShape();
                rotation = false;
            }

        }

        public void setDirection(string direction)
        {
            this.direction = direction;
        }

        public void setRotation(bool rotation)
        {
            this.rotation = rotation;
        }
    }
}
