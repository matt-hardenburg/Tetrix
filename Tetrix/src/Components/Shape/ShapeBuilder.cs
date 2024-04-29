using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public class ShapeBuilder : ShapeBuilderAC
    {
        protected override string generateColor()
        {
            Random rand = new Random();
            switch (rand.Next(1, 7))
            {
                case 1:
                    return "green";
                case 2:
                    return "red";
                case 3:
                    return "blue";
                case 4:
                    return "cyan";
                case 5:
                    return "yellow";
                case 6:
                    return "purple";
                case 7:
                    return "orange";
                default:
                    return "null";
            }
        }

        protected override BlockIF[,] generateStructure(string color)
        {
            BlockIF[,] blocks = new BlockIF[4, 2];

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 2; j++)
                    blocks[i, j] = new BlockContext(-1, -1, "null");

            Random rand = new Random();
            int numOfBlocks = rand.Next(1, 9);
            int row = rand.Next(0, 4);
            int col = rand.Next(0, 2);
            //System.Diagnostics.Debug.WriteLine("NumOfBlocks: " + numOfBlocks);
            for (int num = 1; num <= numOfBlocks; num++)
            {
                blocks[row, col] = new BlockContext(col, row, color);
                int nextRow;
                do
                {
                    nextRow = rand.Next(0, 4);
                } while (!(nextRow >= row - 1) || !(nextRow <= row + 1));
                int nextCol;
                do
                {
                    nextCol = rand.Next(0, 2);
                } while (!(nextCol >= col - 1) || !(nextCol <= col + 1));
                row = nextRow;
                col = nextCol;
            }

            /*for (int i = 0 ; i < blocks.GetLength(0); i++)
            {
                for (int j = 0; j < blocks.GetLength(1); j++)
                {
                    BlockIF block = blocks[i, j];
                    if (!block.getBlockType().getBlockTypeName().Equals("null"))
                    {
                        System.Diagnostics.Debug.Write("color" + " ");
                    }
                    else
                    {
                        System.Diagnostics.Debug.Write("null" + " ");
                    }
                }
                System.Diagnostics.Debug.WriteLine(" ");
            }*/

            return blocks;
        }

        protected override List<BlockIF[,]> generateRotations(BlockIF[,] shape)
        {
            List<BlockIF[,]> output = [];
            if (shape == null) return output;

            BlockIF currentBlock;
            BlockIF[,] r1, r2, r3;

            output.Add(shape); //r0

            r1 = new BlockIF[shape.GetLength(1), shape.GetLength(0)]; // 90 degrees
            r2 = new BlockIF[shape.GetLength(0), shape.GetLength(1)]; // 180 degrees
            r3 = new BlockIF[shape.GetLength(1), shape.GetLength(0)]; // 270 degrees

            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for(int j = 0; j < shape.GetLength(1); j++)
                {
                    currentBlock = shape[i, j];
                    r1[j, shape.GetLength(0) - 1 - i] = currentBlock;
                    r2[shape.GetLength(0) - 1 - i, shape.GetLength(1) - 1 - j] = currentBlock;
                    r3[shape.GetLength(1) - 1 - j, i] = currentBlock;
                }
            }

            output.Add(r1);
            output.Add(r2);
            output.Add(r3);
            
            return output;
        }
    }
}
