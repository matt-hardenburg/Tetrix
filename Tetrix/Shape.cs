using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class Shape : ShapeIF
    {
        private BlockIF[,] blocks;

        public Shape(BlockIF[,] blocks)
        {
            this.blocks = blocks;
        }

        void GameElementIF.draw()
        {
            throw new NotImplementedException();
        }

        BlockIF[,] ShapeIF.getBlocks()
        {
            throw new NotImplementedException();
        }
    }
}
