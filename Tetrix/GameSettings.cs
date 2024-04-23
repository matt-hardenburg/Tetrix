using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class GameSettings : ReadOnlyGameSettingsIF
    {
        private int minFallingSpeed;
        private int maxFallingSpeed;
        private int rampUp;
        private int maxStackHeight;
        private int pointMultiplier;
        private ShapeBuilderIF shapeBuilder;

        public GameSettings()
        {
            minFallingSpeed = 5;
            maxFallingSpeed = 1;
            rampUp = 30;
            maxStackHeight = 10;
            pointMultiplier = 1;
            shapeBuilder = new ShapeBuilder();
        }

        int ReadOnlyGameSettingsIF.getMaxFallingSpeed()
        {
            return maxFallingSpeed;
        }

        int ReadOnlyGameSettingsIF.getMaxStackHeight()
        {
            return maxStackHeight;
        }

        int ReadOnlyGameSettingsIF.getMinFallingSpeed()
        {
            return minFallingSpeed;
        }

        int ReadOnlyGameSettingsIF.getPointMultiplier()
        {
            return pointMultiplier;
        }

        int ReadOnlyGameSettingsIF.getRampUp()
        {
            return rampUp;
        }

        ShapeBuilderIF ReadOnlyGameSettingsIF.getShapeBuilder()
        {
            return shapeBuilder;
        }

        public void setMaxFallingSpeed(int maxFallingSpeed)
        {
            this.maxFallingSpeed = maxFallingSpeed;
        }

        public void setMinFallingSpeed(int minFallingSpeed)
        {
            this.minFallingSpeed = minFallingSpeed;
        }

        public void setMaxStackHeight(int maxStackHeight)
        {
            this.maxStackHeight = maxStackHeight;
        }

        public void setRampUp(int rampUp)
        {
            this.rampUp = rampUp;
        }

        public void setShapeBuilder(ShapeBuilderIF shapeBuilder)
        {
            this.shapeBuilder = shapeBuilder;
        }

        public void setPointMultiplier(int pointMultiplier)
        {
            this.pointMultiplier = pointMultiplier;
        }
    }
}
