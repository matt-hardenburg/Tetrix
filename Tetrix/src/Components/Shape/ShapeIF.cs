using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public interface ShapeIF : GameElementIF
    {
        BlockIF[,] getBlocks();
    }
}
