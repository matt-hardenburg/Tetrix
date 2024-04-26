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
        }

        public List<Thread> start()
        {
            List<Thread> threads = new List<Thread>();
            
            //thread creation
            foreach (GameElementIF gameComponent in gameComponents)
            {
                Thread thread;
                if (gameComponent is Board)
                {
                    //TODO: input functionality untested
                    thread = new Thread(new ThreadStart(new InputThread((Board)gameComponent).run));
                    thread.Name = "Input";
                    threads.Add(thread);

                    thread = new Thread(new ThreadStart(new GameThread(getGameSettings(), (Board)gameComponent).run));
                    thread.Name = "Game";
                    threads.Add(thread);

                    getGameSettings().getShapeBuilder().generateShape();
                    ((Board)gameComponent).addShapeToBoard(getGameSettings().getShapeBuilder().getShape());
                }
                else if (gameComponent is Components.Timer)
                {
                    thread = new Thread(new ThreadStart(new TimerThread((Components.Timer)gameComponent).run));
                    thread.Name = "Timer";
                    threads.Add(thread);
                }
                else if (gameComponent is Game)
                {
                    thread = new Thread(new ThreadStart(new GraphicsThread((Game)gameComponent).run));
                    thread.Name = "Graphics";
                    threads.Add(thread);
                }
            }

            //foreach (Thread thread in threads) thread.Start();

            return threads;
        }

        public void exit(List<Thread>? threads)
        {
            if (threads is null) return;
            Terminator.doShutDown();
            foreach (Thread thread in threads) thread.Join();
        }

        public void draw()
        {
            foreach (GameElementIF gameElement in gameComponents) if (gameElement is not Game) gameElement.draw();
        }

        public List<GameElementIF> getGameComponents()
        {
            return gameComponents;
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
                    App? app = Application.OpenForms["App"] as App;
                    exit(app?.getThreads());
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
