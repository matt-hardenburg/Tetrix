using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public interface GameEnvironmentIF
    {
        void setGameSettings(GameSettings gameSettings);
        ReadOnlyGameSettingsIF getGameSettings();
    }
}
