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
            List<Point> options = new List<Point>();
            for (int num = 1; num <= numOfBlocks; num++)
            {
                blocks[row, col] = new BlockContext(col, row, color);
                if (row - 1 >= 0 && blocks[row - 1, col].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col, row - 1));
                if (row + 1 < blocks.GetLength(0) && blocks[row + 1, col].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col, row + 1));
                if (col - 1 >= 0 && blocks[row, col - 1].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col - 1, row));
                if (col + 1 < blocks.GetLength(1) && blocks[row, col + 1].getBlockType().getBlockTypeName().Equals("null"))
                    options.Add(new Point(col + 1, row));
                if (options.Count <= 0)
                {
                    break;
                }
                else
                {
                    int selection = rand.Next(0, options.Count);
                    Point newPoint = options[selection];

                    row = newPoint.Y;
                    col = newPoint.X;
                    options.Clear();
                }
            }

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
