using Tetrix.src.Components.Shape;

namespace Tetrix.src.Settings
{
    public interface ReadOnlyGameSettingsIF
    {
        ShapeBuilderIF getShapeBuilder();
        double getMinFallingSpeed();
        double getMaxFallingSpeed();
        double getRampUp();
        double getPointMultiplier();
        double getSpeedIncrement();
    }
}
