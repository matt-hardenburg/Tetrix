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

        public BlockIF[,] getBlocks()
        {
            return blocks;
        }
    }
}
