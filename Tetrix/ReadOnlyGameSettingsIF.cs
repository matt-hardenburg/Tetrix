using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
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
