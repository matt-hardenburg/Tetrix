using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public interface ShapeIF
    {
        BlockIF[,] getBlocks();
        void setBlocks(BlockIF[,] rotation);
        List<BlockIF[,]> getRotations();
        void transferCoords(BlockIF[,] original, int oldRotate, int newRotate);

    }
}
