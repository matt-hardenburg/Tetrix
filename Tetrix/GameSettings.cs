using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class GameSettings : ReadOnlyGameSettingsIF
    {
        //Change to more uints?
        private int minFallingSpeed;
        private int maxFallingSpeed;
        private int rampUp;
        private int maxStackHeight;
        private double pointMultiplier;
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

        public int getMaxFallingSpeed()
        {
            return maxFallingSpeed;
        }

        public int getMaxStackHeight()
        {
            return maxStackHeight;
        }

        public int getMinFallingSpeed()
        {
            return minFallingSpeed;
        }

        public double getPointMultiplier()
        {
            return pointMultiplier;
        }

        public int getRampUp()
        {
            return rampUp;
        }

        public ShapeBuilderIF getShapeBuilder()
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

        public void setPointMultiplier(double pointMultiplier)
        {
            this.pointMultiplier = pointMultiplier;
        }
    }
}
