using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class GraphicsThread : ThreadAC
    {
        private Game game;

        public GraphicsThread(Game game)
        {
            this.game = game;
        }

        protected override void doJob()
        {
            Thread.Sleep(250);
            game.draw();
        }

        //Finish this
        protected override void shutDown()
        {
            base.shutDown();
            //Display panel with score
            //Return to main menu
        }
    }
}
