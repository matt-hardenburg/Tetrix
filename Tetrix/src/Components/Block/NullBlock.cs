namespace Tetrix.src.Components.Block
{
    public class NullBlock : BlockTypeIF
    {
        public void draw(Graphics graphics, int x, int y, int height, int width)
        {
            Rectangle rectangle = new Rectangle(x, y, width, height);
            graphics.DrawRectangle(new Pen(Color.Black), rectangle);
            graphics.FillRectangle(new SolidBrush(Color.Black), rectangle);
        }

        public string getBlockTypeName()
        {
            return "null";
        }
    }
}
