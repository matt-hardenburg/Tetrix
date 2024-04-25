using Tetrix.src.Components.Shape;

namespace Tetrix.src.Settings
{
    public interface ReadOnlyGameSettingsIF
    {
        ShapeBuilderIF getShapeBuilder();
        int getMinFallingSpeed();
        int getMaxFallingSpeed();
        int getRampUp();
        int getMaxStackHeight();
        double getPointMultiplier();
    }
}
