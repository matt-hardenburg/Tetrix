using System.Diagnostics.Eventing.Reader;
using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public class Shape : ShapeIF
    {
        private BlockIF[,] blocks;
        private List<BlockIF[,]> rotations; //stored rotating clockwise

        public Shape(List<BlockIF[,]> rotations)
        {
            this.rotations = rotations;
            this.blocks = rotations.ElementAt(0);
        }

        public BlockIF[,] getBlocks()
        {
            return blocks;
        }

        public List<BlockIF[,]> getRotations()
        {
            return rotations;
        }

        public void setBlocks(BlockIF[,] rotation)
        {
            this.blocks = rotation;
        }

        public void transferCoords(BlockIF[,] original, int oldRotate, int newRotate)
        {
            if (original == null) throw new Exception();

            bool rightRotate;

            for (int i = 0; i < original.GetLength(0); i++)
            {
                for (int j = 0; j < original.GetLength(1); j++)
                {
                    if (original[i, j].getBlockType().getBlockTypeName().Equals("null")) continue;
                    int x = original[i, j].getGridLocationX();
                    int y = original[i, j].getGridLocationY();
                    int shiftI = blocks.GetLength(0) - 1 - i;
                    int shiftJ = blocks.GetLength(1) - 1 - j;

                    if (oldRotate == 0 && newRotate == 3) rightRotate = false; // -90
                    else if (oldRotate == 3 && newRotate == 0) rightRotate = true; // +90
                    else rightRotate = oldRotate < newRotate;

                    switch (rightRotate)
                    {
                        case true: // +90
                            blocks[j, shiftI].setGridLocationX(x); //TODO: right rotate out of bounds
                            blocks[j, shiftI].setGridLocationY(y);
                            break;
                        case false: // -90
                            blocks[shiftJ, i].setGridLocationX(x); //TODO: left rotate out of bounds
                            blocks[shiftJ, i].setGridLocationY(y);
                            break;
                    }
                }
            }
        }
    }
}
