using Tetrix.src.Components;
using Tetrix.src.Components.Shape;
using Tetrix.src.Modes;
using Tetrix.src.Settings;
using Tetrix.src.Observer;
using Tetrix.src.Threads;

namespace Tetrix.src
{
    public class Game : GameElementIF, GameEnvironmentIF, ObserverIF
    {
        private GameModeAC gameMode;
        private List<GameElementIF> gameComponents;
        private ReadOnlyGameSettingsIF gameSettings;
        private readonly List<Thread> threads;

        //Lots of casting between game components, should eliminate

        public Game(string gameMode)
        {
            Type type = Type.GetType("Tetrix.src.Modes." + gameMode + "GameMode");
            object obj = Activator.CreateInstance(type, this);
            if (obj != null && obj is GameModeAC)
            {
                this.gameMode = (GameModeAC)obj;
            }
            else
            {
                this.gameMode = new NormalGameMode(this);
            }

            gameComponents = new List<GameElementIF>();
            gameComponents.Add(this);
            gameSettings = new GameSettings();
            threads = new List<Thread>();
        }

        public void start()
        {
            //thread creation
            foreach (GameElementIF gameComponent in gameComponents)
            {
                if (gameComponent is Board)
                {
                    threads.Add(new Thread(new InputThread((Board)gameComponent).run));
                    threads.Add(new Thread(new GameThread(getGameSettings(),
                                                            (Board)gameComponent).run));
                }
                else if (gameComponent is Components.Timer)
                    threads.Add(new Thread(new TimerThread((Components.Timer)gameComponent).run));
                else if (gameComponent is Game)
                    threads.Add(new Thread(new GraphicsThread((Game)gameComponent).run));
            }

            foreach (Thread thread in threads) thread.Start();
        }

        public void exit()
        {
            Terminator.doShutDown();
            foreach (Thread thread in threads) thread.Join();
        }

        public void draw()
        {
            foreach (GameElementIF gameElement in gameComponents) gameElement.draw();
        }

        public List<GameElementIF> getGameComponents()
        {
            return gameComponents;
        }

        public List<Thread> getThreads()
        {
            return threads;
        }

        public void setGameSettings(GameSettings gameSettings)
        {
            this.gameSettings = gameSettings;
        }

        public void notify(Board.Events _event)
        {
            switch (_event)
            {
                case Board.Events.TopOfScreen:
                    exit();
                    break;
                case Board.Events.PieceStopped:
                    foreach (GameElementIF element in gameComponents)
                    {
                        if (element is Board)
                        {
                            ShapeBuilderIF shapeBuilder = gameSettings.getShapeBuilder();
                            shapeBuilder.generateShape();
                            ((Board)element).addShapeToBoard(shapeBuilder.getShape());
                        }
                    }
                    break;
            }
        }

        public ReadOnlyGameSettingsIF getGameSettings()
        {
            return gameSettings;
        }
    }
}
