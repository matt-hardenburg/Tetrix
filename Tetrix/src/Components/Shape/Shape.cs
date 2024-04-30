using System.Diagnostics.Eventing.Reader;
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

        public void setBlocks(BlockIF[,] blocks)
        {
            this.blocks = blocks;
        }

        public BlockIF[,] getRotatedBlocks()
        {
            int currentRowNumber = blocks.GetLength(0);
            int currentColumnNumber = blocks.GetLength(1);
            BlockIF[,] newBlocks = new BlockIF[currentColumnNumber, currentRowNumber];
            int newRowCnt = 0;
            int newColCnt = 0;

            BlockIF offsetBlock;
            int gridOffsetX = 0;
            int gridOffsetY = 0;
            foreach (BlockIF block in blocks)
            {
                if (!block.getBlockType().getBlockTypeName().Equals("null"))
                {
                    offsetBlock = block;
                    gridOffsetX = offsetBlock.getGridLocationX();
                    gridOffsetY = offsetBlock.getGridLocationY();
                    break;
                }
            }

            for (int i = 0; i < currentColumnNumber; i++)
            {
                newColCnt = 0;
                for (int j = currentRowNumber - 1; j >= 0; j--)
                {
                   BlockIF oldBlock = blocks[j, i];
                   newBlocks[newRowCnt, newColCnt] = new BlockContext(oldBlock.getGridLocationX(), oldBlock.getGridLocationY(), oldBlock.getBlockType().getBlockTypeName());
                   if (!blocks[j, i].getBlockType().getBlockTypeName().Equals("null"))
                    {
                        int offsetX = blocks[j, i].getGridLocationX() - gridOffsetX;
                        int offsetY = blocks[j, i].getGridLocationY() - gridOffsetY;
                        newBlocks[newRowCnt, newColCnt].setGridLocationX(gridOffsetX - offsetY);
                        newBlocks[newRowCnt, newColCnt].setGridLocationY(gridOffsetY + offsetX);
                    }

                    newColCnt++;
                }
                newRowCnt++;
            }

            return newBlocks;
        }
    }
}
