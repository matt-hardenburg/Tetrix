
namespace Tetrix.src.Components.Block
{
    public class ColoredBlock : BlockTypeIF
    {
        private Color color;

        public ColoredBlock(Color color) { this.color = color; }

        public void draw(Graphics graphics, int x, int y, int height, int width)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            graphics.DrawRectangle(new Pen(color), rectangle);
            graphics.FillRectangle(new SolidBrush(color), rectangle);
        }

        public string getBlockTypeName()
        {
            return color.Name.ToLower();
        }
    }
}
