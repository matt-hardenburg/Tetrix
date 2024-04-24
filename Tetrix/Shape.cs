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

        public void draw()
        {
            throw new NotImplementedException();
        }

        public BlockIF[,] getBlocks()
        {
            throw new NotImplementedException();
        }
    }
}
