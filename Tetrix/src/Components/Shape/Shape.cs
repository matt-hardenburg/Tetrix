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

            BlockIF offsetBlock = blocks[0, 0];
            int gridOffsetX = 0;
            int gridOffsetY = 0;
            int targetX = currentColumnNumber / 2;
            int targetY = currentRowNumber / 2;
            bool firstBlock = true;

            for (int i = 0; i < currentRowNumber; i++)
            {
                for (int j = 0; j < currentColumnNumber; j++)
                {
                    if (!blocks[i, j].getBlockType().getBlockTypeName().Equals("null"))
                    {
                        if (firstBlock)
                        {
                            offsetBlock = blocks[i, j];
                            firstBlock = false;
                        }
                        gridOffsetX = blocks[i, j].getGridLocationX();
                        gridOffsetY = blocks[i, j].getGridLocationY();
                        if (Math.Abs(targetY - currentRowNumber) <= gridOffsetX && Math.Abs(targetX - currentColumnNumber) <= gridOffsetY)
                            offsetBlock = blocks[i, j];
                    }
                }
            }

            gridOffsetX = offsetBlock.getGridLocationX();
            gridOffsetY = offsetBlock.getGridLocationY();

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
