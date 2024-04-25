using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetrix
{
    public class Game : GameElementIF, GameEnvironmentIF, ObserverIF
    {
        private GameModeAC gameMode;
        private List<GameElementIF> gameComponents;
        private ReadOnlyGameSettingsIF gameSettings;
        private List<Thread> threads;

        //Lots of casting between game components, should eliminate

        public Game(string gameMode)
        {
            Type type = Type.GetType("Tetrix." + gameMode + "GameMode");
            object obj = Activator.CreateInstance(type, this);
            if (obj != null && obj is GameModeAC) {
                this.gameMode = (GameModeAC) obj;
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
            foreach (GameElementIF gameComponent in  gameComponents)
            {
                if (gameComponent is Board)
                {
                    Thread thread = new Thread(new InputThread((Board)gameComponent).run);
                    threads.Add(thread);
                    thread = new Thread(new GameThread(this.getGameSettings(), (Board)gameComponent).run);
                    threads.Add(thread);
                }
                else if (gameComponent is Timer)
                {
                    Thread thread = new Thread(new TimerThread((Timer) gameComponent).run);
                    threads.Add(thread);
                }
                else if (gameComponent is Game)
                {
                    Thread thread = new Thread(new GraphicsThread((Game)gameComponent).run);
                    threads.Add(thread);
                }
            }
            foreach (Thread thread in threads)  
            {
                thread.Start();
            }
        }

        public void exit()
        {
            Terminator.doShutDown();
            foreach (Thread thread in threads)
            {
                thread.Join();
            }
        }

        public void draw()
        {
            foreach(GameElementIF gameElement in gameComponents)
            {
                gameElement.draw();
            }
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

        public void notify(int eventNum)
        {
            switch (eventNum)
            {
                case (int)Board.Events.TopOfScreen:
                    this.exit();
                    break;
                case (int)Board.Events.PieceStopped:
                    foreach (Board board in gameComponents)
                    {
                        ShapeBuilderIF shapeBuilder = gameSettings.getShapeBuilder();
                        shapeBuilder.generateShape();
                        board.addShapeToBoard(shapeBuilder.getShape());
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
