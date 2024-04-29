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

        public void rotate()
        {
            int currentRowNumber = blocks.GetLength(0);
            int currentColumnNumber = blocks.GetLength(1);
            BlockIF[,] newBlocks = new BlockIF[currentColumnNumber, currentRowNumber];
            int newRowCnt = 0;
            int newColCnt = 0;

            BlockIF offsetBlock = blocks[currentRowNumber / 2, currentColumnNumber / 2];
            int gridOffsetX = offsetBlock.getGridLocationX();
            int gridOffsetY = offsetBlock.getGridLocationY();

            for (int i = 0; i < currentColumnNumber; i++)
            {
                newColCnt = 0;
                for (int j = currentRowNumber - 1; j >= 0; j--)
                {
                    newBlocks[newRowCnt, newColCnt] = blocks[j, i];

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

            for (int i = 0; i < newBlocks.GetLength(0); i++)
            {
                for (int j = 0; j <  newBlocks.GetLength(1); j++)
                {
                    System.Diagnostics.Debug.Write(newBlocks[i, j].getBlockType().getBlockTypeName());
                }
                System.Diagnostics.Debug.WriteLine("");
            }

            blocks = newBlocks;
        }
    }
}
