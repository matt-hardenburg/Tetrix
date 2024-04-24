using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public abstract class GameDirectorAC
    {
        protected GameBuilder gameBuilder;

        public GameDirectorAC()
        {
            gameBuilder = new GameBuilder();
        }

        public abstract Game build(string gameMode);
    }
}
