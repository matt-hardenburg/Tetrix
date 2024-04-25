using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class GameThread : ThreadAC
    {
        private ReadOnlyGameSettingsIF gameSettings;
        private Board board;
        private int currentFallingSpeed;
        private int rampUpCounter;

        public GameThread(ReadOnlyGameSettingsIF gameSettings, Board board)
        {
            this.gameSettings = gameSettings;
            this.board = board;
            currentFallingSpeed = gameSettings.getMinFallingSpeed();
            rampUpCounter = 0;
        }

        protected override void doJob()
        {
            Thread.Sleep(currentFallingSpeed * 1000);
            board.moveCurrentShape("down");
            rampUpCounter++;
            if (currentFallingSpeed > gameSettings.getMaxFallingSpeed())
            {
                rampUpCounter++;
                if (rampUpCounter == gameSettings.getRampUp())
                {
                    rampUpCounter = 0;
                    currentFallingSpeed--;
                }
            }
        }

        //Write highscore and display 
        protected override void shutDown()
        {
            base.shutDown();
        }
    }
}
