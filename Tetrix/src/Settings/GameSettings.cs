using Tetrix.src.Components.Shape;

namespace Tetrix.src.Settings
{
    public class GameSettings : ReadOnlyGameSettingsIF
    {
        private double minFallingSpeed;
        private double maxFallingSpeed;
        private double speedIncrement;
        private double rampUp;
        private double pointMultiplier;
        private ShapeBuilderIF shapeBuilder;

        public GameSettings()
        {
            minFallingSpeed = 3;
            maxFallingSpeed = 0.5;
            speedIncrement = 0.5;
            rampUp = 30;
            pointMultiplier = 1;
            shapeBuilder = new ShapeBuilder();
        }

        public double getMaxFallingSpeed()
        {
            return maxFallingSpeed;
        }

        public double getMinFallingSpeed()
        {
            return minFallingSpeed;
        }

        public double getPointMultiplier()
        {
            return pointMultiplier;
        }

        public double getRampUp()
        {
            return rampUp;
        }

        public ShapeBuilderIF getShapeBuilder()
        {
            return shapeBuilder;
        }

        public double getSpeedIncrement()
        {
            return speedIncrement;
        }

        public void setSpeedIncrement(double speedIncrement)
        {
            this.speedIncrement = speedIncrement;
        }

        public void setMaxFallingSpeed(double maxFallingSpeed)
        {
            this.maxFallingSpeed = maxFallingSpeed;
        }

        public void setMinFallingSpeed(double minFallingSpeed)
        {
            this.minFallingSpeed = minFallingSpeed;
        }

        public void setRampUp(double rampUp)
        {
            this.rampUp = rampUp;
        }

        public void setShapeBuilder(ShapeBuilderIF shapeBuilder)
        {
            this.shapeBuilder = shapeBuilder;
        }

        public void setPointMultiplier(double pointMultiplier)
        {
            this.pointMultiplier = pointMultiplier;
        }
    }
}
