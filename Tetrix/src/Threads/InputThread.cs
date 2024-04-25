using Tetrix.src.Components;

namespace Tetrix.src.Threads
{
    public class InputThread : ThreadAC
    {
        private Board board;

        public InputThread(Board board)
        {
            this.board = board;
        }

        //Not sure how to do yet
        protected override void doJob()
        {
            throw new NotImplementedException();
        }
    }
}
