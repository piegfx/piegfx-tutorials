using Easel;
using MyFirstEaselGame;

Logger.UseConsoleLogs();

GameSettings settings = new GameSettings();

using EaselGame game = new EaselGame(settings, new MyScene());
game.Run();

