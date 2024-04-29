using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public interface ShapeIF
    {
        BlockIF[,] getBlocks();
        void setBlocks(BlockIF[,] blocks);
        void rotate();
    }
}
