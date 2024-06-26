﻿using Tetrix.src.Components;
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
        private List<Thread> threads;

        public Game(string gameMode)
        {
            Type type = Type.GetType("Tetrix.src.Modes." + gameMode + "GameMode");
            object obj = Activator.CreateInstance(type, this);

            if (obj != null && obj is GameModeAC) this.gameMode = (GameModeAC) obj;
            else this.gameMode = new NormalGameMode(this);

            gameComponents = [this];
            gameSettings = new GameSettings();
            this.gameMode.setMode();
            threads = new List<Thread>();
        }

        public List<InputThread> start(uint[] highScores, Panel boardPanel, Label gameOverLabel, Button returnButton )
        {
            Terminator.resetShutDown();
            List<InputThread> inputThreads = new List<InputThread>();
            foreach (GameElementIF gameComponent in gameComponents)
            {
                Thread thread;
                if (gameComponent is Board)
                {
                    InputThread inputThread = new InputThread((Board)gameComponent);
                    Thread iThread = new Thread(new ThreadStart(inputThread.run));
                    iThread.Name = "Input";
                    threads.Add(iThread);
                    inputThreads.Add(inputThread);
                    foreach (GameElementIF scoreComponent  in gameComponents)
                    {
                        if (scoreComponent is Score score)
                        {
                            thread = new Thread(new ThreadStart(new GameThread(getGameSettings(), (Board)gameComponent, highScores, score).run));
                            thread.Name = "Game";
                            threads.Add(thread);
                        }
                    }

                    getGameSettings().getShapeBuilder().generateShape();
                    ((Board)gameComponent).addShapeToBoard(getGameSettings().getShapeBuilder().getShape());
                }
                else if (gameComponent is Components.Timer timer)
                {
                    thread = new Thread(new ThreadStart(new TimerThread(timer).run));
                    thread.Name = "Timer";
                    threads.Add(thread);
                }
                else if (gameComponent is Game game)
                {
                    thread = new Thread(new ThreadStart(new GraphicsThread(game, boardPanel, gameOverLabel, returnButton).run));
                    thread.Name = "Graphics";
                    threads.Add(thread);
                }
            }

            foreach (Thread thread in threads) thread.Start();

            return inputThreads;
        }

        public void exit()
        {
            Terminator.doShutDown();
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
                    this.exit();
                    break;
                case Board.Events.PieceStopped:
                    foreach (GameElementIF element in gameComponents)
                    {
                        if (element is Board board)
                        {
                            ShapeBuilderIF shapeBuilder = gameSettings.getShapeBuilder();
                            shapeBuilder.generateShape();
                            board.addShapeToBoard(shapeBuilder.getShape());
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