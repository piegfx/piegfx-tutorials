using Easel;
using Easel.Scenes;
using Easel.Entities;
using Easel.Math;
using Pie.Windowing;

namespace MyFirstEaselGame;

public class MyScene : Scene
{
    protected override void Initialize()
    {
        base.Initialize();
        
        Camera.Main.ClearColor = Color.CornflowerBlue;
    }

    protected override void Update()
    {
        base.Update();

        if (Input.KeyPressed(Key.Escape))
            Game.Close();
    }
}
