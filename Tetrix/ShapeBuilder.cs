using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Tetrix
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
            BlockIF[,] blocks = new BlockIF[4,2];
            Random rand = new Random();
            int numOfBlocks = rand.Next(1, 8);
            int row = rand.Next(0, 3);
            int col = rand.Next(0, 1);
            for (int num = 1; num <= numOfBlocks; num++)
            {
                blocks[row, col] = new BlockContext(-1, -1, color);
                int nextRow = row;
                do
                {
                    nextRow = rand.Next(0, 3);
                } while (!(nextRow  >= row - 1) && !(nextRow <= row + 1));
                int nextCol = col;
                do
                {
                    nextCol = rand.Next(0, 1);
                } while (!(nextCol >= col - 1) && !(nextCol <= col + 1));
                row = nextRow;
                col = nextCol;
            }
            return blocks;
        }
    }
}
