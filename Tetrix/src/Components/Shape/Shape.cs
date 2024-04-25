using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
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
