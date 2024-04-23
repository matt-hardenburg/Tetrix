using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public abstract class ShapeBuilderAC : ShapeBuilderIF
    {
        private ShapeIF shape;

        protected abstract BlockIF[,] generateStructure(string color);

        protected abstract string generateColor();

        void ShapeBuilderIF.generateShape()
        {
            string color = generateColor();
            shape = new Shape(generateStructure(color));
        }

        ShapeIF ShapeBuilderIF.getShape()
        {
            return shape;
        }
    }
}
