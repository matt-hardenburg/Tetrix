using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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
