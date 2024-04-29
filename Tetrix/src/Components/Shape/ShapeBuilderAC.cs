using Tetrix.src.Components.Block;

namespace Tetrix.src.Components.Shape
{
    public abstract class ShapeBuilderAC : ShapeBuilderIF
    {
        private ShapeIF shape;

        protected abstract BlockIF[,] generateStructure(string color);

        protected abstract string generateColor();

        protected abstract List<BlockIF[,]> generateRotations(BlockIF[,] shape);

        public void generateShape()
        {
            string color = generateColor();
            shape = new Shape(generateRotations(generateStructure(color)));
        }

        public ShapeIF getShape()
        {
            return shape;
        }
    }
}
