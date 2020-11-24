using System;
using Raylib_cs;

namespace GameEngine
{
    public class Player : Character
    {
        /*Weapon class goes here*/

        Rectangle Body = new Rectangle(10, 10, 50, 50);

        public override void Update()
        {
            if(Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Body.x += 1;
            }
        }

        public override void Draw()
        {
            Raylib.DrawRectangleRec(Body, Color.DARKBLUE);
        }
    }
}
