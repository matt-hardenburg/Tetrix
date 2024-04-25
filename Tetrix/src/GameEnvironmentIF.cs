using Tetrix.src.Settings;

namespace Tetrix.src
{
    public interface GameEnvironmentIF
    {
        void setGameSettings(GameSettings gameSettings);
        ReadOnlyGameSettingsIF getGameSettings();
    }
}
